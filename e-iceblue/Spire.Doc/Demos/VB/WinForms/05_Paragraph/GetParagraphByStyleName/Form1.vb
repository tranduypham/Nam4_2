Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO

Namespace GetParagraphByStyleName
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_DocX_3.docx")

			Dim content As New StringBuilder()
			content.AppendLine("Get paragraphs by style name ""Heading1"": ")

			'Get paragraphs by style name.
			For Each section As Section In document.Sections
				For Each paragraph As Paragraph In section.Paragraphs
					If paragraph.StyleName = "Heading1" Then
						content.AppendLine(paragraph.Text)
					End If
				Next paragraph
			Next section

			Dim result As String = "Result-GetParagraphsByStyleName.txt"

			'Save to file.
			File.WriteAllText(result,content.ToString())

			'Launch the file.
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
