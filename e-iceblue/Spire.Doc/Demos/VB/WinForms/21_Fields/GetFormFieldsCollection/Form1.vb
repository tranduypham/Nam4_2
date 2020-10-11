Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace GetFormFieldsCollection
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

			Dim formFields As FormFieldCollection = section.Body.FormFields

			sb.Append("The first section has " & formFields.Count & " form fields.")

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
