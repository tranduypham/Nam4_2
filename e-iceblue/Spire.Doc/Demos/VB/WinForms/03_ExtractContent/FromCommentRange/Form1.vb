Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace FromCommentRange
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim sourceDoc As New Document()

			'Load the document from disk.
			sourceDoc.LoadFromFile("..\..\..\..\..\..\Data\Comments.docx")

			'Create a destination document
			Dim destinationDoc As New Document()

			'Add section for destination document
			Dim destinationSec As Section = destinationDoc.AddSection()

			'Get the first comment
			Dim comment As Comment = sourceDoc.Comments(0)

			'Get the paragraph of obtained comment
			Dim para As Paragraph = comment.OwnerParagraph

			'Get index of the CommentMarkStart 
			Dim startIndex As Integer = para.ChildObjects.IndexOf(comment.CommentMarkStart)

			'Get index of the CommentMarkEnd
			Dim endIndex As Integer = para.ChildObjects.IndexOf(comment.CommentMarkEnd)

			'Traverse paragraph ChildObjects
			For i As Integer = startIndex To endIndex
				'Clone the ChildObjects of source document
				Dim doobj As DocumentObject = para.ChildObjects(i).Clone()

				'Add to destination document 
				destinationSec.AddParagraph().ChildObjects.Add(doobj)
			Next i
			'Save the destination document
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
