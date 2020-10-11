Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace AddAndDeleteSections
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\SectionTemplate.docx")

			AddSection(doc)
			DeleteSection(doc)

			Dim output As String="AddAndDeleteSections_out.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)

			FileViewer(output)
		End Sub
		Private Sub AddSection(ByVal doc As Document)
			'Add a section
			doc.AddSection()
		End Sub
		Private Sub DeleteSection(ByVal doc As Document)
			'Delete the last section
			doc.Sections.RemoveAt(doc.Sections.Count - 1)
		End Sub
		Private Sub FileViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
