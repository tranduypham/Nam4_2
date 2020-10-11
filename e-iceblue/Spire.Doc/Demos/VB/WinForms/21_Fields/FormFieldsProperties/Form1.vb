Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace FormFieldsProperties
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\FillFormField.doc")

			'Get the first section
			Dim section As Section = document.Sections(0)

			'Get FormField by index
			Dim formField As FormField = section.Body.FormFields(1)

			If formField.Type = FieldType.FieldFormTextInput Then
				formField.Text = "My name is " & formField.Name
				formField.CharacterFormat.TextColor = Color.Red
				formField.CharacterFormat.Italic = True
			End If


			document.SaveToFile("result.docx", FileFormat.Docx)
			'Launch result file
			WordDocViewer("result.docx")

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
