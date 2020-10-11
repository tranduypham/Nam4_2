Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Interface

Namespace CreateIFField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Add a new section.
			Dim section As Section = document.AddSection()

			'Add a new paragraph.
			Dim paragraph As Paragraph = section.AddParagraph()

			' Define a method of creating an IF Field.
			CreateIfField(document, paragraph)

			'Define merged data.
			Dim fieldName() As String = { "Count" }
			Dim fieldValue() As String = { "2" }

			'Merge data into the IF Field.
			document.MailMerge.Execute(fieldName, fieldValue)

			'Update all fields in the document.
			document.IsUpdateFields = True

			Dim result As String = "Result-CreateAnIFField.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

			'Launch the file.
			WordDocViewer(result)
		End Sub

		'Create the IF Field like:{IF { MERGEFIELD Count } > "100" "Thanks" " The minimum order is 100 units "}
		Private Shared Sub CreateIfField(ByVal document As Document, ByVal paragraph As Paragraph)
			Dim ifField As New IfField(document)
			ifField.Type = FieldType.FieldIf
			ifField.Code = "IF "

			paragraph.Items.Add(ifField)
			paragraph.AppendField("Count", FieldType.FieldMergeField)
			paragraph.AppendText(" > ")
			paragraph.AppendText("""100"" ")
			paragraph.AppendText("""Thanks"" ")
			paragraph.AppendText("""The minimum order is 100 units""")

			Dim [end] As IParagraphBase = document.CreateParagraphItem(ParagraphItemType.FieldMark)
			TryCast([end], FieldMark).Type = FieldMarkType.FieldEnd
			paragraph.Items.Add([end])
			ifField.End = TryCast([end], FieldMark)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
