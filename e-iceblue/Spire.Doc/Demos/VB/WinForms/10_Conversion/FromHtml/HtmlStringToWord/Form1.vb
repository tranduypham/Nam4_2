Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports System.IO

Namespace HtmlStringToWord
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Get html string.
			Dim HTML As String = File.ReadAllText("..\..\..\..\..\..\..\Data\InputHtml.txt")

			'Create a new document.
			Dim document As New Document()

			'Add a section.
			Dim sec As Section = document.AddSection()

			'Add a paragraph and append html string.
			sec.AddParagraph().AppendHTML(HTML)

			'Save it to a Word file.
			document.SaveToFile("HtmlFileToWord.docx", FileFormat.Docx)

			'Launch the Word file.
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
