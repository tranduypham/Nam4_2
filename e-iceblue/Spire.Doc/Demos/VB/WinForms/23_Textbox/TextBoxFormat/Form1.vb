Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace TextBoxFormat
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new document
			Dim doc As New Document()
			Dim sec As Section = doc.AddSection()

			'Add a text box and append sample text
			Dim TB As Spire.Doc.Fields.TextBox = doc.Sections(0).AddParagraph().AppendTextBox(310, 90)
			Dim para As Paragraph = TB.Body.AddParagraph()
			Dim TR As TextRange = para.AppendText("Using Spire.Doc, developers will find " & "a simple and effective method to endow their applications with rich MS Word features. ")
			TR.CharacterFormat.FontName = "Cambria "
			TR.CharacterFormat.FontSize = 13

			'Set exact position for the text box
			TB.Format.HorizontalOrigin = HorizontalOrigin.Page
			TB.Format.HorizontalPosition = 120
			TB.Format.VerticalOrigin = VerticalOrigin.Page
			TB.Format.VerticalPosition = 100

			'Set line style for the text box
			TB.Format.LineStyle = TextBoxLineStyle.Double
			TB.Format.LineColor = Color.CornflowerBlue
			TB.Format.LineDashing = LineDashing.Solid
			TB.Format.LineWidth = 5

			'Set internal margin for the text box
			TB.Format.InternalMargin.Top = 15
			TB.Format.InternalMargin.Bottom = 10
			TB.Format.InternalMargin.Left = 12
			TB.Format.InternalMargin.Right = 10

			'Save and launch document
			Dim output As String = "TextBoxFormat.docx"
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
