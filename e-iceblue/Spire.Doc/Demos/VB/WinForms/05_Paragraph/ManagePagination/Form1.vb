Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace ManagePagination
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

			'Get the first section and the paragraph we want to manage the pagination.
			Dim sec As Section = document.Sections(0)
			Dim para As Paragraph = sec.Paragraphs(4)

			'Set the pagination format as Format.PageBreakBefore for the checked paragraph.
			para.Format.PageBreakBefore = True

			Dim result As String = "Result-ManagePagination.docx"

			'Save the file.
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
