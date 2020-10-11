Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace SetVerticalAlignment
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new Word document and add a new section
			Dim doc As New Document()
			Dim section As Section = doc.AddSection()

			'Add a table with 3 columns and 3 rows
			Dim table As Table = section.AddTable(True)
			table.ResetCells(3, 3)

			'Merge rows
			table.ApplyVerticalMerge(0, 0, 2)

			'Set the vertical alignment for each cell, default is top
			table.Rows(0).Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
			table.Rows(0).Cells(1).CellFormat.VerticalAlignment = VerticalAlignment.Top
			table.Rows(0).Cells(2).CellFormat.VerticalAlignment = VerticalAlignment.Top
			table.Rows(1).Cells(1).CellFormat.VerticalAlignment = VerticalAlignment.Middle
			table.Rows(1).Cells(2).CellFormat.VerticalAlignment = VerticalAlignment.Middle
			table.Rows(2).Cells(1).CellFormat.VerticalAlignment = VerticalAlignment.Bottom
			table.Rows(2).Cells(2).CellFormat.VerticalAlignment = VerticalAlignment.Bottom

			'Inset a picture into the table cell
			Dim paraPic As Paragraph = table.Rows(0).Cells(0).AddParagraph()
			Dim pic As DocPicture = paraPic.AppendPicture(Image.FromFile("..\..\..\..\..\..\Data\E-iceblue.png"))

			'Create data
			Dim data()() As String = { New String() {"","Spire.Office","Spire.DataExport"}, New String() {"","Spire.Doc","Spire.DocViewer"}, New String() {"","Spire.XLS","Spire.PDF"} }

			'Append data to table
			For r As Integer = 0 To 2
				Dim dataRow As TableRow = table.Rows(r)
				dataRow.Height = 50
				For c As Integer = 0 To 2
					If c = 1 Then
						Dim par As Paragraph = dataRow.Cells(c).AddParagraph()
						par.AppendText(data(r)(c))
						dataRow.Cells(c).Width = (section.PageSetup.ClientWidth) / 2
					End If
					If c = 2 Then
						Dim par As Paragraph = dataRow.Cells(c).AddParagraph()
						par.AppendText(data(r)(c))
						dataRow.Cells(c).Width = (section.PageSetup.ClientWidth) / 2
					End If
				Next c
			Next r

			'Save and launch document
			Dim output As String = "SetVerticalAlignment.docx"
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
