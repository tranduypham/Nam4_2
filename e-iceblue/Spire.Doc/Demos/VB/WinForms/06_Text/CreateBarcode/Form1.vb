Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace CreateBarcode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim doc As New Document()

			'Add a paragraph
			Dim p As Paragraph = doc.AddSection().AddParagraph()

			'Add barcode and set its format
			Dim txtRang As TextRange = p.AppendText("H63TWX11072")
			'Set barcode font name, note you need to install the barcode font on your system at first
			txtRang.CharacterFormat.FontName = "C39HrP60DlTt"
			txtRang.CharacterFormat.FontSize = 80
			txtRang.CharacterFormat.TextColor = Color.SeaGreen

			'Save and launch document
			Dim output As String = "CreateBarcode.docx"
			doc.SaveToFile(output, FileFormat.Docx)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
