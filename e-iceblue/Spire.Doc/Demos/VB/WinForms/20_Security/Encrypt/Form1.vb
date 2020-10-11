Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace Encrypt
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create word document
			Dim document As New Document()

			'Load Word document.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template.docx")

			'encrypt document with password specified by textBox1
			document.Encrypt("E-iceblue")

			'Save as docx file.
			document.SaveToFile("Sample.docx",FileFormat.Docx)

			'Launching the MS Word file.
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
