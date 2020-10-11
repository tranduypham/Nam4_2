Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports System.Text

Namespace AddBarcodeImage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\SampleB_2.docx")

			Dim imgPath As String = "..\..\..\..\..\..\Data\barcode.png"

			'Add barcode image
			Dim picture As DocPicture = document.Sections(0).AddParagraph().AppendPicture(Image.FromFile(imgPath))

			'Save to file
			document.SaveToFile("result.docx", FileFormat.Docx)

			'Launch result file
			WordDocViewer("result.docx")

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
