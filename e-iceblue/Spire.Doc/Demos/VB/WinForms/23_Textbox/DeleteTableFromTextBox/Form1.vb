Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace DeleteTableFromTextBox
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

			'Remove the first table from the textbox
			textbox.Body.Tables.RemoveAt(0)

			'Save and launch document
			Dim output As String = "DeleteTableFromTextBox.docx"
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
