Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace GetFormFieldByName
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim sb As New StringBuilder()

			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\FillFormField.doc")

			'Get the first section
			Dim section As Section = document.Sections(0)

			'Get form field by name
			Dim formField As FormField = section.Body.FormFields("email")

			sb.AppendLine("The name of the form field is " & formField.Name)
			sb.AppendLine("The type of the form field is " & formField.FormFieldType)

			File.WriteAllText("result.txt", sb.ToString())

			'Launch result file
			WordDocViewer("result.txt")

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
