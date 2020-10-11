Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace PreventPageBreakInTable
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_5.docx")

			'Get the table from Word document.
			Dim table As Table = TryCast(document.Sections(0).Tables(0), Table)

			'Change the paragraph setting to keep them together.
			For Each row As TableRow In table.Rows
				For Each cell As TableCell In row.Cells
					For Each p As Paragraph In cell.Paragraphs
						p.Format.KeepFollow = True
					Next p
				Next cell
			Next row
			Dim result As String = "Result-PreventPageBreaksInWordTable.docx"

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
