Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace FontAndColor
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Initialize a document
			Dim document As New Document()
			Dim sec As Section = document.AddSection()
			Dim titleParagraph As Paragraph = sec.AddParagraph()
			titleParagraph.AppendText("Font Styles and Effects ")
			titleParagraph.ApplyStyle(BuiltinStyle.Title)

			Dim paragraph As Paragraph = sec.AddParagraph()
			Dim tr As TextRange = paragraph.AppendText("Strikethough Text")
			tr.CharacterFormat.IsStrikeout = True

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Shadow Text")
			tr.CharacterFormat.IsShadow = True

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Small caps Text")
			tr.CharacterFormat.IsSmallCaps = True

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Double Strikethough Text")
			tr.CharacterFormat.DoubleStrike = True

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Outline Text")
			tr.CharacterFormat.IsOutLine = True

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("AllCaps Text")
			tr.CharacterFormat.AllCaps = True

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Text")
			tr = paragraph.AppendText("SubScript")
			tr.CharacterFormat.SubSuperScript = SubSuperScript.SubScript

			tr = paragraph.AppendText("And")
			tr = paragraph.AppendText("SuperScript")
			tr.CharacterFormat.SubSuperScript = SubSuperScript.SuperScript

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Emboss Text")
			tr.CharacterFormat.Emboss = True
			tr.CharacterFormat.TextColor = Color.White

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Hidden:")
			tr = paragraph.AppendText("Hidden Text")
			tr.CharacterFormat.Hidden = True

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Engrave Text")
			tr.CharacterFormat.Engrave = True
			tr.CharacterFormat.TextColor = Color.White

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("WesternFontsÖÐÎÄ×ÖÌå")
			tr.CharacterFormat.FontNameAscii = "Calibri"
			tr.CharacterFormat.FontNameNonFarEast = "Calibri"
			tr.CharacterFormat.FontNameFarEast = "Simsun"

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Font Size")
			tr.CharacterFormat.FontSize = 20

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Font Color")
			tr.CharacterFormat.TextColor=Color.Red

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Bold Italic Text")
			tr.CharacterFormat.Bold = True
			tr.CharacterFormat.Italic = True

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Underline Style")
			tr.CharacterFormat.UnderlineStyle = UnderlineStyle.Single

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Highlight Text")
			tr.CharacterFormat.HighlightColor = Color.Yellow

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Text has shading")
			tr.CharacterFormat.TextBackgroundColor = Color.Green

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Border Around Text")
			tr.CharacterFormat.Border.BorderType = Spire.Doc.Documents.BorderStyle.Single

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Text Scale")
			tr.CharacterFormat.TextScale = 150

			paragraph.AppendBreak(BreakType.LineBreak)
			tr = paragraph.AppendText("Character Spacing is 2 point")
			tr.CharacterFormat.CharacterSpacing = 2

			Dim filePath As String = "CharaterFormatting.docx"
			document.SaveToFile(filePath, FileFormat.Docx)
			WordDocViewer(filePath)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
