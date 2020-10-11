Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO

Namespace GetTextByStyleName
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load document from disk
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\Template_N5.docx")

			'Create string builder
			Dim builder As New StringBuilder()

			'Loop through sections
			For Each section As Section In doc.Sections
				'Loop through paragraphs
				For Each para As Paragraph In section.Paragraphs
					'Find the paragraph whose style name is "Heading1"
					If para.StyleName = "Heading1" Then
						'Write the text of paragraph
						builder.AppendLine(para.Text)
					End If
				Next para
			Next section

			'Write the contents in a TXT file
			Dim output As String="GetTextByStyleName_out.txt"
			File.WriteAllText(output, builder.ToString())

			'Launch the file
			TxtViewer(output)
		End Sub
		Private Sub TxtViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
