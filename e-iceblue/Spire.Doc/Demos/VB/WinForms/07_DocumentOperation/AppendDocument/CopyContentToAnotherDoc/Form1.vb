Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace CopyContentToAnotherDoc
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Initialize a new object of Document class and load the source document.
			Dim sourceDoc As New Document()
			sourceDoc.LoadFromFile("..\..\..\..\..\..\..\Data\Template_Docx_1.docx")

			'Initialize another object to load target document.
			Dim destinationDoc As New Document()
			destinationDoc.LoadFromFile("..\..\..\..\..\..\..\Data\Target.docx")

			'Copy content from source file and insert them to the target file.
			For Each sec As Section In sourceDoc.Sections
				For Each obj As DocumentObject In sec.Body.ChildObjects
					destinationDoc.Sections(0).Body.ChildObjects.Add(obj.Clone())
				Next obj
			Next sec

			Dim result As String = "Result-CopyContentToAnotherWord.docx"

			'Save to file.
			destinationDoc.SaveToFile(result, FileFormat.Docx2013)

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
