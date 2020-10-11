Imports Spire.Doc

Namespace AdjustHeaderFooterHeight
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\HeaderAndFooter.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the first section
			Dim section As Section = doc.Sections(0)

			'Adjust the height of headers in the section
			section.PageSetup.HeaderDistance = 100

			'Adjust the height of footers in the section
			section.PageSetup.FooterDistance = 100

			'Save and launch document
			Dim output As String = "AdjustHeaderFooterHeight.docx"
			doc.SaveToFile(output, FileFormat.Docx)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
