Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace WordToPdfEncrypt
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_2.docx")

			'Create an instance of ToPdfParameterList.
			Dim toPdf As New ToPdfParameterList()

			'Set the user password for the resulted PDF file.
			toPdf.PdfSecurity.Encrypt("e-iceblue")

			Dim result As String = "Result-WordToPdfEncrypt.pdf"

			'Save to file.
			document.SaveToFile(result, toPdf)

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
