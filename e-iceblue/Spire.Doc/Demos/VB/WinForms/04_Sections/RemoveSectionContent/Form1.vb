Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace RemoveSectionContent
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Word file from disk
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\Template_N3.docx")

			'Loop through all sections
			For Each section As Section In doc.Sections
				'Remove header content
				section.HeadersFooters.Header.ChildObjects.Clear()
				'Remove body content
				section.Body.ChildObjects.Clear()
				'Remove footer content
				section.HeadersFooters.Footer.ChildObjects.Clear()
			Next section

			'Save the Word file
			Dim output As String="RemoveSectionContent_out.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)

			'Launch the file
			FileViewer(output)
		End Sub
		Private Sub FileViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
