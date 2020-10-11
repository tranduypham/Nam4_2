Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO

Namespace RetrieveVariables
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

			'Retrieve name of the variable by index.
			Dim s1 As String = document.Variables.GetNameByIndex(0)

			'Retrieve value of the variable by index.
			Dim s2 As String = document.Variables.GetValueByIndex(0)

			'Retrieve the value of the variable by name.
			Dim s3 As String = document.Variables("A1")

			Dim content As New StringBuilder()
			content.AppendLine("The name of the variable retrieved by index 0 is: " & s1)
			content.AppendLine("The vaule of the variable retrieved by index 0 is: " & s2)
			content.AppendLine("The vaule of the variable retrieved by name ""A1"" is: " & s3)

			Dim result As String = "Result-RetrieveVariables.txt"

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
