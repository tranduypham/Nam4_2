Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ExtractComment
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\CommentSample.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			Dim SB As New StringBuilder()

			'Traverse all comments
			For Each comment As Comment In doc.Comments
				For Each p As Paragraph In comment.Body.Paragraphs
					SB.AppendLine(p.Text)
				Next p
			Next comment

			'Save to TXT File and launch it
			Dim output As String = "ExtractComment.txt"
			File.WriteAllText(output, SB.ToString())
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
