Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SplitDocBySectionBreak
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\..\Data\Template_Docx_4.docx")

			'Define another new word document object.
			Dim newWord As Document

			'Split a Word document into multiple documents by section break.
			For i As Integer = 0 To document.Sections.Count - 1
				Dim result As String = String.Format("Result-SplitWordFileBySectionBreak_{0}.docx", i)
				newWord = New Document()
				newWord.Sections.Add(document.Sections(i).Clone())

				'Save to file.
				newWord.SaveToFile(result)

				'Launch the MS Word file.
				WordDocViewer(result)
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
