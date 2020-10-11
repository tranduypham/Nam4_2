Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace CopyHeaderAndFooter
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the source file
			Dim input As String = "..\..\..\..\..\..\Data\HeaderAndFooter.docx"
			Dim doc1 As New Document()
			doc1.LoadFromFile(input)

			'Get the header section from the source document
			Dim header As HeaderFooter = doc1.Sections(0).HeadersFooters.Header

			'Load the destination file
			input = "..\..\..\..\..\..\Data\Template.docx"
			Dim doc2 As New Document()
			doc2.LoadFromFile(input)

			'Copy each object in the header of source file to destination file
			For Each section As Section In doc2.Sections
				For Each obj As DocumentObject In header.ChildObjects
					section.HeadersFooters.Header.ChildObjects.Add(obj.Clone())
				Next obj
			Next section

			'Save and launch document
			Dim output As String = "CopyHeaderAndFooter.docx"
			doc2.SaveToFile(output, FileFormat.Docx)
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
