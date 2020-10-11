Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace DownloadWordFromURL
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Initialize a new instance of WebClient class.
			Dim webClient As New WebClient()

			'Download a Word document from URL.
			Using ms As New MemoryStream(webClient.DownloadData("http://www.e-iceblue.com/images/test.docx"))
				document.LoadFromStream(ms, FileFormat.Docx)
			End Using

			Dim result As String = "Result-DownloadWordFileFromURL.docx"

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
