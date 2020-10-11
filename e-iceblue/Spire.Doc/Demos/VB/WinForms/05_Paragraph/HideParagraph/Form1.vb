Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace HideParagraph
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_1.docx")

			'Get the first section and the first paragraph from the word document.
			Dim sec As Section = document.Sections(0)
			Dim para As Paragraph = sec.Paragraphs(0)

			'Loop through the textranges and set CharacterFormat.Hidden property as true to hide the texts.
			For Each obj As DocumentObject In para.ChildObjects
				If TypeOf obj Is TextRange Then
					Dim range As TextRange = TryCast(obj, TextRange)
					range.CharacterFormat.Hidden = True
				End If
			Next obj

			Dim result As String = "Result-HideWordParagraph.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

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
