Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace InsertRtfStringToDoc
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

			'Add a paragraph to the section.
			Dim para As Paragraph = section.AddParagraph()

			'Declare a String variable to store the Rtf string.
			Dim rtfString As String = "{\rtf1\ansi\deff0 {\fonttbl {\f0 hakuyoxingshu7000;}}\f0\fs28 Hello, World}"

			'Append Rtf string to paragraph.
			para.AppendRTF(rtfString)

			Dim result As String = "Result-InsertRtfStringToWord.docx"

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
