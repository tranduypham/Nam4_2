Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace RemoveFootnote
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\Footnote.docx")
			Dim section As Section = document.Sections(0)

			'traverse paragraphs in the section and find the footnote
			For Each para As Paragraph In section.Paragraphs
				Dim index As Integer = -1
				Dim i As Integer = 0
				Dim cnt As Integer = para.ChildObjects.Count
				Do While i < cnt
					Dim pBase As ParagraphBase = TryCast(para.ChildObjects(i), ParagraphBase)
					If TypeOf pBase Is Footnote Then
						index = i
						Exit Do
					End If
					i += 1
				Loop

				If index > -1 Then
					'remove the footnote
					para.ChildObjects.RemoveAt(index)
				End If
			Next para

			document.SaveToFile("RemoveFootnote.docx", FileFormat.Docx)

			'view the Word file.
			WordDocViewer("RemoveFootnote.docx")
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
