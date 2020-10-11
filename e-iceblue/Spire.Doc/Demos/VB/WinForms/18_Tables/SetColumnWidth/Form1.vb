Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc

Namespace SetColumnWidth
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document and load file
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\TableSample.docx")

			Dim section As Section = document.Sections(0)
			Dim table As Table = TryCast(section.Tables(0), Table)

			'Traverse the first column
			For i As Integer = 0 To table.Rows.Count - 1
				'Set the cell width type
				table.Rows(i).Cells(0).CellWidthType = CellWidthType.Point
				'Set the value
				table.Rows(i).Cells(0).Width = 200
			Next i

			'Save to file
			document.SaveToFile("ColumnWidth.docx", FileFormat.Docx)
			'Launch the document
			FileViewer("ColumnWidth.docx")
		End Sub
		Private Sub FileViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
