Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace FormACatalogue
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Add a new section. 
			Dim section As Section = document.AddSection()
			Dim paragraph As Paragraph = If(section.Paragraphs.Count > 0, section.Paragraphs(0), section.AddParagraph())

			'Add Heading 1.
			paragraph = section.AddParagraph()
			paragraph.AppendText(BuiltinStyle.Heading1.ToString())
			paragraph.ApplyStyle(BuiltinStyle.Heading1)
			paragraph.ListFormat.ApplyNumberedStyle()

			'Add Heading 2.
			paragraph = section.AddParagraph()
			paragraph.AppendText(BuiltinStyle.Heading2.ToString())
			paragraph.ApplyStyle(BuiltinStyle.Heading2)

			'List style for Headings 2.
			Dim listSty2 As New ListStyle(document, ListType.Numbered)
			For Each listLev As ListLevel In listSty2.Levels
				listLev.UsePrevLevelPattern = True
				listLev.NumberPrefix = "1."
			Next listLev
			listSty2.Name = "MyStyle2"
			document.ListStyles.Add(listSty2)
			paragraph.ListFormat.ApplyStyle(listSty2.Name)

			'Add list style 3.
			Dim listSty3 As New ListStyle(document, ListType.Numbered)
			For Each listLev As ListLevel In listSty3.Levels
				listLev.UsePrevLevelPattern = True
				listLev.NumberPrefix = "1.1."
			Next listLev
			listSty3.Name = "MyStyle3"
			document.ListStyles.Add(listSty3)

			'Add Heading 3.
			For i As Integer = 0 To 3
				paragraph = section.AddParagraph()

				'Append text
				paragraph.AppendText(BuiltinStyle.Heading3.ToString())

				'Apply list style 3 for Heading 3
				paragraph.ApplyStyle(BuiltinStyle.Heading3)
				paragraph.ListFormat.ApplyStyle(listSty3.Name)
			Next i

			Dim result As String = "Result-FormACatalogue.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx)

			'Launch the MS Word file.
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
