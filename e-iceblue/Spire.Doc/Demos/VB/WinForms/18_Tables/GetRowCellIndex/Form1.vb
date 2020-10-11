Imports Spire.Doc
Imports System.Text
Imports System.IO

Namespace GetRowCellIndex
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Word from disk
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\ReplaceTextInTable.docx")

			'Get the first section
			Dim section As Section = doc.Sections(0)

			'Get the first table in the section
			Dim table As Table = TryCast(section.Tables(0), Table)

			Dim content As New StringBuilder()

			'Get table collections
			Dim collections As Spire.Doc.Collections.TableCollection = section.Tables

			'Get the table index
			Dim tableIndex As Integer = collections.IndexOf(table)

			'Get the index of the last table row
			Dim row As TableRow = table.LastRow
			Dim rowIndex As Integer = row.GetRowIndex()

			'Get the index of the last table cell
			Dim cell As TableCell = TryCast(row.LastChild, TableCell)
			Dim cellIndex As Integer = cell.GetCellIndex()

			'Append these information into content
			content.AppendLine("Table index is " & tableIndex.ToString())
			content.AppendLine("Row index is " & rowIndex.ToString())
			content.AppendLine("Cell index is " & cellIndex.ToString())

			'Save to txt file
			Dim output As String = "GetRowCellIndex_out.txt"
			File.WriteAllText(output, content.ToString())

			'Launch the file
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
