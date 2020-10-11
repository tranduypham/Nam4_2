Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO

Namespace CountVariables
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\..\Data\Template_Docx_6.docx")

			'Get the number of variables in the document.
			Dim number As Integer = document.Variables.Count

			Dim content As New StringBuilder()
			content.AppendLine("The number of variables is: " & number.ToString())

			Dim result As String = "Result-CountVariables.txt"

			'Save to file.
			File.WriteAllText(result,content.ToString())

			'Launch the file.
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
