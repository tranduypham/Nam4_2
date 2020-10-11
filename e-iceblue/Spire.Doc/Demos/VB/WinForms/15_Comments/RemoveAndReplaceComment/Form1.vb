Imports Spire.Doc


Namespace RemoveAndReplaceComment
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\CommentSample.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Replace the content of the first comment
			doc.Comments(0).Body.Paragraphs(0).Replace("This is the title", "This comment is changed.", False, False)

			'Remove the second comment
			doc.Comments.RemoveAt(1)

			'Save and launch
			Dim output As String = "RemoveAndReplaceComment.docx"
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
