Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace SetSpacing
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

			'Add the text strings to the paragraph and set the style.
			Dim para As New Paragraph(document)
			Dim textRange1 As TextRange = para.AppendText("This is an inserted paragraph.")
			textRange1.CharacterFormat.TextColor = Color.Blue
			textRange1.CharacterFormat.FontSize = 15

			'set the spacing before and after.
			para.Format.BeforeAutoSpacing = False
			para.Format.BeforeSpacing = 10
			para.Format.AfterAutoSpacing = False
			para.Format.AfterSpacing = 10

			'insert the added paragraph to the word document.
			document.Sections(0).Paragraphs.Insert(1, para)

			Dim result As String = "Result-SetTheSpacing.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

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
