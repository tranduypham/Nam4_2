Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace AddPageBorders
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

			'Get the first section.
			Dim section As Section = document.Sections(0)

			'Add page borders with special style and color.
			section.PageSetup.Borders.BorderType = Spire.Doc.Documents.BorderStyle.DoubleWave
			section.PageSetup.Borders.Color = Color.LightSeaGreen

			'Set the space between border and text.
			section.PageSetup.Borders.Left.Space = 50
			section.PageSetup.Borders.Right.Space = 50

			Dim result As String = "Result-AddPageBorders.docx"

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
