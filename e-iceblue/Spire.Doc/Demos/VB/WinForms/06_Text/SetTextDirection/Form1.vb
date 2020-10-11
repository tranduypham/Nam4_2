Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SetTextDirection
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new document
			Dim doc As New Document()

			'Add the first section
			Dim section1 As Section = doc.AddSection()
			'Set text direction for all text in a section
			section1.TextDirection = TextDirection.RightToLeft

			'Set Font Style and Size
			Dim style As New ParagraphStyle(doc)
			style.Name = "FontStyle"
			style.CharacterFormat.FontName = "Arial"
			style.CharacterFormat.FontSize = 15
			doc.Styles.Add(style)

			'Add two paragraphs and apply the font style
			Dim p As Paragraph = section1.AddParagraph()
			p.AppendText("Only Spire.Doc, no Microsoft Office automation")
			p.ApplyStyle(style.Name)
			p = section1.AddParagraph()
			p.AppendText("Convert file documents with high quality")
			p.ApplyStyle(style.Name)

			'Set text direction for a part of text
			'Add the second section
			Dim section2 As Section = doc.AddSection()
			'Add a table
			Dim table As Table = section2.AddTable()
			table.ResetCells(1, 1)
			Dim cell As TableCell = table.Rows(0).Cells(0)
			table.Rows(0).Height = 150
			table.Rows(0).Cells(0).Width = 10
			'Set vertical text direction of table
			cell.CellFormat.TextDirection = TextDirection.RightToLeftRotated
			cell.AddParagraph().AppendText("This is vertical style")
			'Add a paragraph and set horizontal text direction
			p = section2.AddParagraph()
			p.AppendText("This is horizontal style")
			p.ApplyStyle(style.Name)

			'Save and launch document
			Dim output As String = "SetTextDirection.docx"
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
