Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace InsertPageRefField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\PageRef.docx")

			'Get the first section
			Dim section As Section = document.LastSection

			Dim par As Paragraph = section.AddParagraph()

			'Add page ref field
			Dim field As Field = par.AppendField("pageRef", FieldType.FieldPageRef)

			'Set field code
			field.Code = "PAGEREF  bookmark1 \# ""0"" \* Arabic  \* MERGEFORMAT"

			'Update field
			document.IsUpdateFields = True

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
