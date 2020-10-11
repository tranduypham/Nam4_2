Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc

Namespace ToPCL
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\ConvertedTemplate.docx")
			Dim result As String="ToPCL.pcl"
			doc.SaveToFile(result, FileFormat.PCL)
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
