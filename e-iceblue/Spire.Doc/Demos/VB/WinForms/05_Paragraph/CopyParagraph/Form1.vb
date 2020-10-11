Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace CopyParagraph
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document1.
			Dim document1 As New Document()

			'Load the file from disk.
			document1.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_5.docx")

			'Create a new document.
			Dim document2 As New Document()

			'Get paragraph 1 and paragraph 2 in document1.
			Dim s As Section = document1.Sections(0)
			Dim p1 As Paragraph = s.Paragraphs(0)
			Dim p2 As Paragraph = s.Paragraphs(1)

			'Copy p1 and p2 to document2.
			Dim s2 As Section = document2.AddSection()
			Dim NewPara1 As Paragraph = CType(p1.Clone(), Paragraph)
			s2.Paragraphs.Add(NewPara1)
			Dim NewPara2 As Paragraph = CType(p2.Clone(), Paragraph)
			s2.Paragraphs.Add(NewPara2)

			'Add watermark.
			Dim WM As New PictureWatermark()
			WM.Picture = Image.FromFile("..\..\..\..\..\..\Data\Logo.jpg")
			document2.Watermark = WM

			Dim result As String = "Result-CopyWordParagraph.docx"

			'Save the file.
			document2.SaveToFile(result, FileFormat.Docx2013)

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
