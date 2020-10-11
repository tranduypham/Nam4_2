Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace CreateVerticalTable
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Add a new section.
			Dim section As Section = document.AddSection()

			'Add a table with rows and columns and set the text for the table.
			Dim table As Table = section.AddTable()
			table.ResetCells(1, 1)
			Dim cell As TableCell = table.Rows(0).Cells(0)
			table.Rows(0).Height = 150
			cell.AddParagraph().AppendText("Draft copy in vertical style")

			'Set the TextDirection for the table to RightToLeftRotated.
			cell.CellFormat.TextDirection = TextDirection.RightToLeftRotated

			'Set the table format.
			table.TableFormat.WrapTextAround = True
			table.TableFormat.Positioning.VertRelationTo = VerticalRelation.Page
			table.TableFormat.Positioning.HorizRelationTo = HorizontalRelation.Page
			table.TableFormat.Positioning.HorizPosition = section.PageSetup.PageSize.Width - table.Width
			table.TableFormat.Positioning.VertPosition = 200

			Dim result As String = "Result-CreateVerticalTable.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

			'Launch the MS Word file.
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
