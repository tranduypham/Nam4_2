Imports Spire.Doc

Namespace RemoveTextBox
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\TextBoxTemplate.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Remove the first text box
			doc.TextBoxes.RemoveAt(0)

			'Clear all the text boxes
			'Doc.TextBoxes.Clear();

			'Save and launch document
			Dim output As String = "RemoveTextBox.docx"
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
