Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SetImageBackground
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'load a word document
			Dim document As New Document("..\..\..\..\..\..\Data\Template.docx")

			'set the background type as picture.
			document.Background.Type = BackgroundType.Picture

			'set the background picture
			document.Background.Picture = Image.FromFile("..\..\..\..\..\..\Data\Background.png")

			'save the file.
			document.SaveToFile("ImageBackground.docx", FileFormat.Docx)

			'launching the Word file.
			WordDocViewer("ImageBackground.docx")


		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
