Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports System.IO

Namespace CreateTableFromHTML
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'HTML string
			Dim HTML As String = "<table border='2px'>" & "<tr>" & "<td>Row 1, Cell 1</td>" & "<td>Row 1, Cell 2</td>" & "</tr>" & "<tr>" & "<td>Row 2, Cell 2</td>" & "<td>Row 2, Cell 2</td>" & "</tr>" & "</table>"

			'Create a Word document
			Dim document As New Document()

			'Add a section
			Dim section As Section = document.AddSection()

			'Add a paragraph and append html string
			section.AddParagraph().AppendHTML(HTML)

			'Save to Word document
			Dim output As String = "CreateTableFromHTML_out.docx"
			document.SaveToFile(output, FileFormat.Docx2013)

			'Launch the file
			WordDocViewer(output)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
