Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports System.IO

Namespace GetText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document from disk.
			Dim document As New Document("..\..\..\..\..\..\Data\ExtractText.docx")

			'get text from document
			Dim text As String = document.GetText()

			'create a new TXT File to save extracted text
			File.WriteAllText("Extract.txt", text)

			'launch the file.
			WordDocViewer("Extract.txt")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
