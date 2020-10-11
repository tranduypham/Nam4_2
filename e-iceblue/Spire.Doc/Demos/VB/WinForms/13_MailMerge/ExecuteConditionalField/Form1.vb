Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO
Imports Spire.Doc.Fields
Imports System.Data.OleDb
Imports System.Linq
Imports Spire.Doc.Reporting
Imports System.Collections
Imports Spire.Doc.Interface
Namespace ExecuteConditionalField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim doc As New Document()
			'Add a new section 
			Dim section As Section = doc.AddSection()
			'Add a new paragraph for a section 
			Dim paragraph As Paragraph = section.AddParagraph()

			CreateIFField1(doc, paragraph)
			paragraph = section.AddParagraph()
			CreateIFField2(doc, paragraph)

			Dim fieldName() As String = { "Count","Age" }
			Dim fieldValue() As String = { "2","30" }

			doc.MailMerge.Execute(fieldName, fieldValue)
			doc.IsUpdateFields = True

			doc.SaveToFile("sample.docx", FileFormat.Docx)

			Dim result As String = "ExecuteConditionalField_out.docx"
			doc.SaveToFile(result, FileFormat.Docx)
			WordViewer(result)
		End Sub
		Private Sub CreateIFField1(ByVal document As Document, ByVal paragraph As Paragraph)
			Dim ifField As New IfField(document)
			ifField.Type = FieldType.FieldIf
			ifField.Code = "IF "
			paragraph.Items.Add(ifField)

			paragraph.AppendField("Count", FieldType.FieldMergeField)
			paragraph.AppendText(" > ")
			paragraph.AppendText("""1"" ")
			paragraph.AppendText("""Greater than one"" ")
			paragraph.AppendText("""Less than one""")

			Dim [end] As IParagraphBase = document.CreateParagraphItem(ParagraphItemType.FieldMark)
			TryCast([end], FieldMark).Type = FieldMarkType.FieldEnd
			paragraph.Items.Add([end])

			ifField.End = TryCast([end], FieldMark)
		End Sub

		Private Sub CreateIFField2(ByVal document As Document, ByVal paragraph As Paragraph)
			Dim ifField As New IfField(document)
			ifField.Type = FieldType.FieldIf
			ifField.Code = "IF "
			paragraph.Items.Add(ifField)

			paragraph.AppendField("Age", FieldType.FieldMergeField)
			paragraph.AppendText(" > ")
			paragraph.AppendText("""50"" ")
			paragraph.AppendText("""The old man"" ")
			paragraph.AppendText("""The young man""")

			Dim [end] As IParagraphBase = document.CreateParagraphItem(ParagraphItemType.FieldMark)
			TryCast([end], FieldMark).Type = FieldMarkType.FieldEnd
			paragraph.Items.Add([end])

			ifField.End = TryCast([end], FieldMark)
		End Sub
		Private Sub WordViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
