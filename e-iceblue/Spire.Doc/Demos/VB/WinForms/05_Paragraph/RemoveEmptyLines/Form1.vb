Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace RemoveEmptyLines
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_3.docx")

			'Traverse every section on the word document and remove the null and empty paragraphs.
			For Each section As Section In document.Sections
				Dim i As Integer = 0
				Do While i < section.Body.ChildObjects.Count
					If section.Body.ChildObjects(i).DocumentObjectType = DocumentObjectType.Paragraph Then
						If String.IsNullOrEmpty((TryCast(section.Body.ChildObjects(i), Paragraph)).Text.Trim()) Then
							section.Body.ChildObjects.Remove(section.Body.ChildObjects(i))
							i -= 1
						End If
					End If

					i += 1
				Loop
			Next section

			Dim result As String = "Result-RemoveEmptyLines.docx"

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
