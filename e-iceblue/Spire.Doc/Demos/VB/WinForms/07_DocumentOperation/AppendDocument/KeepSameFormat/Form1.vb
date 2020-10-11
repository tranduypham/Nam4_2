Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace KeepSameFormat
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the source document from disk
			Dim srcDoc As New Document()
			srcDoc.LoadFromFile("..\..\..\..\..\..\..\Data\Template_N2.docx")

			'Load the destination document from disk
			Dim destDoc As New Document()
			destDoc.LoadFromFile("..\..\..\..\..\..\..\Data\Template_N3.docx")

			'Keep same format of source document
			srcDoc.KeepSameFormat = True

			'Copy the sections of source document to destination document
			For Each section As Section In srcDoc.Sections
				destDoc.Sections.Add(section.Clone())
			Next section

			'Save the Word document
			Dim output As String="KeepSameFormating_out.docx"
			destDoc.SaveToFile(output, FileFormat.Docx2013)

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
