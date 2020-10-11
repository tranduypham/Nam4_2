Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SetDocumentProperties
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()

			'Load the document from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Sample.docx")

			'Set the build-in Properties.
			document.BuiltinDocumentProperties.Title = "Document Demo Document"
			document.BuiltinDocumentProperties.Author = "James"
			document.BuiltinDocumentProperties.Company = "e-iceblue"
			document.BuiltinDocumentProperties.Keywords = "Document, Property, Demo"
			document.BuiltinDocumentProperties.Comments = "This document is just a demo."

			'Set the custom properties.
			Dim custom As CustomDocumentProperties = document.CustomDocumentProperties
			custom.Add("e-iceblue", True)
			custom.Add("Authorized By", "John Smith")
			custom.Add("Authorized Date", Date.Today)

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
