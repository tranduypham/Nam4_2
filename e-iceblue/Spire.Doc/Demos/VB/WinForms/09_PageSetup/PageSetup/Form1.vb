Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace PageSetup
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()
			Dim section As Section = document.AddSection()

			'The unit of all measures below is point, 1point = 0.3528 mm.
			section.PageSetup.PageSize = PageSize.A4
			section.PageSetup.Margins.Top = 72f
			section.PageSetup.Margins.Bottom = 72f
			section.PageSetup.Margins.Left = 89.85f
			section.PageSetup.Margins.Right = 89.85f

			'Insert header and footer.
			InsertHeaderAndFooter(section)

			addTable(section)

			'Save doc file.
			document.SaveToFile("Sample.doc",FileFormat.Doc)

			'Launch the Word file.
			WordDocViewer("Sample.doc")


		End Sub

		Private Sub addTable(ByVal section As Section)
			Dim header() As String = { "Name", "Capital", "Continent", "Area", "Population" }
			Dim data()() As String = { New String(){"Argentina", "Buenos Aires", "South America", "2777815", "32300003"}, New String(){"Bolivia", "La Paz", "South", "1098575", "7300000"}, New String(){"Brazil", "Brasilia", "South", "8511196", "150400000"}, New String(){"Canada", "Ottawa", "North", "9976147", "26500000"}, New String(){"Chile", "Santiago", "South", "756943", "13200000"}, New String(){"Colombia", "Bagota", "South", "1138907", "33000000"}, New String(){"Cuba", "Havana", "North", "114524", "10600000"}, New String(){"Ecuador", "Quito", "South", "455502", "10600000"}, New String(){"El Salvador", "San Salvador", "North", "20865", "5300000"}, New String(){"Guyana", "Georgetown", "South", "214969", "800000"}, New String(){"Jamaica", "Kingston", "North", "11424", "2500000"}, New String(){"Mexico", "Mexico City", "North", "1967180", "88600000"}, New String(){"Nicaragua", "Managua", "North", "139000", "3900000"}, New String(){"Paraguay", "Asuncion", "South", "406576", "4660000"}, New String(){"Peru", "Lima", "South", "1285215", "21600000"}, New String(){"United States", "Washington", "North", "9363130", "249200000"}, New String(){"Uruguay", "Montevideo", "South", "176140", "3002000"}, New String(){"Venezuela", "Caracas", "South", "912047", "19700000"} }
			Dim table As Spire.Doc.Table = section.AddTable(True)
			table.ResetCells(data.Length + 1, header.Length)

			' ***************** First Row *************************
			Dim row As TableRow = table.Rows(0)
			row.IsHeader = True
			row.Height = 20
			row.HeightType = TableRowHeightType.Exactly
			row.RowFormat.BackColor = Color.Gray
			For i As Integer = 0 To header.Length - 1
				row.Cells(i).CellFormat.VerticalAlignment = VerticalAlignment.Middle
				Dim p As Paragraph = row.Cells(i).AddParagraph()
				p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
				Dim txtRange As TextRange = p.AppendText(header(i))
				txtRange.CharacterFormat.Bold = True
			Next i

			For r As Integer = 0 To data.Length - 1
				Dim dataRow As TableRow = table.Rows(r + 1)
				dataRow.Height = 20
				dataRow.HeightType = TableRowHeightType.Exactly
				dataRow.RowFormat.BackColor = Color.Empty
				For c As Integer = 0 To data(r).Length - 1
					dataRow.Cells(c).CellFormat.VerticalAlignment = VerticalAlignment.Middle
					dataRow.Cells(c).AddParagraph().AppendText(data(r)(c))
				Next c
			Next r
		End Sub

		Private Sub InsertHeaderAndFooter(ByVal section As Section)
			Dim header As HeaderFooter = section.HeadersFooters.Header
			Dim footer As HeaderFooter = section.HeadersFooters.Footer

			'Insert picture and text to header.
			Dim headerParagraph As Paragraph = header.AddParagraph()
			Dim headerPicture As DocPicture = headerParagraph.AppendPicture(Image.FromFile("..\..\..\..\..\..\Data\Header.png"))

			'Header text.
			Dim text As TextRange = headerParagraph.AppendText("Demo of Spire.Doc")
			text.CharacterFormat.FontName = "Arial"
			text.CharacterFormat.FontSize = 10
			text.CharacterFormat.Italic = True
			headerParagraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right

			'Border.
			headerParagraph.Format.Borders.Bottom.BorderType = Spire.Doc.Documents.BorderStyle.Single
			headerParagraph.Format.Borders.Bottom.Space = 0.05F


			'Header picture layout - text wrapping.
			headerPicture.TextWrappingStyle = TextWrappingStyle.Behind

			'Header picture layout - position.
			headerPicture.HorizontalOrigin = HorizontalOrigin.Page
			headerPicture.HorizontalAlignment = ShapeHorizontalAlignment.Left
			headerPicture.VerticalOrigin = VerticalOrigin.Page
			headerPicture.VerticalAlignment = ShapeVerticalAlignment.Top

			'Insert picture to footer.
			Dim footerParagraph As Paragraph = footer.AddParagraph()
			Dim footerPicture As DocPicture = footerParagraph.AppendPicture(Image.FromFile("..\..\..\..\..\..\Data\Footer.png"))

			'Footer picture layout.
			footerPicture.TextWrappingStyle = TextWrappingStyle.Behind
			footerPicture.HorizontalOrigin = HorizontalOrigin.Page
			footerPicture.HorizontalAlignment = ShapeHorizontalAlignment.Left
			footerPicture.VerticalOrigin = VerticalOrigin.Page
			footerPicture.VerticalAlignment = ShapeVerticalAlignment.Bottom

			'Insert page number.
			footerParagraph.AppendField("page number", FieldType.FieldPage)
			footerParagraph.AppendText(" of ")
			footerParagraph.AppendField("number of pages", FieldType.FieldNumPages)
			footerParagraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right

			'Border.
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
