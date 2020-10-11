Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace DocumentProperty
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a blank Word document as template.
			Dim document As New Document("..\..\..\..\..\..\Data\Summary_of_Science.doc")

			document.BuiltinDocumentProperties.Title = "Document Demo Document"
			document.BuiltinDocumentProperties.Subject = "demo"
			document.BuiltinDocumentProperties.Author = "James"
			document.BuiltinDocumentProperties.Company = "e-iceblue"
			document.BuiltinDocumentProperties.Manager = "Jakson"
			document.BuiltinDocumentProperties.Category = "Doc Demos"
			document.BuiltinDocumentProperties.Keywords = "Document, Property, Demo"
			document.BuiltinDocumentProperties.Comments = "This document is just a demo."

			'Save as docx file.
			document.SaveToFile("Sample.docx",FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer("Sample.docx")


		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
