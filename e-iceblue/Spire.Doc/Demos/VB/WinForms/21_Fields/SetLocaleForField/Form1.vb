Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace SetLocaleForField
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

			'Add a date field
			Dim field As Field = par.AppendField("DocDate", FieldType.FieldDate)

			'Set the LocaleId for the textrange
			TryCast(field.OwnerParagraph.ChildObjects(0), TextRange).CharacterFormat.LocaleIdASCII = 1049

			field.FieldText = "2019-10-10"
			'Update field
			document.IsUpdateFields = True

			Dim result As String= "result.docx"
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
