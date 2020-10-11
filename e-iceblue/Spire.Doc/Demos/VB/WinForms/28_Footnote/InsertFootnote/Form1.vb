Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc.Fields
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace InsertFootnote
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\FootnoteExample.docx")

			'finds the first matched string.
			Dim selection As TextSelection = document.FindString("Spire.Doc", False, True)

			Dim textRange As TextRange = selection.GetAsOneRange()
			Dim paragraph As Paragraph = textRange.OwnerParagraph
			Dim index As Integer = paragraph.ChildObjects.IndexOf(textRange)
			Dim footnote As Footnote = paragraph.AppendFootnote(FootnoteType.Footnote)
			paragraph.ChildObjects.Insert(index + 1, footnote)

			textRange = footnote.TextBody.AddParagraph().AppendText("Welcome to evaluate Spire.Doc")
			textRange.CharacterFormat.FontName = "Arial Black"
			textRange.CharacterFormat.FontSize = 10
			textRange.CharacterFormat.TextColor = Color.DarkGray

			footnote.MarkerCharacterFormat.FontName = "Calibri"
			footnote.MarkerCharacterFormat.FontSize = 12
			footnote.MarkerCharacterFormat.Bold = True
			footnote.MarkerCharacterFormat.TextColor = Color.DarkGreen

			document.SaveToFile("AddFootnote.docx", FileFormat.Docx2010)

			'view the Word file.
			WordDocViewer("AddFootnote.docx")
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
