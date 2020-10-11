Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace SetOutsidePosition
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new word document and add new section
			Dim doc As New Document()
			Dim sec As Section = doc.AddSection()

			'Get header
			Dim header As HeaderFooter = doc.Sections(0).HeadersFooters.Header

			'Add new paragraph on header and set HorizontalAlignment of the paragraph as left
			Dim paragraph As Paragraph = header.AddParagraph()
			paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left

			'Load an image for the paragraph
			Dim headerimage As DocPicture = paragraph.AppendPicture(Image.FromFile("..\..\..\..\..\..\Data\Word.png"))

			'Add a table of 4 rows and 2 columns
			Dim table As Table = header.AddTable()
			table.ResetCells(4, 2)

			'Set the position of the table to the right of the image
			table.TableFormat.WrapTextAround = True
			table.TableFormat.Positioning.HorizPositionAbs = HorizontalPosition.Outside
			table.TableFormat.Positioning.VertRelationTo = VerticalRelation.Margin
			table.TableFormat.Positioning.VertPosition = 43

			'Add contents for the table
			Dim data()() As String = { New String() {"Spire.Doc.left","Spire XLS.right"}, New String() {"Spire.Presentatio.left","Spire.PDF.right"}, New String() {"Spire.DataExport.left","Spire.PDFViewe.right"}, New String (){"Spire.DocViewer.left","Spire.BarCode.right"} }

			For r As Integer = 0 To 3
				Dim dataRow As TableRow = table.Rows(r)
				For c As Integer = 0 To 1
					If c = 0 Then
						Dim par As Paragraph = dataRow.Cells(c).AddParagraph()
						par.AppendText(data(r)(c))
						par.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left
						dataRow.Cells(c).Width = 180
					Else
						Dim par As Paragraph = dataRow.Cells(c).AddParagraph()
						par.AppendText(data(r)(c))
						par.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right
						dataRow.Cells(c).Width = 180
					End If
				Next c
			Next r

			'Save and launch document
			Dim output As String = "SetOutsidePosition.docx"
			doc.SaveToFile(output, FileFormat.Docx)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
