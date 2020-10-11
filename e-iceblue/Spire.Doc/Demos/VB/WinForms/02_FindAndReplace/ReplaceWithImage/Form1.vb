Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ReplaceWithImage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Document
			Dim input As String = "..\..\..\..\..\..\Data\Template.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Load the image
			Dim image As Image = Image.FromFile("..\..\..\..\..\..\Data\E-iceblue.png")

			'Find the string "E-iceblue" in the document
			Dim selections() As TextSelection = doc.FindAllString("E-iceblue", True, True)
			Dim index As Integer = 0
			Dim range As TextRange = Nothing

			'Remove the text and replace it with Image
			For Each selection As TextSelection In selections
				Dim pic As New DocPicture(doc)
				pic.LoadImage(image)

				range = selection.GetAsOneRange()
				index = range.OwnerParagraph.ChildObjects.IndexOf(range)
				range.OwnerParagraph.ChildObjects.Insert(index, pic)
				range.OwnerParagraph.ChildObjects.Remove(range)
			Next selection

			'Save and launch document
			Dim output As String = "ReplaceWithImage.docx"
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
