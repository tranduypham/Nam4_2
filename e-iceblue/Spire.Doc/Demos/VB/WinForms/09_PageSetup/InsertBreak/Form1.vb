Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertBreak
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create word document
			Dim document As New Document()

			Dim section As Section = document.AddSection()

			'page setup
			SetPage(section)

			'Add cover.
			InsertCover(section)

			'insert a break code
			section = document.AddSection()
			section.AddParagraph().InsertSectionBreak(SectionBreakType.NewPage)

			'add content
			InsertContent(section)

			'Save as doc file.
			document.SaveToFile("Sample.docx", FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer("Sample.docx")
		End Sub

		Private Sub SetPage(ByVal section As Section)
			'the unit of all measures below is point, 1point = 0.3528 mm
			section.PageSetup.PageSize = PageSize.A4
			section.PageSetup.Margins.Top = 72f
			section.PageSetup.Margins.Bottom = 72f
			section.PageSetup.Margins.Left = 89.85f
			section.PageSetup.Margins.Right = 89.85f
		End Sub

		Private Sub InsertCover(ByVal section As Section)
			Dim small As New ParagraphStyle(section.Document)
			small.Name = "small"
			small.CharacterFormat.FontName = "Arial"
			small.CharacterFormat.FontSize = 9
			small.CharacterFormat.TextColor = Color.Gray
			section.Document.Styles.Add(small)

			Dim paragraph As Paragraph = section.AddParagraph()
			paragraph.AppendText("The sample demonstrates how to insert section break.")
			paragraph.ApplyStyle(small.Name)

			Dim title As Paragraph = section.AddParagraph()
			Dim text As TextRange = title.AppendText("Field Types Supported by Spire.Doc")
			text.CharacterFormat.FontName = "Arial"
			text.CharacterFormat.FontSize = 20
			text.CharacterFormat.Bold = True
			title.Format.BeforeSpacing = section.PageSetup.PageSize.Height \ 2 - 3 * section.PageSetup.Margins.Top
			title.Format.AfterSpacing = 8
			title.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right

			paragraph = section.AddParagraph()
			paragraph.AppendText("e-iceblue Spire.Doc team.")
			paragraph.ApplyStyle(small.Name)
			paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right
		End Sub

		Private Sub InsertContent(ByVal section As Section)
			Dim list As New ParagraphStyle(section.Document)
			list.Name = "list"
			list.CharacterFormat.FontName = "Arial"
			list.CharacterFormat.FontSize = 11
			list.ParagraphFormat.LineSpacing = 1.5F * 12F
			list.ParagraphFormat.LineSpacingRule = LineSpacingRule.Multiple
			section.Document.Styles.Add(list)

			Dim title As Paragraph = section.AddParagraph()
			Dim text As TextRange = title.AppendText("Field type list:")
			title.ApplyStyle(list.Name)

            Dim first As Boolean = True

            For Each type As FieldType In System.Enum.GetValues(GetType(FieldType))
                If ((type = FieldType.FieldUnknown) OrElse (type = FieldType.FieldNone) OrElse (type = FieldType.FieldEmpty)) Then
                    Continue For
                End If
                Dim paragraph As Paragraph = section.AddParagraph()
                paragraph.AppendText(String.Format("{0} is supported in Spire.Doc", type))

                If first Then
                    paragraph.ListFormat.ApplyNumberedStyle()
                    first = False
                Else
                    paragraph.ListFormat.ContinueListNumbering()
                End If
                paragraph.ApplyStyle(list.Name)
            Next type
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
