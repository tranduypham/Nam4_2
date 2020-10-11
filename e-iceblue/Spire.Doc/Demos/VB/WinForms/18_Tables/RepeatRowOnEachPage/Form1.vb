Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace RepeatRowOnEachPage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create word document
			Dim document As New Document()

			'Create a new section
			Dim section As Section = document.AddSection()

			'Create a table width default borders
			Dim table As Table = section.AddTable(True)
			'Set table with to 100%
			Dim width As New PreferredWidth(WidthType.Percentage, 100)
			table.PreferredWidth = width

			'Add a new row 
			Dim row As TableRow = table.AddRow()
			'Set the row as a table header 
			row.IsHeader = True
			'Set the backcolor of row
			row.RowFormat.BackColor = Color.LightGray
			'Add a new cell for row
			Dim cell As TableCell = row.AddCell()
			cell.SetCellWidth(100, CellWidthType.Percentage)
			'Add a paragraph for cell to put some data
			Dim parapraph As Paragraph = cell.AddParagraph()
			'Add text 
			parapraph.AppendText("Row Header 1")
			'Set paragraph horizontal center alignment
			parapraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center

			row = table.AddRow(False, 1)
			row.IsHeader = True
			row.RowFormat.BackColor = Color.Ivory
			'Set row height
			row.Height = 30
			cell = row.Cells(0)
			cell.SetCellWidth(100, CellWidthType.Percentage)
			'Set cell vertical middle alignment
			cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle
			'Add a paragraph for cell to put some data
			parapraph = cell.AddParagraph()
			'Add text 
			parapraph.AppendText("Row Header 2")
			parapraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center

			'Add many common rows 
			For i As Integer = 0 To 69
				row = table.AddRow(False,2)
				cell = row.Cells(0)
				'Set cell width to 50% of table width
				cell.SetCellWidth(50, CellWidthType.Percentage)
				cell.AddParagraph().AppendText("Column 1 Text")
				cell = row.Cells(1)
				cell.SetCellWidth(50, CellWidthType.Percentage)
				cell.AddParagraph().AppendText("Column 2 Text")
			Next i
			'Set cell backcolor
			For j As Integer = 1 To table.Rows.Count - 1
				If j Mod 2 = 0 Then
					Dim row2 As TableRow = table.Rows(j)
					For f As Integer = 0 To row2.Cells.Count - 1
						row2.Cells(f).CellFormat.BackColor = Color.LightBlue
					Next f
				End If

			Next j

			Dim result As String = "RepeatRowOnEachPage_out.docx"

			'Save file.
			document.SaveToFile(result,FileFormat.Docx)

			'Launching the Word file.
			WordDocViewer(result)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
