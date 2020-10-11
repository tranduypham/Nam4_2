Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace AddOrDeleteRow
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()
			'Load file
			document.LoadFromFile("..\..\..\..\..\..\Data\TableSample.docx")
			Dim section As Section = document.Sections(0)
			Dim table As Table = TryCast(section.Tables(0), Table)

			'Delete the seventh row
			table.Rows.RemoveAt(7)

			'Add a row and insert it into specific position
			Dim row As New TableRow(document)
			For i As Integer = 0 To table.Rows(0).Cells.Count - 1
				Dim tc As TableCell = row.AddCell()
				Dim paragraph As Paragraph = tc.AddParagraph()
				paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
				paragraph.AppendText("Added")
			Next i
			table.Rows.Insert(2,row)
			'Add a row at the end of table
			table.AddRow()

			'Save to file and launch it
			document.SaveToFile("AddDeleteRow.docx", FileFormat.Docx)
			FileViewer("AddDeleteRow.docx")
		End Sub
		Private Sub FileViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
