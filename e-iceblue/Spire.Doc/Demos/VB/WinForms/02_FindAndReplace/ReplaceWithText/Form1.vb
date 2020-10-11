Imports Spire.Doc

Namespace Replace
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create word document
			Dim document As New Document()

			'Load the document from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Sample.docx")

			'Replace text
			document.Replace("word", "ReplacedText",False,True)

			'Save doc file.
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
