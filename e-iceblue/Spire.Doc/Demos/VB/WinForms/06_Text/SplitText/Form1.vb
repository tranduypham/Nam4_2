Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SplitText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new document and load from file
			Dim input As String = "..\..\..\..\..\..\Data\Sample.docx"

			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Add a column to the first section and set width and spacing
			doc.Sections(0).AddColumn(100f, 20f)
			'Add a line between the two columns
			doc.Sections(0).PageSetup.ColumnsLineBetween = True

			'Save and launch the document
			Dim output As String = "SplitText.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)
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
