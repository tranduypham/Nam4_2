Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace InsertAdvanceField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document.
			Dim document As New Document("..\..\..\..\..\..\Data\SampleB_2.docx")

			'Get the first section
			Dim section As Section = document.Sections(0)

			Dim par As Paragraph = section.AddParagraph()

			'Add advance field
			Dim field As Field = par.AppendField("Field", FieldType.FieldAdvance)

			'Add field code
			field.Code = "ADVANCE \d 10 \l 10 \r 10 \u 0 \x 100 \y 100 "

			'Update field
			document.IsUpdateFields = True

			Dim result As String="result.docx"
			document.SaveToFile(result, FileFormat.Docx)
			'Launch result file
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
