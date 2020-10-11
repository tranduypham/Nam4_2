Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace PageBorderSurround
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new document
			Dim doc As New Document()
			Dim section As Section = doc.AddSection()

			'Add a sample page border to the document
			section.PageSetup.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Wave
			section.PageSetup.Borders.Color = Color.Green
			section.PageSetup.Borders.Left.Space = 20
			section.PageSetup.Borders.Right.Space = 20

			'Add a header and set its format
			Dim paragraph1 As Paragraph = section.HeadersFooters.Header.AddParagraph()
			paragraph1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right
			Dim headerText As TextRange = paragraph1.AppendText("Header isn't included in page border")
			headerText.CharacterFormat.FontName = "Calibri"
			headerText.CharacterFormat.FontSize = 20
			headerText.CharacterFormat.Bold = True

			'Add a footer and set its format
			Dim paragraph2 As Paragraph = section.HeadersFooters.Footer.AddParagraph()
			paragraph2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left
			Dim footerText As TextRange = paragraph2.AppendText("Footer is included in page border")
			footerText.CharacterFormat.FontName = "Calibri"
			footerText.CharacterFormat.FontSize = 20
			footerText.CharacterFormat.Bold = True

			'Set the header not included in the page border while the footer included
			section.PageSetup.PageBorderIncludeHeader = False
			section.PageSetup.HeaderDistance = 40
			section.PageSetup.PageBorderIncludeFooter = True
			section.PageSetup.FooterDistance = 40

			'Save and launch document
			Dim output As String = "PageBorderSurround.docx"
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
