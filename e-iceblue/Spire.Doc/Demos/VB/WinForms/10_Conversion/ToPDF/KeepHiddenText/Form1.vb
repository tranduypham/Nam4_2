Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace KeepHiddenText
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

			'When convert to PDF file, set the property IsHidden as true.
			Dim pdf As New ToPdfParameterList()
			pdf.IsHidden = True

			Dim result As String = "Result-SaveTheHiddenTextToPDF.pdf"

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
