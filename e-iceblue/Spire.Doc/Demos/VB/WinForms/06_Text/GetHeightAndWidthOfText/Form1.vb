Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO

Namespace GetHeightAndWidthOfText
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

			'Define the text string that we need to get the height and width.
			Dim text As String = "Your Office Development Master"

			'Finds and returns the string with formatting
			Dim selection As TextSelection = document.FindString(text, True, True)

			'Get the font
			Dim font As Font = selection.GetAsOneRange().CharacterFormat.Font

			'Initialize graphics object
			Dim fakeImage As Image = New Bitmap(1, 1)
			Dim graphics As Graphics = Graphics.FromImage(fakeImage)

			'Measure string
			Dim size As SizeF = graphics.MeasureString(text, font)

			'Get the height and width of the text.
			Dim content As New StringBuilder()
			content.AppendLine("text height: " & size.Height)
			content.AppendLine("text width: " & size.Width)

			Dim result As String = "Result-GetHeightAndWidthOfText.txt"

			'Save to file.
			File.WriteAllText(result,content.ToString())

			'Launch the file.
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
