Imports Spire.Doc
Imports Spire.Doc.Interface

Namespace ReplaceWithDocument
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

			'Load a template document 
			Dim doc As New Document("..\..\..\..\..\..\Data\Text2.docx")

			'Load another document to replace text
			Dim replaceDoc As IDocument = New Document("..\..\..\..\..\..\Data\Text1.docx")

			'Replace specified text with the other document
			doc.Replace("Document1", replaceDoc, False, True)

			'Save and launch document
			Dim output As String = "ReplaceWithDocument.docx"
			doc.SaveToFile(output, FileFormat.Docx)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
