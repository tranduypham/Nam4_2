Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace CloneSection
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load source file
			Dim srcDoc As New Document()
			srcDoc.LoadFromFile("..\..\..\..\..\..\Data\SectionTemplate.docx")

			'Create destination file
			Dim desDoc As New Document()

			Dim cloneSection As Section=Nothing
			For Each section As Section In srcDoc.Sections
				'Clone section
				cloneSection = section.Clone()
				'Add the cloneSection in destination file
				desDoc.Sections.Add(cloneSection)
			Next section

			'Save the Word
			Dim output As String="CloneSection_out.docx"
			desDoc.SaveToFile(output, FileFormat.Docx2013)

			'Launch Word file
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