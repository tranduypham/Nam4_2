Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace BetweenParagraphStyles
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create the first document
			Dim sourceDocument As New Document()

			'Load the source document from disk.
			sourceDocument.LoadFromFile("..\..\..\..\..\..\Data\BetweenParagraphStyle.docx")

			'Create a destination document
			Dim destinationDoc As New Document()

			'Add a section
			Dim section As Section = destinationDoc.AddSection()

			'Extract content between the first paragraph to the third paragraph
			ExtractBetweenParagraphStyles(sourceDocument, destinationDoc, "1", "2")

			'Save the document.
			destinationDoc.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub

		Private Shared Sub ExtractBetweenParagraphStyles(ByVal sourceDocument As Document, ByVal destinationDocument As Document, ByVal stylename1 As String, ByVal stylename2 As String)
			Dim startindex As Integer = 0
			Dim endindex As Integer = 0
			'travel the sections of source document
			For Each section As Section In sourceDocument.Sections
				'travel the paragraphs
				For Each paragraph As Paragraph In section.Paragraphs
					'Judge paragraph style1
					If paragraph.StyleName = stylename1 Then
						'Get the paragraph index
						startindex = section.Body.Paragraphs.IndexOf(paragraph)
					End If
					'Judge paragraph style2
					If paragraph.StyleName = stylename2 Then
						'Get the paragraph index
						endindex = section.Body.Paragraphs.IndexOf(paragraph)
					End If
				Next paragraph
				'Extract the content
				For i As Integer = startindex + 1 To endindex - 1
					'Clone the ChildObjects of source document
					Dim doobj As DocumentObject = sourceDocument.Sections(0).Body.ChildObjects(i).Clone()

					'Add to destination document 
					destinationDocument.Sections(0).Body.ChildObjects.Add(doobj)
				Next i
			Next section
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
