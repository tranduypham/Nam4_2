Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.Drawing.Printing

Namespace CallPreviewControl
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\Sample.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the PrintDocument object
			Dim printDoc As PrintDocument = doc.PrintDocument

			'Call print preview dialog
			Dim printPreviewDialog As New PrintPreviewDialog()
			printPreviewDialog.Document = doc.PrintDocument

			'Set the preview dialog size of client area
			printPreviewDialog.ClientSize = New Size(600, 800)
			printPreviewDialog.ShowDialog()
		End Sub
	End Class
End Namespace
