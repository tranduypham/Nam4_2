Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace SetCultureForField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()

			'Create a section
			Dim section As Section = document.AddSection()

			'Add paragraph
			Dim paragraph As Paragraph = section.AddParagraph()

			'Add textRnage for paragraph
			paragraph.AppendText("Add Date Field: ")

			'Add date field1
			Dim field1 As Field = TryCast(paragraph.AppendField("Date1", FieldType.FieldDate), Field)
			field1.Code = "DATE  \@" & """yyyy\MM\dd"""

			'Add new paragraph
			Dim newParagraph As Paragraph = section.AddParagraph()

			'Add textRnage for paragraph
			newParagraph.AppendText("Add Date Field with setting French Culture: ")

			'Add date field2
			Dim field2 As Field = newParagraph.AppendField("""\@""dd MMMM yyyy", FieldType.FieldDate)

			'Setting Field with setting French Culture
			field2.CharacterFormat.LocaleIdASCII = 1036

			'Update fields
			document.IsUpdateFields = True

			'Save the document.
			document.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
