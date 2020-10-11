Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace HtmlFileToWord
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open an html file.
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\..\Data\InputHtmlFile.html", FileFormat.Html, XHTMLValidationType.None)

			'Save it to a Word document.
			document.SaveToFile("HtmlFileToWord.docx", FileFormat.Docx)

			'Launch the file.
			WordDocViewer("HtmlFileToWord.docx")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
