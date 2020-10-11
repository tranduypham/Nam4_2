Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace Comment
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document from disk.
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\CommentTemplate.docx")

			InsertComments(document.Sections(0))

			'Save the document.
			document.SaveToFile("Output.docx",FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub

		Private Sub InsertComments(ByVal section As Section)
			'Insert comment.
			Dim paragraph As Paragraph = section.Paragraphs(1)
			Dim comment As Spire.Doc.Fields.Comment = paragraph.AppendComment("Spire.Doc for .NET")
			comment.Format.Author = "E-iceblue"
			comment.Format.Initial = "CM"
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
