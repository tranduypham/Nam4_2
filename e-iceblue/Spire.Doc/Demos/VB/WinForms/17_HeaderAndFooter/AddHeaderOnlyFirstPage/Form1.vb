Imports Spire.Doc

Namespace AddHeaderOnlyFirstPage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the source file
			Dim input As String = "..\..\..\..\..\..\Data\HeaderAndFooter.docx"
			Dim doc1 As New Document()
			doc1.LoadFromFile(input)

			'Get the header from the first section
			Dim header As HeaderFooter = doc1.Sections(0).HeadersFooters.Header

			'Load the destination file
			input = "..\..\..\..\..\..\Data\MultiplePages.docx"
			Dim doc2 As New Document()
			doc2.LoadFromFile(input)

			'Get the first page header of the destination document
			Dim firstPageHeader As HeaderFooter = doc2.Sections(0).HeadersFooters.FirstPageHeader

			'Specify that the current section has a different header/footer for the first page
			For Each section As Section In doc2.Sections
				section.PageSetup.DifferentFirstPageHeaderFooter = True
			Next section

			'Removes all child objects in firstPageHeader
			firstPageHeader.Paragraphs.Clear()

			'Add all child objects of the header to firstPageHeader
			For Each obj As DocumentObject In header.ChildObjects
				firstPageHeader.ChildObjects.Add(obj.Clone())
			Next obj

			'Save and launch the file
			Dim resultfile As String = "AddHeaderOnlyFirstPage.docx"
			doc2.SaveToFile(resultfile, FileFormat.Docx)
			Viewer(resultfile)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
