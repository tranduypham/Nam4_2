Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertImageAtBookmark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\Bookmark.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Create an instance of BookmarksNavigator
			Dim bn As New BookmarksNavigator(doc)

			'Find a bookmark named Test
			bn.MoveToBookmark("Test", True, True)

			'Add a section
			Dim section0 As Section = doc.AddSection()

			'Add a paragraph for the section
			Dim paragraph As Paragraph = section0.AddParagraph()
			Dim image As Image = Image.FromFile("..\..\..\..\..\..\Data\Word.png")

			'Add a picture into the paragraph
			Dim picture As DocPicture = paragraph.AppendPicture(image)

			'Add the paragraph at the position of bookmark
			bn.InsertParagraph(paragraph)

			'Remove the section0
			doc.Sections.Remove(section0)

			'Save and launch document
			Dim output As String = "InsertImageAtBookmark.docx"
			doc.SaveToFile(output, FileFormat.Docx)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
