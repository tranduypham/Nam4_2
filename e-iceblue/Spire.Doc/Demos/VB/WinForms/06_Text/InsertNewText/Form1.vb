Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace InsertNewText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Document
			Dim input As String = "..\..\..\..\..\..\Data\Sample.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Find all the text string "New Zealand" from the sample document
			Dim selections() As TextSelection = doc.FindAllString("Word", True, True)
			Dim index As Integer = 0

			'Defines text range
			Dim range As New TextRange(doc)

			'Insert new text string (New) after the searched text string
			For Each selection As TextSelection In selections
				range = selection.GetAsOneRange()
				Dim newrange As New TextRange(doc)
				newrange.Text = ("(New text)")
				index = range.OwnerParagraph.ChildObjects.IndexOf(range)
				range.OwnerParagraph.ChildObjects.Insert(index + 1, newrange)
			Next selection

			'Find and highlight the newly added text string New
			Dim text() As TextSelection = doc.FindAllString("New text", True, True)
			For Each seletion As TextSelection In text
				seletion.GetAsOneRange().CharacterFormat.HighlightColor = Color.Yellow
			Next seletion

			'Save and launch document
			Dim output As String = "InsertNewText.docx"
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
