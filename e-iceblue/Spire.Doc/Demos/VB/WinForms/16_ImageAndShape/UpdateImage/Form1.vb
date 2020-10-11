Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace UpdateImage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Document
			Dim input As String = "..\..\..\..\..\..\Data\ImageTemplate.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get all pictures in the Word document
			Dim pictures As New List(Of DocumentObject)()
			For Each sec As Section In doc.Sections
				For Each para As Paragraph In sec.Paragraphs
					For Each docObj As DocumentObject In para.ChildObjects
						If docObj.DocumentObjectType = DocumentObjectType.Picture Then
							pictures.Add(docObj)
						End If
					Next docObj
				Next para
			Next sec

			'Replace the first picture with a new image file
			Dim picture As DocPicture = TryCast(pictures(0), DocPicture)
			picture.LoadImage(Image.FromFile("..\..\..\..\..\..\Data\E-iceblue.png"))

			'Save and launch document
			Dim output As String = "ReplaceWithNewImage.docx"
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
