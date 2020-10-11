Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace InsertAddressBlockField
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

			'Add address block in the paragraph
			Dim field As Field = par.AppendField("ADDRESSBLOCK", FieldType.FieldAddressBlock)

			'Set field code
			field.Code = "ADDRESSBLOCK \c 1 \d \e Test2 \f Test3 \l ""Test 4"""

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
