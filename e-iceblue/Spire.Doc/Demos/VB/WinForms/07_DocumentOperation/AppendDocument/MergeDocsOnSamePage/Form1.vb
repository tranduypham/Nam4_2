Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace MergeDocsOnSamePage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()

			'Load the source document from disk.
			document.LoadFromFile("..\..\..\..\..\..\..\Data\Insert.docx")

			'Clone a destination  document
			Dim destinationDocument As New Document()

			'Load the destination document from disk.
			destinationDocument.LoadFromFile("..\..\..\..\..\..\..\Data\TableOfContent.docx")

			'Traverse sections
			For Each section As Section In document.Sections

				'Traverse body ChildObjects
				For Each obj As DocumentObject In section.Body.ChildObjects
					'Clone to destination document at the same page
					destinationDocument.Sections(0).Body.ChildObjects.Add(obj.Clone())
				Next obj
			Next section
			'Save the document.
			destinationDocument.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
