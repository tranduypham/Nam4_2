Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace ReplaceTextWithMergeField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\SampleB_2.docx")

			'Find the text that will be replaced
			Dim ts As TextSelection = document.FindString("Test",True, True)

			Dim tr As TextRange = ts.GetAsOneRange()

			'Get the paragraph
			Dim par As Paragraph = tr.OwnerParagraph

			'Get the index of the text in the paragraph
			Dim index As Integer = par.ChildObjects.IndexOf(tr)

			'Create a new field
			Dim field As New MergeField(document)
			field.FieldName = "MergeField"

			'Insert field at specific position
			par.ChildObjects.Insert(index, field)

			'Remove the text
			par.ChildObjects.Remove(tr)

			'Save to file
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
