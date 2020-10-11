Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace RemoveCustomPropertyFields
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\RemoveCustomPropertyFields.docx")

			'Get custom document properties object.
			Dim cdp As CustomDocumentProperties = document.CustomDocumentProperties

			'Remove all custom property fields in the document.
			Dim i As Integer = 0
			Do While i < cdp.Count
				cdp.Remove(cdp(i).Name)
			Loop

			document.IsUpdateFields = True

			Dim result As String = "Result-RemoveCustomPropertyFields.docx"

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
