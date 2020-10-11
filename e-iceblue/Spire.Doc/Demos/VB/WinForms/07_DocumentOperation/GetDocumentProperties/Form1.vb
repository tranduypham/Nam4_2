Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO
Imports System.Text

Namespace GetDocumentProperties
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()

			'Load the document from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Properties.docx")

			'Create StringBuilder to save 
			Dim content As New StringBuilder()

			'Get Builtin document properties
			Dim title As String = document.BuiltinDocumentProperties.Title
			Dim comments As String = document.BuiltinDocumentProperties.Comments
			Dim author As String = document.BuiltinDocumentProperties.Author
			Dim keywords As String = document.BuiltinDocumentProperties.Keywords
			Dim company As String = document.BuiltinDocumentProperties.Company

			'Set string format for displaying
			Dim result As String = String.Format("The Builtin document properties:" & vbCrLf & "Title: " & title & "." & vbCrLf & "Comments: " & comments & "." & vbCrLf & "Author: " & author & "." & vbCrLf & "Keywords: " & keywords & "." & vbCrLf & "Company: " & company)

			'Add result string to StringBuilder
			content.AppendLine(result & vbCrLf & "The custom document properties:")

			'Get custom document properties
			For i As Integer = 0 To document.CustomDocumentProperties.Count - 1
				Dim customProperties As String = String.Format(document.CustomDocumentProperties(i).Name & ": " & document.CustomDocumentProperties(i).Value)
				content.AppendLine(customProperties)
			Next i

			'Save them to a txt file
			File.WriteAllText("Output.txt", content.ToString())

			'Launch the txt file.
			WordDocViewer("Output.txt")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
