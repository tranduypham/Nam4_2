Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace InsertDocAtBookmark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create the first document
			Dim document1 As New Document()

			'Load the first document from disk.
			document1.LoadFromFile("..\..\..\..\..\..\Data\Bookmark.docx")

			'Create the second document
			Dim document2 As New Document()

			'Load the second document from disk.
			document2.LoadFromFile("..\..\..\..\..\..\Data\Insert.docx")

			'Get the first section of the first document 
			Dim section1 As Section = document1.Sections(0)

			'Locate the bookmark
			Dim bn As New BookmarksNavigator(document1)

			'Find bookmark by name
			bn.MoveToBookmark("Test", True, True)

			'Get bookmarkStart
			Dim start As BookmarkStart = bn.CurrentBookmark.BookmarkStart

			'Get the owner paragraph
			Dim para As Paragraph = start.OwnerParagraph

			'Get the para index
			Dim index As Integer = section1.Body.ChildObjects.IndexOf(para)

			'Insert the paragraphs of document2
			For Each section2 As Section In document2.Sections
				For Each paragraph As Paragraph In section2.Paragraphs
					section1.Body.ChildObjects.Insert(index + 1, TryCast(paragraph.Clone(), Paragraph))
				Next paragraph
			Next section2

			'Save the document.
			document1.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
