Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace HelloWorld
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create word document
			Dim document As New Document()

			'Create a new section
			Dim section As Section = document.AddSection()

			'Create a new paragraph
			Dim paragraph As Paragraph = section.AddParagraph()

			'Append Text
			paragraph.AppendText("Hello World!")

			'Save doc file.
			document.SaveToFile("Sample.docx",FileFormat.Docx)

			'Launching the Word file.
			WordDocViewer("Sample.docx")


		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
