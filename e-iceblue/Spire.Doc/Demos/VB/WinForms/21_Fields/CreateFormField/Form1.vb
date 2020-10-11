Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace CreateFormField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()
			Dim section As Section = document.AddSection()

			'Page setup.
			SetPage(section)

			'Insert header and footer.
			InsertHeaderAndFooter(section)

			'Add title.
			AddTitle(section)

			'Add form.
			AddForm(section)

			'Save doc file.
			document.SaveToFile("Sample.doc",FileFormat.Doc)

			'Launch the Word file.
			WordDocViewer("Sample.doc")


		End Sub

		Private Sub SetPage(ByVal section As Section)
			'the unit of all measures below is point, 1point = 0.3528 mm
			section.PageSetup.PageSize = PageSize.A4
			section.PageSetup.Margins.Top = 72f
			section.PageSetup.Margins.Bottom = 72f
			section.PageSetup.Margins.Left = 89.85f
			section.PageSetup.Margins.Right = 89.85f
		End Sub

		Private Sub InsertHeaderAndFooter(ByVal section As Section)
			'insert picture and text to header
			Dim headerParagraph As Paragraph = section.HeadersFooters.Header.AddParagraph()
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
			Dim footerParagraph As Paragraph = section.HeadersFooters.Footer.AddParagraph()
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

		Private Sub AddTitle(ByVal section As Section)
			Dim title As Paragraph = section.AddParagraph()
			Dim titleText As TextRange = title.AppendText("Create Your Account")
			titleText.CharacterFormat.FontSize = 18
			titleText.CharacterFormat.FontName = "Arial"
			titleText.CharacterFormat.TextColor = Color.FromArgb(&H0, &H71, &Hb6)
			title.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			title.Format.AfterSpacing = 8
		End Sub

		Private Sub AddForm(ByVal section As Section)
			Dim descriptionStyle As New ParagraphStyle(section.Document)
			descriptionStyle.Name = "description"
			descriptionStyle.CharacterFormat.FontSize = 12
			descriptionStyle.CharacterFormat.FontName = "Arial"
			descriptionStyle.CharacterFormat.TextColor = Color.FromArgb(&H0, &H45, &H8e)
			section.Document.Styles.Add(descriptionStyle)

			Dim p1 As Paragraph = section.AddParagraph()
			Dim text1 As String = "So that we can verify your identity and find your information, " & "please provide us with the following information. " & "This information will be used to create your online account. " & "Your information is not public, shared in anyway, or displayed on this site"
			p1.AppendText(text1)
			p1.ApplyStyle(descriptionStyle.Name)

			Dim p2 As Paragraph = section.AddParagraph()
			Dim text2 As String = "You must provide a real email address to which we will send your password."
			p2.AppendText(text2)
			p2.ApplyStyle(descriptionStyle.Name)
			p2.Format.AfterSpacing = 8

			'field group label style
			Dim formFieldGroupLabelStyle As New ParagraphStyle(section.Document)
			formFieldGroupLabelStyle.Name = "formFieldGroupLabel"
			formFieldGroupLabelStyle.ApplyBaseStyle("description")
			formFieldGroupLabelStyle.CharacterFormat.Bold = True
			formFieldGroupLabelStyle.CharacterFormat.TextColor = Color.White
			section.Document.Styles.Add(formFieldGroupLabelStyle)

			'field label style
			Dim formFieldLabelStyle As New ParagraphStyle(section.Document)
			formFieldLabelStyle.Name = "formFieldLabel"
			formFieldLabelStyle.ApplyBaseStyle("description")
			formFieldLabelStyle.ParagraphFormat.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right
			section.Document.Styles.Add(formFieldLabelStyle)

			'add table
			Dim table As Table = section.AddTable()

			'2 columns of per row
			table.DefaultColumnsNumber = 2

			'default height of row is 20point
			table.DefaultRowHeight = 20

			'load form config data
			Using stream As Stream = File.OpenRead("..\..\..\..\..\..\Data\Form.xml")
				Dim xpathDoc As New XPathDocument(stream)
				Dim sectionNodes As XPathNodeIterator = xpathDoc.CreateNavigator().Select("/form/section")
				For Each node As XPathNavigator In sectionNodes
					'create a row for field group label, does not copy format
					Dim row As TableRow = table.AddRow(False)
					row.Cells(0).CellFormat.BackColor = Color.FromArgb(&H0, &H71, &Hb6)
					row.Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle

					'label of field group
					Dim cellParagraph As Paragraph = row.Cells(0).AddParagraph()
					cellParagraph.AppendText(node.GetAttribute("name", ""))
					cellParagraph.ApplyStyle(formFieldGroupLabelStyle.Name)

					Dim fieldNodes As XPathNodeIterator = node.Select("field")
					For Each fieldNode As XPathNavigator In fieldNodes
						'create a row for field, does not copy format
						Dim fieldRow As TableRow = table.AddRow(False)

						'field label
						fieldRow.Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
						Dim labelParagraph As Paragraph = fieldRow.Cells(0).AddParagraph()
						labelParagraph.AppendText(fieldNode.GetAttribute("label", ""))
						labelParagraph.ApplyStyle(formFieldLabelStyle.Name)

						fieldRow.Cells(1).CellFormat.VerticalAlignment = VerticalAlignment.Middle
						Dim fieldParagraph As Paragraph = fieldRow.Cells(1).AddParagraph()
						Dim fieldId As String = fieldNode.GetAttribute("id", "")
						Select Case fieldNode.GetAttribute("type", "")
							Case "text"
								'add text input field
								Dim field As TextFormField = TryCast(fieldParagraph.AppendField(fieldId, FieldType.FieldFormTextInput), TextFormField)

								'set default text
								field.DefaultText = ""
								field.Text = ""

							Case "list"
								'add dropdown field
								Dim list As DropDownFormField = TryCast(fieldParagraph.AppendField(fieldId, FieldType.FieldFormDropDown), DropDownFormField)

								'add items into dropdown.
								Dim itemNodes As XPathNodeIterator = fieldNode.Select("item")
								For Each itemNode As XPathNavigator In itemNodes
									list.DropDownItems.Add(itemNode.SelectSingleNode("text()").Value)
								Next itemNode

							Case "checkbox"
								'add checkbox field
								fieldParagraph.AppendField(fieldId, FieldType.FieldFormCheckBox)
						End Select
					Next fieldNode

					'merge field group row. 2 columns to 1 column
					table.ApplyHorizontalMerge(row.GetRowIndex(), 0, 1)
				Next node
			End Using
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
