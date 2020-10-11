Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace RemovePageBreaks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_4.docx")

			'Traverse every paragraph of the first section of the document.
			For j As Integer = 0 To document.Sections(0).Paragraphs.Count - 1
				Dim p As Paragraph = document.Sections(0).Paragraphs(j)

				'Traverse every child object of a paragraph.
				Dim i As Integer = 0
				Do While i < p.ChildObjects.Count
					Dim obj As DocumentObject = p.ChildObjects(i)

					'Find the page break object.
					If obj.DocumentObjectType = DocumentObjectType.Break Then
						Dim b As Break = TryCast(obj, Break)

						'Remove the page break object from paragraph.
						p.ChildObjects.Remove(b)
					End If
					i += 1
				Loop
			Next j

			Dim result As String = "Result-RemovePageBreaks.docx"

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
