Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace PreserveTheme
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the source document
			Dim input As String = "..\..\..\..\..\..\..\Data\Theme.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Create a new Word document
			Dim newWord As New Document()
			'Clone default style, theme, compatibility from the source file to the destination document
			doc.CloneDefaultStyleTo(newWord)
			doc.CloneThemesTo(newWord)
			doc.CloneCompatibilityTo(newWord)

			'Add the cloned section to destination document
			newWord.Sections.Add(doc.Sections(0).Clone())

			'Save and launch document
			Dim output As String = "PreserveTheme.docx"
			newWord.SaveToFile(output, FileFormat.Docx)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
