Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace CreateTableDirectly
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a Word document
			Dim doc As New Document()

			'Add a section
			Dim section As Section = doc.AddSection()

			'Create a table 
			Dim table As New Table(doc)
			'Set the width of table
			table.PreferredWidth = New PreferredWidth(WidthType.Percentage, CShort(100))
			'Set the border of table
			table.TableFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single

			'Create a table row
			Dim row As New TableRow(doc)
			row.Height = 50.0f
			table.Rows.Add(row)

			'Create a table cell
			Dim cell1 As New TableCell(doc)
			'Add a paragraph
			Dim para1 As Paragraph = cell1.AddParagraph()
			'Append text in the paragraph
			para1.AppendText("Row 1, Cell 1")
			'Set the horizontal alignment of paragrah
			para1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			'Set the background color of cell
			cell1.CellFormat.BackColor = Color.CadetBlue
			'Set the vertical alignment of paragraph
			cell1.CellFormat.VerticalAlignment = VerticalAlignment.Middle
			row.Cells.Add(cell1)

			'Create a table cell
			Dim cell2 As New TableCell(doc)
			Dim para2 As Paragraph = cell2.AddParagraph()
			para2.AppendText("Row 1, Cell 2")
			para2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			cell2.CellFormat.BackColor = Color.CadetBlue
			cell2.CellFormat.VerticalAlignment = VerticalAlignment.Middle
			row.Cells.Add(cell2)

			'Add the table in the section
			section.Tables.Add(table)

			'Save the document
			Dim output As String = "CreateTableDirectly_out.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)

			'Launch the document
			WordDocViewer(output)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
