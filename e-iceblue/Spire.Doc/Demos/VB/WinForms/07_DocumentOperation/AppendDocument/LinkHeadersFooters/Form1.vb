Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace LinkHeadersFooters
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the source file
			Dim srcDoc As New Document()
			srcDoc.LoadFromFile("..\..\..\..\..\..\..\Data\Template_N1.docx")

			'Load the destination file
			Dim dstDoc As New Document()
			dstDoc.LoadFromFile("..\..\..\..\..\..\..\Data\Template_N2.docx")

			'Link the headers and footers in the source file
			srcDoc.Sections(0).HeadersFooters.Header.LinkToPrevious = True
			srcDoc.Sections(0).HeadersFooters.Footer.LinkToPrevious = True

			'Clone the sections of source to destination
			For Each section As Section In srcDoc.Sections
				dstDoc.Sections.Add(section.Clone())
			Next section

			'Save the document
			Dim output As String="LinkHeadersFooters_out.docx"
			dstDoc.SaveToFile(output, FileFormat.Docx2013)

			'Launching the document
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
