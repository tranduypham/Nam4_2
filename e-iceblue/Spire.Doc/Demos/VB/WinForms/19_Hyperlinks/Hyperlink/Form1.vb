Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace Hyperlink
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a blank word document as template
			Dim document As New Document()
			Dim section As Section = document.AddSection()

			'Insert hyperlink
			InsertHyperlink(section)

			'Save doc file.
			document.SaveToFile("Sample.docx", FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer("Sample.docx")


		End Sub

		Private Sub InsertHyperlink(ByVal section As Section)
			Dim paragraph As Paragraph = If(section.Paragraphs.Count > 0, section.Paragraphs(0), section.AddParagraph())
			paragraph.AppendText("Spire.Doc for .NET " & vbCrLf & " e-iceblue company Ltd. 2002-2010 All rights reserverd")
			paragraph.ApplyStyle(BuiltinStyle.Heading2)

			paragraph = section.AddParagraph()
			paragraph.AppendText("Home page")
			paragraph.ApplyStyle(BuiltinStyle.Heading2)
			paragraph = section.AddParagraph()
			paragraph.AppendHyperlink("www.e-iceblue.com", "www.e-iceblue.com", HyperlinkType.WebLink)

			paragraph = section.AddParagraph()
			paragraph.AppendText("Contact US")
			paragraph.ApplyStyle(BuiltinStyle.Heading2)
			paragraph = section.AddParagraph()
			paragraph.AppendHyperlink("mailto:support@e-iceblue.com", "support@e-iceblue.com", HyperlinkType.EMailLink)

			paragraph = section.AddParagraph()
			paragraph.AppendText("Forum")
			paragraph.ApplyStyle(BuiltinStyle.Heading2)
			paragraph = section.AddParagraph()
			paragraph.AppendHyperlink("www.e-iceblue.com/forum/", "www.e-iceblue.com/forum/", HyperlinkType.WebLink)

			paragraph = section.AddParagraph()
			paragraph.AppendText("Download Link")
			paragraph.ApplyStyle(BuiltinStyle.Heading2)
			paragraph = section.AddParagraph()
			paragraph.AppendHyperlink("www.e-iceblue.com/Download/download-word-for-net-now.html", "www.e-iceblue.com/Download/download-word-for-net-now.html", HyperlinkType.WebLink)

			paragraph = section.AddParagraph()
			paragraph.AppendText("Insert Link On Image")
			paragraph.ApplyStyle(BuiltinStyle.Heading2)
			paragraph = section.AddParagraph()
			Dim picture As DocPicture = paragraph.AppendPicture(Image.FromFile("..\..\..\..\..\..\Data\Spire.Doc.png"))
			paragraph.AppendHyperlink("www.e-iceblue.com/Download/download-word-for-net-now.html", picture, HyperlinkType.WebLink)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
