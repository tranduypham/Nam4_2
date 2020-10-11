Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace InsertMergeField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\SampleB_2.docx")

			'Get the first section
			Dim section As Section = document.Sections(0)

			Dim par As Paragraph = section.AddParagraph()

			'Add merge field in the paragraph
			Dim field As MergeField = TryCast(par.AppendField("MyFieldName", FieldType.FieldMergeField), MergeField)

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
