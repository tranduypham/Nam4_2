Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace DisableHyperlinks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\..\Data\Template_Docx_5.docx")

			'Create an instance of ToPdfParameterList.
			Dim pdf As New ToPdfParameterList()

			'Set DisableLink to true to remove the hyperlink effect for the result PDF page. 
			'Set DisableLink to false to preserve the hyperlink effect for the result PDF page.
			pdf.DisableLink = True

			Dim result As String = "Result-DisableHyperlinks.pdf"

			'Save to file.
			document.SaveToFile(result, pdf)

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
