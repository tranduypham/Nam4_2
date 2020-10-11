Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace CloneSectionContent
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the Word document from disk
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\SectionTemplate.docx")

			'Get the first section
			Dim sec1 As Section = doc.Sections(0)
			'Get the second section
			Dim sec2 As Section = doc.Sections(1)

			'Loop through the contents of sec1
			For Each obj As DocumentObject In sec1.Body.ChildObjects
				'Clone the contents to sec2
				sec2.Body.ChildObjects.Add(obj.Clone())
			Next obj

			'Save the Word document
			Dim output As String = "CloneSectionContent_out.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)

			'Launch the file
			WordDocViewer(output)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
