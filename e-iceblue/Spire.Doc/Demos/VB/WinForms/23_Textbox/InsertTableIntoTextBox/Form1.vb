Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertTableIntoTextBox
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new document
			Dim doc As New Document()

			'Add a section
			Dim section As Section = doc.AddSection()

			'Add a paragraph to the section
			Dim paragraph As Paragraph = section.AddParagraph()

			'Add a textbox to the paragraph
			Dim textbox As Spire.Doc.Fields.TextBox = paragraph.AppendTextBox(300, 100)

			'Set the position of the textbox
			textbox.Format.HorizontalOrigin = HorizontalOrigin.Page
			textbox.Format.HorizontalPosition = 140
			textbox.Format.VerticalOrigin = VerticalOrigin.Page
			textbox.Format.VerticalPosition = 50

			'Add text to the textbox
			Dim textboxParagraph As Paragraph = textbox.Body.AddParagraph()
			Dim textboxRange As TextRange = textboxParagraph.AppendText("Table 1")
			textboxRange.CharacterFormat.FontName = "Arial"

			'Insert table to the textbox
			Dim table As Table = textbox.Body.AddTable(True)

			'Specify the number of rows and columns of the table
			table.ResetCells(4, 4)

			Dim data(,) As String = { {"Name","Age","Gender","ID" }, {"John","28","Male","0023" }, {"Steve","30","Male","0024" }, {"Lucy","26","female","0025" } }

			'Add data to the table 
			For i As Integer = 0 To 3
				For j As Integer = 0 To 3
					Dim tableRange As TextRange = table(i, j).AddParagraph().AppendText(data(i, j))
					tableRange.CharacterFormat.FontName = "Arial"
				Next j
			Next i

			'Apply style to the table
			table.ApplyStyle(DefaultTableStyle.TableColorful2)

			'Save and launch document
			Dim output As String = "InsertTableIntoTextBox.docx"
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
