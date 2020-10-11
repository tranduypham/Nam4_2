Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace AlterLanguageDictionary
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Add new section and paragraph to the document.
			Dim sec As Section = document.AddSection()
			Dim para As Paragraph = sec.AddParagraph()

			'Add a textRange for the paragraph and append some Peru Spanish words.
			Dim txtRange As TextRange = para.AppendText("corrige seg¨²n diccionario en ingl¨¦s")
			txtRange.CharacterFormat.LocaleIdASCII = 10250

			Dim result As String = "Result-AlterLanguageDictionary.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

			'Launch the MS Word file.
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
