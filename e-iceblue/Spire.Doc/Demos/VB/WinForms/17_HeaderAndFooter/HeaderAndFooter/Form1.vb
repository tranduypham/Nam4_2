Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace HeaderAndFooter
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create word document
			Dim document As New Document()

			document.LoadFromFile("..\..\..\..\..\..\Data\Sample.docx")
			Dim section As Section = document.Sections(0)

			'insert header and footer
			InsertHeaderAndFooter(section)

			'Save as docx file.
			document.SaveToFile("Sample.docx",FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer("Sample.docx")
		End Sub

		Private Sub InsertHeaderAndFooter(ByVal section As Section)
			Dim header As HeaderFooter = section.HeadersFooters.Header
			Dim footer As HeaderFooter = section.HeadersFooters.Footer

			'insert picture and text to header
			Dim headerParagraph As Paragraph = header.AddParagraph()
			Dim headerPicture As DocPicture = headerParagraph.AppendPicture(Image.FromFile("..\..\..\..\..\..\Data\Header.png"))

			'header text
			Dim text As TextRange = headerParagraph.AppendText("Demo of Spire.Doc")
			text.CharacterFormat.FontName = "Arial"
			text.CharacterFormat.FontSize = 10
			text.CharacterFormat.Italic = True
			headerParagraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right

			'border
			headerParagraph.Format.Borders.Bottom.BorderType = Spire.Doc.Documents.BorderStyle.Single
			headerParagraph.Format.Borders.Bottom.Space = 0.05F


			'header picture layout - text wrapping
			headerPicture.TextWrappingStyle = TextWrappingStyle.Behind

			'header picture layout - position
			headerPicture.HorizontalOrigin = HorizontalOrigin.Page
			headerPicture.HorizontalAlignment = ShapeHorizontalAlignment.Left
			headerPicture.VerticalOrigin = VerticalOrigin.Page
			headerPicture.VerticalAlignment = ShapeVerticalAlignment.Top

			'insert picture to footer
			Dim footerParagraph As Paragraph = footer.AddParagraph()
			Dim footerPicture As DocPicture = footerParagraph.AppendPicture(Image.FromFile("..\..\..\..\..\..\Data\Footer.png"))

			'footer picture layout
			footerPicture.TextWrappingStyle = TextWrappingStyle.Behind
			footerPicture.HorizontalOrigin = HorizontalOrigin.Page
			footerPicture.HorizontalAlignment = ShapeHorizontalAlignment.Left
			footerPicture.VerticalOrigin = VerticalOrigin.Page
			footerPicture.VerticalAlignment = ShapeVerticalAlignment.Bottom

			'insert page number
			footerParagraph.AppendField("page number", FieldType.FieldPage)
			footerParagraph.AppendText(" of ")
			footerParagraph.AppendField("number of pages", FieldType.FieldNumPages)
			footerParagraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right

			'border
			footerParagraph.Format.Borders.Top.BorderType = Spire.Doc.Documents.BorderStyle.Single
			footerParagraph.Format.Borders.Top.Space = 0.05F
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
