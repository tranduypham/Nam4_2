Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertingImage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()

			'Add a seciton
			Dim section As Section = document.AddSection()

			'insert image
			InsertImage(section)

			'Save doc file.
			document.SaveToFile("Sample.docx",FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer("Sample.docx")


		End Sub

		Private Sub InsertImage(ByVal section As Section)
			'Add paragraph
			Dim paragraph As Paragraph = section.AddParagraph()
			paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left
			Dim ima As Image = Image.FromFile("..\..\..\..\..\..\Data\Spire.Doc.png")
			'Add a image and set its width and height
			Dim picture As DocPicture = paragraph.AppendPicture(ima)
			picture.Width = 100
			picture.Height = 100

			paragraph = section.AddParagraph()
			paragraph.Format.LineSpacing = 20f
			Dim tr As TextRange = paragraph.AppendText("Spire.Doc for .NET is a professional Word .NET library specially designed for developers to create, read, write, convert and print Word document files from any .NET( C#, VB.NET, ASP.NET) platform with fast and high quality performance. ")
			tr.CharacterFormat.FontName = "Arial"
			tr.CharacterFormat.FontSize = 14

			section.AddParagraph()
			paragraph = section.AddParagraph()
			paragraph.Format.LineSpacing = 20f
			tr = paragraph.AppendText("As an independent Word .NET component, Spire.Doc for .NET doesn't need Microsoft Word to be installed on the machine. However, it can incorporate Microsoft Word document creation capabilities into any developers' .NET applications.")
			tr.CharacterFormat.FontName = "Arial"
			tr.CharacterFormat.FontSize = 14

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
