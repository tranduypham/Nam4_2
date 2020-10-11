Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO

Namespace CountWordsNumber
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_1.docx")

			'Count the number of words.
			Dim content As New StringBuilder()
			content.AppendLine("CharCount: " & document.BuiltinDocumentProperties.CharCount)
			content.AppendLine("CharCountWithSpace: " & document.BuiltinDocumentProperties.CharCountWithSpace)
			content.AppendLine("WordCount: " & document.BuiltinDocumentProperties.WordCount)

			'Save to file.
			Dim result As String = "Result-CountWordsNumber.txt"
			File.WriteAllText(result, content.ToString())

			'Launch the file.
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
