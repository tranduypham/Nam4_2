Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertImage
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
			Dim paragraph As Paragraph = If(section.Paragraphs.Count > 0, section.Paragraphs(0), section.AddParagraph())
			paragraph.AppendText("The sample demonstrates how to insert an image into a document.")
			paragraph.ApplyStyle(BuiltinStyle.Heading2)
			paragraph = section.AddParagraph()
			paragraph.AppendText("The above is a picture.")
			'get original image 
			Dim p As New Bitmap(Image.FromFile("..\..\..\..\..\..\Data\Word.png"))

			'rotate image and insert image to word document
			p.RotateFlip(RotateFlipType.Rotate90FlipX)

			'Create a picture
			Dim picture As New DocPicture(doc)
			picture.LoadImage(p)
			'set image's position
			picture.HorizontalPosition = 50.0F
			picture.VerticalPosition = 60.0F

			'set image's size
			picture.Width = 200
			picture.Height = 200

			'set textWrappingStyle with image;
			picture.TextWrappingStyle = TextWrappingStyle.Through
			'Insert the picture at the beginning of the second paragraph
			paragraph.ChildObjects.Insert(0,picture)

			'Save and launch document
			Dim output As String = "InsertImageAtSpecifiedLocation.docx"
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
