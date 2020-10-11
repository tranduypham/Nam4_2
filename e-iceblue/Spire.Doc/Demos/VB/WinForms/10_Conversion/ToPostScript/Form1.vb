Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc

Namespace ToPostScript
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\ConvertedTemplate.docx")
			Dim result As String = "ToPostScript.ps"
			doc.SaveToFile(result, FileFormat.PostScript)
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
