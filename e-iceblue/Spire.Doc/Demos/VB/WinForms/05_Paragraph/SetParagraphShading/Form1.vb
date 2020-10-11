Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace SetParagraphShading
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

			'Get a paragraph.
			Dim paragaph As Paragraph = document.Sections(0).Paragraphs(0)

			'Set background color for the paragraph.
			paragaph.Format.BackColor = Color.Yellow

			'Set background color for the selected text of paragraph.
			paragaph = document.Sections(0).Paragraphs(2)
			Dim selection As TextSelection = paragaph.Find("Christmas", True, False)
			Dim range As TextRange = selection.GetAsOneRange()
			range.CharacterFormat.TextBackgroundColor = Color.Yellow

			Dim result As String = "Result-SetParagraphShading.docx"

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
