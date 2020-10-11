Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace DetectAndRemoveVBAMacros
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\DetectAndRemoveVBAMacros.docm")

			'If the document contains Macros, remove them from the document.
			If document.IsContainMacro Then
				document.ClearMacros()
			End If

			Dim result As String = "Result-DetectAndRemoveVBAMacros.docm"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docm)

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
