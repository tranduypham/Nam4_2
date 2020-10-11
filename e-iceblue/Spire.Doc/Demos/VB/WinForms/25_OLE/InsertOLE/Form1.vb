Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertOLE
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim doc As New Document()

			'add a section
			Dim sec As Section = doc.AddSection()

			'add a paragraph
			Dim par As Paragraph = sec.AddParagraph()

			'load the image
			Dim picture As New DocPicture(doc)
			Dim image As Image = Image.FromFile("..\..\..\..\..\..\Data\excel.png")
			picture.LoadImage(image)

			'insert the OLE
			Dim obj As DocOleObject = par.AppendOleObject("...\..\..\..\..\..\Data\example.xlsx", picture, OleObjectType.ExcelWorksheet)
			doc.SaveToFile("InsertOLE.docx", FileFormat.Docx2013)

			FileViewer("InsertOLE.docx")
		End Sub
		Private Sub FileViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
