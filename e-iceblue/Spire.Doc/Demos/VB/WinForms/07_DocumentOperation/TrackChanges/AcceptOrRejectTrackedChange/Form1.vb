Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace AcceptOrRejectTrackedChange
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\..\Data\AcceptOrRejectTrackedChanges.docx")

			'Get the first section and the paragraph we want to accept/reject the changes.
			Dim sec As Section = document.Sections(0)
			Dim para As Paragraph = sec.Paragraphs(0)

			'Accept the changes or reject the changes.
			para.Document.AcceptChanges()
			'para.Document.RejectChanges();

			Dim result As String = "Result-AcceptOrRejectTrackedChanges.docx"

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
