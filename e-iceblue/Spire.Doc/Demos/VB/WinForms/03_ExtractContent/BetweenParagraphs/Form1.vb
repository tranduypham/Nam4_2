Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace BetweenParagraphs
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create the first document
			Dim sourceDocument As New Document()

			'Load the source document from disk.
			sourceDocument.LoadFromFile("..\..\..\..\..\..\Data\Sample.docx")

			'Create a destination document
			Dim destinationDoc As New Document()

			'Add a section
			Dim section As Section = destinationDoc.AddSection()

			'Extract content between the first paragraph to the third paragraph
			ExtractBetweenParagraphs(sourceDocument, destinationDoc, 1, 3)

			'Save the document.
			destinationDoc.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub
		Private Shared Sub ExtractBetweenParagraphs(ByVal sourceDocument As Document, ByVal destinationDocument As Document, ByVal startPara As Integer, ByVal endPara As Integer)
			'Extract the content
			For i As Integer = startPara - 1 To endPara - 1
				'Clone the ChildObjects of source document
				Dim doobj As DocumentObject = sourceDocument.Sections(0).Body.ChildObjects(i).Clone()

				'Add to destination document 
				destinationDocument.Sections(0).Body.ChildObjects.Add(doobj)
			Next i
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
