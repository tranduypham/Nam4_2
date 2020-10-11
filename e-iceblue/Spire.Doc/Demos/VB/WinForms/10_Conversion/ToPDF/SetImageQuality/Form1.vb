Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SetImageQuality
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\..\Data\Template_Doc_1.doc", FileFormat.Doc)

			'Set the output image quality to be 40% of the original image. The default set of the output image quality is 80% of the original.
			document.JPEGQuality = 40

			Dim result As String = "Result-DocToPDFImageQuality.pdf"

			'Save to file.
			document.SaveToFile(result, FileFormat.PDF)

			'Launch the Pdf file.
			WordDocViewer(result)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
