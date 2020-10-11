Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO
Imports Spire.Doc.Fields
Namespace LoadAndSaveToDisk
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim input As String = "..\..\..\..\..\..\Data\Template.docx"
			'Create a new document
			Dim doc As New Document()
			' Load the document from the absolute/relative path on disk.
			doc.LoadFromFile(input)

			Dim result As String = "LoadAndSaveToDisk_out.docx"
			' Save the document to disk
			doc.SaveToFile(result,FileFormat.Docx)
			WordViewer(result)
		End Sub
		Private Sub WordViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
