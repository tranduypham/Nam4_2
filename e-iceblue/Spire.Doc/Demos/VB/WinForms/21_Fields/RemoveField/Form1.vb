Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections

Namespace RemoveField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\IfFieldSample.docx")

			'Get the first field
			Dim field As Field = document.Fields(0)

			'Get the paragraph of the field
			Dim par As Paragraph = field.OwnerParagraph
			'Get the index of the  field
			Dim index As Integer = par.ChildObjects.IndexOf(field)
			'Remove if field via index
			par.ChildObjects.RemoveAt(index)

			'Save doc file
			document.SaveToFile("result.docx",FileFormat.Docx)

			'Launch the Word file
			WordDocViewer("result.docx")

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
