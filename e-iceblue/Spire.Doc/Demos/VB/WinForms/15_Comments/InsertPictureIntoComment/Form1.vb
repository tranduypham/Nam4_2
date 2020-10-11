Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertPictureIntoComment
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\CommentTemplate.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the first paragraph and insert comment
			Dim paragraph As Paragraph = doc.Sections(0).Paragraphs(2)
			Dim comment As Comment = paragraph.AppendComment("This is a comment.")
			comment.Format.Author = "E-iceblue"

			'Load a picture
			Dim docPicture As New DocPicture(doc)
			Dim img As Image = Image.FromFile("..\..\..\..\..\..\Data\E-iceblue.png")
			docPicture.LoadImage(img)

			'Insert the picture into the comment body
			comment.Body.AddParagraph().ChildObjects.Add(docPicture)

			'Save and launch
			Dim output As String = "InsertPictureIntoComment.docx"
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
