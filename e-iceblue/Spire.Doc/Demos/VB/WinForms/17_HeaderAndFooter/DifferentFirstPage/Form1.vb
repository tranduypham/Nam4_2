Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace DifferentFirstPage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\MultiplePages.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the section and set the property true
			Dim section As Section = doc.Sections(0)
			section.PageSetup.DifferentFirstPageHeaderFooter = True

			'Set the first page header. Here we append a picture in the header
			Dim paragraph1 As Paragraph = section.HeadersFooters.FirstPageHeader.AddParagraph()
			paragraph1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right
			Dim headerimage As DocPicture = paragraph1.AppendPicture(Image.FromFile("..\..\..\..\..\..\Data\E-iceblue.png"))

			'Set the first page footer
			Dim paragraph2 As Paragraph = section.HeadersFooters.FirstPageFooter.AddParagraph()
			paragraph2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			Dim FF As TextRange = paragraph2.AppendText("First Page Footer")
			FF.CharacterFormat.FontSize = 10

			'Set the other header & footer. If you only need the first page header & footer, don't set this
			Dim paragraph3 As Paragraph = section.HeadersFooters.Header.AddParagraph()
			paragraph3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			Dim NH As TextRange = paragraph3.AppendText("Spire.Doc for .NET")
			NH.CharacterFormat.FontSize = 10

			Dim paragraph4 As Paragraph = section.HeadersFooters.Footer.AddParagraph()
			paragraph4.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			Dim NF As TextRange = paragraph4.AppendText("E-iceblue")
			NF.CharacterFormat.FontSize = 10

			'Save and launch document
			Dim output As String = "DifferentFirstPage.docx"
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
