Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports System.IO

Namespace SimpleInsertFile
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the Word document
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\..\Data\Template_N5.docx")

			'Insert document from file
			doc.InsertTextFromFile("..\..\..\..\..\..\..\Data\Template_N3.docx", FileFormat.Auto)

			'Save the document
			Dim output As String="SimpleInsertFile_out.docx"
			doc.SaveToFile(output,FileFormat.Docx2013)

			'Launch the document
			WordDocViewer(output)
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
