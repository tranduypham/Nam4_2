Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace AddPageNumbersInSections
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

			'Repeat step2 and Step3 for the rest sections, so change the code with for loop.
			For i As Integer = 0 To 2
				Dim footer As HeaderFooter = document.Sections(i).HeadersFooters.Footer
				Dim footerParagraph As Paragraph = footer.AddParagraph()
				footerParagraph.AppendField("page number", FieldType.FieldPage)
				footerParagraph.AppendText(" of ")
				footerParagraph.AppendField("number of pages", FieldType.FieldSectionPages)
				footerParagraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right

				If i = 2 Then
					Exit For
				Else
					document.Sections(i + 1).PageSetup.RestartPageNumbering = True
					document.Sections(i + 1).PageSetup.PageStartingNumber = 1
				End If
			Next i

			Dim result As String = "Result-AddPageNumbersInSections.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

			'Launch the Ms Word file.
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
