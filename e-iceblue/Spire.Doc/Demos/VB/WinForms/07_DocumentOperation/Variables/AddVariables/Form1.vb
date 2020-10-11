Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace AddVariables
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Add a section.
			Dim section As Section = document.AddSection()

			'Add a paragraph.
			Dim paragraph As Paragraph = section.AddParagraph()

			'Add a DocVariable field.
			paragraph.AppendField("A1", FieldType.FieldDocVariable)

			'Add a document variable to the DocVariable field.
			document.Variables.Add("A1", "12")

			'Update fields.
			document.IsUpdateFields = True

			Dim result As String = "Result-AddVariables.docx"

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
