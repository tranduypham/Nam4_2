Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace ImageWaterMark
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document as template.
			Dim document As New Document("..\..\..\..\..\..\Data\Template.docx")

			'Insert the imgae watermark.
			InsertImageWatermark(document)
			'Save as docx file.
			document.SaveToFile("Sample.docx", FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer("Sample.docx")


		End Sub

		Private Sub InsertImageWatermark(ByVal document As Document)
			Dim picture As New PictureWatermark()
			picture.Picture = Image.FromFile("..\..\..\..\..\..\Data\ImageWatermark.png")
			picture.Scaling = 250
			picture.IsWashout = False
			document.Watermark = picture
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
