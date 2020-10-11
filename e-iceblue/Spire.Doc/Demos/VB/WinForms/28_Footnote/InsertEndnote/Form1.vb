Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Fields
Imports Spire.Doc.Documents

Namespace InsertEndnote
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document and load file
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\InsertEndnote.doc")
			Dim s As Section = doc.Sections(0)
			Dim p As Paragraph = s.Paragraphs(1)

			'add endnote
			Dim endnote As Footnote = p.AppendFootnote(FootnoteType.Endnote)

			'append text
			Dim text As TextRange = endnote.TextBody.AddParagraph().AppendText("Reference: Wikipedia")

			'set text format
			text.CharacterFormat.FontName = "Impact"
			text.CharacterFormat.FontSize = 14
			text.CharacterFormat.TextColor = Color.DarkOrange

			'Set marker format of endnote
			endnote.MarkerCharacterFormat.FontName = "Calibri"
			endnote.MarkerCharacterFormat.FontSize = 25
			endnote.MarkerCharacterFormat.TextColor = Color.DarkBlue

			'Save the document
			doc.SaveToFile("InsertEndnote.docx", FileFormat.Docx)

			'Launch the Word file
			WordDocViewer("InsertEndnote.docx")

		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
