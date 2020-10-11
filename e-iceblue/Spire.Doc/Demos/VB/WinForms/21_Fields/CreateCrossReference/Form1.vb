Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace CreateCrossReference
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

			'Create a bookmark.
			Dim paragraph As Paragraph = section.AddParagraph()
			paragraph.AppendBookmarkStart("MyBookmark")
			paragraph.AppendText("Text inside a bookmark")
			paragraph.AppendBookmarkEnd("MyBookmark")

			'Insert line breaks.
			For i As Integer = 0 To 3
				paragraph.AppendBreak(BreakType.LineBreak)
			Next i

			'Create a cross-reference field, and link it to bookmark.                    
			Dim field As New Field(document)
			field.Type = FieldType.FieldRef
			field.Code = "REF MyBookmark \p \h"

			'Insert field to paragraph.
			paragraph = section.AddParagraph()
			paragraph.AppendText("For more information, see ")
			paragraph.ChildObjects.Add(field)

			'Insert FieldSeparator object.
			Dim fieldSeparator As New FieldMark(document, FieldMarkType.FieldSeparator)
			paragraph.ChildObjects.Add(fieldSeparator)

			'Set display text of the field.
			Dim tr As New TextRange(document)
			tr.Text = "above"
			paragraph.ChildObjects.Add(tr)

			'Insert FieldEnd object to mark the end of the field.
			Dim fieldEnd As New FieldMark(document, FieldMarkType.FieldEnd)
			paragraph.ChildObjects.Add(fieldEnd)

			Dim result As String = "Result-CreateCrossReferenceToBookmark.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

			'Launch the MS Word file.
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
