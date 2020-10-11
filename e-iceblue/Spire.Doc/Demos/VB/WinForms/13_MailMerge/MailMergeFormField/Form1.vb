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
Namespace MailMergeFormField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

			Dim input As String = "..\..\..\..\..\..\Data\MailMergeFormField.doc"
			'Create word document
			Dim document As New Document()
			document.LoadFromFile(input)

			Dim fieldNames() As String = { "Contact Name", "Fax", "Date", "Urgent", "Share", "Submit","Body" }

			Dim fieldValues() As String = { "John Smith", "+1 (69) 123456", Date.Now.Date.ToString(), "Yes","No","Yes", "<b>It's very urgent. Please deal with it ASAP. </b>" }

			AddHandler document.MailMerge.MergeField, AddressOf MailMerge_MergeField
			document.MailMerge.Execute(fieldNames, fieldValues)
			Dim result As String = "MailMergeFormField_out.docx"
			document.SaveToFile(result, FileFormat.Docx)
			WordViewer(result)
		End Sub

		Private Sub MailMerge_MergeField(ByVal sender As Object, ByVal args As MergeFieldEventArgs)
			If args.FieldValue = "Yes" Then
				'Create a checkbox name
			   Dim checkBoxName As String = args.FieldName
			   Dim para As Paragraph = args.CurrentMergeField.OwnerParagraph
			   Dim index As Integer = para.ChildObjects.IndexOf(args.CurrentMergeField)
				' Insert a check box.
			   Dim field As CheckBoxFormField = TryCast(para.AppendField(checkBoxName, FieldType.FieldFormCheckBox), CheckBoxFormField)
			   para.ChildObjects.Insert(index, field)
			   para.ChildObjects.Remove(args.CurrentMergeField)
			   field.Checked = True

			End If
			If args.FieldValue = "No" Then
				'Create a checkbox name
				Dim checkBoxName As String = args.FieldName
				Dim para As Paragraph = args.CurrentMergeField.OwnerParagraph
				Dim index As Integer = para.ChildObjects.IndexOf(args.CurrentMergeField)
				' Insert a check box.
				Dim field As CheckBoxFormField = TryCast(para.AppendField(checkBoxName, FieldType.FieldFormCheckBox), CheckBoxFormField)
				para.ChildObjects.Insert(index, field)
				para.ChildObjects.Remove(args.CurrentMergeField)
				field.Checked = False
			End If
			' Insert html during mail merge.
			If args.FieldName = "Body" Then
				Dim para As Paragraph = args.CurrentMergeField.OwnerParagraph
				para.AppendHTML(args.FieldValue.ToString())
				para.ChildObjects.Remove(args.CurrentMergeField)
			End If

			' Insert text input form field.
			If args.FieldName = "Date" Then
				Dim textInputName As String = args.FieldName
				Dim para As Paragraph = args.CurrentMergeField.OwnerParagraph
				Dim field As TextFormField = TryCast(para.AppendField(textInputName, FieldType.FieldFormTextInput), TextFormField)
				para.ChildObjects.Remove(args.CurrentMergeField)
				field.Text = args.FieldValue.ToString()
			End If
		End Sub

		Private Sub WordViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
