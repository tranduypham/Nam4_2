Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace FromBookmark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create the source document
			Dim sourcedocument As New Document()

			'Load the source document from disk.
			sourcedocument.LoadFromFile("..\..\..\..\..\..\Data\Bookmark.docx")

			'Create a destination document
			Dim destinationDoc As New Document()

			'Add a section for destination document
			Dim section As Section = destinationDoc.AddSection()

			'Add a paragraph for destination document
			Dim paragraph As Paragraph = section.AddParagraph()

			'Locate the bookmark in source document
			Dim navigator As New BookmarksNavigator(sourcedocument)

			'Find bookmark by name
			navigator.MoveToBookmark("Test", True, True)

			'get text body part
			Dim textBodyPart As TextBodyPart = navigator.GetBookmarkContent()

			'Create a TextRange type list
			Dim list As New List(Of TextRange)()

			'Traverse the items of text body
			For Each item In textBodyPart.BodyItems
				'if it is paragraph
				If TypeOf item Is Paragraph Then
					'Traverse the ChildObjects of the paragraph
					For Each childObject In (TryCast(item, Paragraph)).ChildObjects
						'if it is TextRange
						If TypeOf childObject Is TextRange Then
							'Add it into list
							Dim range As TextRange = TryCast(childObject, TextRange)
							list.Add(range)
						End If
					Next childObject
				End If
			Next item

			'Add the extract content to destinationDoc document
			For m As Integer = 0 To list.Count - 1
				paragraph.Items.Add(list(m).Clone())
			Next m

			'Save the document.
			destinationDoc.SaveToFile("Output.docx", FileFormat.Docx)

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
