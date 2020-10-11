Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Fields
Namespace AddCoverImage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim doc As New Document()
            doc.LoadFromFile("..\..\..\..\..\..\Data\ToEpub.doc")
            Dim picture As New DocPicture(doc)
            picture.LoadImage(Image.FromFile("..\..\..\..\..\..\Data\Cover.png"))
            Dim result As String = "AddCoverImage.epub"
			doc.SaveToEpub(result, picture)
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
