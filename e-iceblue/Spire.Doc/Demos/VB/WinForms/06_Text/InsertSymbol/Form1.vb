Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertSymbol
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Add a section.
			Dim section As Section = document.AddSection()

			'Add a paragraph.
			Dim paragraph As Paragraph = section.AddParagraph()

			'Use unicode characters to create symbol Ä.
			Dim tr As TextRange = paragraph.AppendText(ChrW(&H00c4).ToString())

			'Set the color of symbol Ä.
			tr.CharacterFormat.TextColor = Color.Red

			'Add symbol Ë.
			paragraph.AppendText(ChrW(&H00cb).ToString())

			Dim result As String = "Result-InsertSymbol.docx"

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
