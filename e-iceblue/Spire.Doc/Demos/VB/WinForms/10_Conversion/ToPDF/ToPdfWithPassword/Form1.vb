Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc

Namespace ToPdfWithPassword
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'create word document
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\..\Data\ConvertedTemplate.docx")

			'create a parameter
			Dim toPdf As New ToPdfParameterList()

			'set the password
			Dim password As String = "E-iceblue"
			toPdf.PdfSecurity.Encrypt(password, password, Spire.Pdf.Security.PdfPermissionsFlags.Default, Spire.Pdf.Security.PdfEncryptionKeySize.Key128Bit)
			'save doc file.
			document.SaveToFile("EncryptWithPassword.pdf", toPdf)

			'view the PDF file.
			WordDocViewer("EncryptWithPassword.pdf")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
