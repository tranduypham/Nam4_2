Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace SetHyperlinkFormat
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

			'Add a paragraph and append a hyperlink to the paragraph
			Dim para1 As Paragraph = section.AddParagraph()
			para1.AppendText("Regular Link: ")
			'Format the hyperlink with default color and underline style
			Dim txtRange1 As TextRange = para1.AppendHyperlink("www.e-iceblue.com", "www.e-iceblue.com", HyperlinkType.WebLink)
			txtRange1.CharacterFormat.FontName = "Times New Roman"
			txtRange1.CharacterFormat.FontSize = 12
			Dim blankPara1 As Paragraph = section.AddParagraph()

			'Add a paragraph and append a hyperlink to the paragraph
			Dim para2 As Paragraph = section.AddParagraph()
			para2.AppendText("Change Color: ")
			'Format the hyperlink with red color and underline style
			Dim txtRange2 As TextRange = para2.AppendHyperlink("www.e-iceblue.com", "www.e-iceblue.com", HyperlinkType.WebLink)
			txtRange2.CharacterFormat.FontName = "Times New Roman"
			txtRange2.CharacterFormat.FontSize = 12
			txtRange2.CharacterFormat.TextColor = Color.Red
			Dim blankPara2 As Paragraph = section.AddParagraph()

			'Add a paragraph and append a hyperlink to the paragraph
			Dim para3 As Paragraph = section.AddParagraph()
			para3.AppendText("Remove Underline: ")
			'Format the hyperlink with red color and no underline style
			Dim txtRange3 As TextRange = para3.AppendHyperlink("www.e-iceblue.com", "www.e-iceblue.com", HyperlinkType.WebLink)
			txtRange3.CharacterFormat.FontName = "Times New Roman"
			txtRange3.CharacterFormat.FontSize = 12
			txtRange3.CharacterFormat.UnderlineStyle = UnderlineStyle.None

			'Save and launch document
			Dim output As String = "HyperlinkFormat.docx"
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
