Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.Text.RegularExpressions

Namespace RemoveTableOfContent
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()

			'Load the document from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\TableOfContent.docx")

			'Get the first body from the first section
			Dim body As Body = document.Sections(0).Body

			'Remove TOC from first body
			Dim regex As New Regex("TOC\w+")
			Dim i As Integer = 0
			Do While i < body.Paragraphs.Count
				If regex.IsMatch(body.Paragraphs(i).StyleName) Then
					body.Paragraphs.RemoveAt(i)
					i -= 1
				End If
				i += 1
			Loop

			'Save the document.
			document.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
