Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace EmbedPrivateFont
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\BlankTemplate.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the first section and add a paragraph
			Dim section As Section = doc.Sections(0)
			Dim p As Paragraph = section.AddParagraph()

			'Append text to the paragraph, then set the font name and font size
			Dim range As TextRange = p.AppendText("Spire.Doc for .NET is a professional Word.NET library specifically designed for developers to create, read, write, convert and print Word document files from any.NET platform with fast and high quality performance.")
			range.CharacterFormat.FontName = "PT Serif Caption"
			range.CharacterFormat.FontSize = 20

			'Allow embedding font in document
			doc.EmbedFontsInFile = True

			'Embed private font from font file into the document
			doc.PrivateFontList.Add(New PrivateFontPath("PT Serif Caption", "..\..\..\..\..\..\Data\PT Serif Caption.ttf"))

			'Save and launch document
			Dim output As String = "EmbedPrivateFont.docx"
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
