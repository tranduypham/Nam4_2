Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace ReadTableFromTextBox
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\TextBoxTable.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the first textbox
			Dim textbox As Spire.Doc.Fields.TextBox = doc.TextBoxes(0)

			'Get the first table in the textbox
			Dim table As Table = TryCast(textbox.Body.Tables(0), Table)

			Dim str As String = Nothing

			'Loop through the paragraphs of the table cells and extract them to a .txt file
			For Each row As TableRow In table.Rows
				For Each cell As TableCell In row.Cells
					For Each paragraph As Paragraph In cell.Paragraphs
						str &= paragraph.Text & vbTab
					Next paragraph
				Next cell
				str &= vbCrLf
			Next row

			'Save to TXT file and launch it
			Dim output As String = "ReadTableFromTextBox.txt"
			File.WriteAllText(output, str)
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
