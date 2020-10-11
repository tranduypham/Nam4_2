Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace TextWaterMark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document as template.
			Dim document As New Document("..\..\..\..\..\..\Data\Template.docx")

			'Insert text watermark.
			InsertTextWatermark(document.Sections(0))
			'Save as docx file.
			document.SaveToFile("Sample.docx",FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer("Sample.docx")


		End Sub
		Private Sub InsertTextWatermark(ByVal section As Section)
            Dim txtWatermark As New Spire.Doc.TextWatermark()
			txtWatermark.Text = "E-iceblue"
			txtWatermark.FontSize = 95
			txtWatermark.Color = Color.Blue
			txtWatermark.Layout = WatermarkLayout.Diagonal
			section.Document.Watermark = txtWatermark

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
