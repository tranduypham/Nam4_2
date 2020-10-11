Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertPageBreakFirstApproach
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

            'Load the file from disk.
            document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_2.docx")

            'Find the specified word "technology" where we want to insert the page break.
            Dim selections() As TextSelection = document.FindAllString("technology", True, True)

			'Traverse each word "technology".
			For Each ts As TextSelection In selections
				Dim range As TextRange = ts.GetAsOneRange()
				Dim paragraph As Paragraph = range.OwnerParagraph
				Dim index As Integer = paragraph.ChildObjects.IndexOf(range)

				'Create a new instance of page break and insert a page break after the word "technology".
				Dim pageBreak As New Break(document, BreakType.PageBreak)
				paragraph.ChildObjects.Insert(index + 1, pageBreak)
			Next ts

			Dim result As String = "Result-InsertPageBreakAtSpecifiedLocation.docx"

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
