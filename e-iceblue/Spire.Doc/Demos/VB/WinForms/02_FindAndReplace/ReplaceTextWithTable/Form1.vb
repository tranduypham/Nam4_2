Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ReplaceTextWithTable
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_1.docx")

			'Return TextSection by finding the key text string "Christmas Day, December 25".
			Dim section As Section = document.Sections(0)
			Dim selection As TextSelection = document.FindString("Christmas Day, December 25", True, True)

			'Return TextRange from TextSection, then get OwnerParagraph through TextRange.
			Dim range As TextRange = selection.GetAsOneRange()
			Dim paragraph As Paragraph = range.OwnerParagraph

			'Return the zero-based index of the specified paragraph.
			Dim body As Body = paragraph.OwnerTextBody
			Dim index As Integer = body.ChildObjects.IndexOf(paragraph)

			'Create a new table.
			Dim table As Table = section.AddTable(True)
			table.ResetCells(3, 3)

			'Remove the paragraph and insert table into the collection at the specified index.
			body.ChildObjects.Remove(paragraph)
			body.ChildObjects.Insert(index, table)

			Dim result As String = "Result-ReplaceTextWithTable.docx"

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
