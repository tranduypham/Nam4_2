Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace InsertSectionBreak
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

			'Insert section break. There are five section break options including EvenPage, NewColumn, NewPage, NoBreak, OddPage.
			document.Sections(0).Paragraphs(1).InsertSectionBreak(SectionBreakType.NoBreak)

			Dim result As String = "Result-InsertSectionBreak.docx"

			'Save the file.
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
