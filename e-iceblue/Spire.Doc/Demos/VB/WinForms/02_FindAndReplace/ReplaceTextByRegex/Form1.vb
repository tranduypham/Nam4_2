Imports System.Text
Imports Spire.Doc
Imports System.Text.RegularExpressions

Namespace ReplaceTextByRegex
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'create a document
			Dim doc As New Document()

			'Load the document from disk.
			doc.LoadFromFile("..\..\..\..\..\..\Data\ReplaceTextByRegex.docx")

			'create a regex, match the text that starts with #
			Dim regex As New Regex("\#\w+\b")

			'replace the text by regex
			doc.Replace(regex, "Spire.Doc")

			'save the document
			doc.SaveToFile("output.docx", FileFormat.Docx)

			'view the document
			WordDocViewer("output.docx")

		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
