Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace Indent
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Initialize a document
			Dim document As New Document()
			Dim sec As Section = document.AddSection()
			Dim para As Paragraph = sec.AddParagraph()
			para.AppendText("Paragraph Formatting")
			para.ApplyStyle(BuiltinStyle.Title)

			para = sec.AddParagraph()
			para.AppendText("This paragraph is surrounded with borders.")
			para.Format.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single
			para.Format.Borders.Color = Color.Red

			para = sec.AddParagraph()
			para.AppendText("The alignment of this paragraph is Left.")
			para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left

			para = sec.AddParagraph()
			para.AppendText("The alignment of this paragraph is Center.")
			para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center

			para = sec.AddParagraph()
			para.AppendText("The alignment of this paragraph is Right.")
			para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right

			para = sec.AddParagraph()
			para.AppendText("The alignment of this paragraph is justified.")
			para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify

			para = sec.AddParagraph()
			para.AppendText("The alignment of this paragraph is distributed.")
			para.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Distribute

			para = sec.AddParagraph()
			para.AppendText("This paragraph has the gray shadow.")
			para.Format.BackColor = Color.Gray

			para = sec.AddParagraph()
			para.AppendText("This paragraph has the following indentations: Left indentation is 10pt, right indentation is 10pt, first line indentation is 15pt.")
			para.Format.SetLeftIndent(10)
			para.Format.SetRightIndent(10)
			para.Format.SetFirstLineIndent(15)

			para = sec.AddParagraph()
			para.AppendText("The hanging indentation of this paragraph is 15pt.")
			'Negative value represents hanging indentation
			para.Format.SetFirstLineIndent(-15)

			para = sec.AddParagraph()
			para.AppendText("This paragraph has the following spacing: spacing before is 10pt, spacing after is 20pt, line spacing is at least 10pt.")
			para.Format.AfterSpacing = 20
			para.Format.BeforeSpacing = 10
			para.Format.LineSpacingRule = LineSpacingRule.AtLeast
			para.Format.LineSpacing = 10

			'Save as docx file.
			Dim filePath As String = "ParagraphFormatting.docx"
			document.SaveToFile(filePath, FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer(filePath)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
