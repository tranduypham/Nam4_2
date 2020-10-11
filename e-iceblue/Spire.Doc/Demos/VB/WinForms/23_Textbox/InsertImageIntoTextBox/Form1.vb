Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace InsertImageIntoTextBox
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new document
			Dim doc As New Document()

			Dim section As Section = doc.AddSection()
			Dim paragraph As Paragraph = section.AddParagraph()

			'Append a textbox to paragraph
			Dim tb As Spire.Doc.Fields.TextBox = paragraph.AppendTextBox(220, 220)

			'Set the position of the textbox
			tb.Format.HorizontalOrigin = HorizontalOrigin.Page
			tb.Format.HorizontalPosition = 50
			tb.Format.VerticalOrigin = VerticalOrigin.Page
			tb.Format.VerticalPosition = 50

			'Set the fill effect of textbox as picture
			tb.Format.FillEfects.Type = BackgroundType.Picture

			'Fill the textbox with a picture
			tb.Format.FillEfects.Picture = Image.FromFile("..\..\..\..\..\..\Data\Spire.Doc.png")

			'Save and launch document
			Dim output As String = "InsertImageIntoTextBox.docx"
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
