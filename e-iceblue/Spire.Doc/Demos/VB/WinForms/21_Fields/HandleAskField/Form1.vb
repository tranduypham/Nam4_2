Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Fields
Imports Spire.Doc.Documents
Namespace HandleAskField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create and load Word document.
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\HandleAskField.docx")

			'call UpdateFieldsHandler event to handle the ASK field.
			AddHandler doc.UpdateFields, AddressOf doc_UpdateFields
			'update the fields in the document.
			doc.IsUpdateFields = True
			'save the document.
			doc.SaveToFile("HandleAskField.docx", FileFormat.Docx)
			WordDocViewer("HandleAskField.docx")

		End Sub
		Private Shared Sub doc_UpdateFields(ByVal sender As Object, ByVal args As IFieldsEventArgs)
			If TypeOf args Is AskFieldEventArgs Then
				Dim askArgs As AskFieldEventArgs = TryCast(args, AskFieldEventArgs)

				If askArgs.BookmarkName = "1" Then
					askArgs.ResponseText = "Thank you. This is my first time to come to a Chinese restaurant. Could you tell me the different features of Chinese food?"
				End If

				If askArgs.BookmarkName = "2" Then
					askArgs.ResponseText = "No more, thank you. I'm quite full."
				End If
			End If
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
