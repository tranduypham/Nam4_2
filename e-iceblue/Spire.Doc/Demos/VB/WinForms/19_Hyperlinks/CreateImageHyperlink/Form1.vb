Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace CreateImageHyperlink
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Document
			Dim input As String = "..\..\..\..\..\..\Data\BlankTemplate.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			Dim section As Section = doc.Sections(0)
			'Add a paragraph
			Dim paragraph As Paragraph = section.AddParagraph()
			'Load an image to a DocPicture object
			Dim image As Image = Image.FromFile("..\..\..\..\..\..\Data\Spire.Doc.png")
			Dim picture As New DocPicture(doc)
			'Add an image hyperlink to the paragraph
			picture.LoadImage(image)
			paragraph.AppendHyperlink("https://www.e-iceblue.com/Introduce/word-for-net-introduce.html", picture, HyperlinkType.WebLink)

			'Save and launch document
			Dim output As String = "CreateImageHyperlink.docx"
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
