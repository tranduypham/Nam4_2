Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ReplaceTextInTable
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Word from disk
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\ReplaceTextInTable.docx")

			'Get the first section
			Dim section As Section = doc.Sections(0)

			'Get the first table in the section
			Dim table As Table = TryCast(section.Tables(0), Table)

			'Define a regular expression to match the {} with its content
			Dim regex As New System.Text.RegularExpressions.Regex("{[^\}]+\}")

			'Replace the text of table with regex
			table.Replace(regex, "E-iceblue")

			'Replace old text with new text in table
			table.Replace("Beijing", "Component", False, True)

			'Save the Word document
			Dim output As String="ReplaceTextInTable_out.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)

			'Launch the file
			WordDocViewer(output)
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
