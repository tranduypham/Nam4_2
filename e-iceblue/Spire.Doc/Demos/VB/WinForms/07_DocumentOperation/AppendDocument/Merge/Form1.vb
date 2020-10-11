Imports Spire.Doc

Namespace Merge
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
				'Create word document
				Dim document As New Document()
				document.LoadFromFile("..\..\..\..\..\..\..\Data\Summary_of_Science.doc", FileFormat.Doc)

				Dim documentMerge As New Document()
				documentMerge.LoadFromFile("..\..\..\..\..\..\..\Data\Bookmark.docx", FileFormat.Docx)

				For Each sec As Section In documentMerge.Sections
					document.Sections.Add(sec.Clone())
				Next sec

				'Save as docx file.
				document.SaveToFile("Sample.docx", FileFormat.Docx)

				'Launching the MS Word file.
				WordDocViewer("Sample.docx")


		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
