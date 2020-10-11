Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc

Namespace PreserveWordBookmarks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\..\Data\Sample.doc")

			Dim toPdf As New ToPdfParameterList()
			toPdf.CreateWordBookmarks = True
			toPdf.WordBookmarksTitle = "Bookmark"
			toPdf.WordBookmarksColor = Color.Gray

			'the event of BookmarkLayout occurs when drawing a bookmark
			AddHandler document.BookmarkLayout, AddressOf document_BookmarkLayout

			'Save the document to a PDF file.
			document.SaveToFile("PreserveBookmarks.pdf", toPdf)

			'Launch the file.
			FileViewer("PreserveBookmarks.pdf")
		End Sub
		Private Shared Sub document_BookmarkLayout(ByVal sender As Object, ByVal args As Spire.Doc.Documents.Rendering.BookmarkLevelEventArgs)

			If args.BookmarkLevel.Level = 2 Then
				args.BookmarkLevel.Color = Color.Red
				args.BookmarkLevel.Style = BookmarkTextStyle.Bold
			ElseIf args.BookmarkLevel.Level = 3 Then
				args.BookmarkLevel.Color = Color.Gray
				args.BookmarkLevel.Style = BookmarkTextStyle.Italic
			Else
				args.BookmarkLevel.Color = Color.Green
				args.BookmarkLevel.Style = BookmarkTextStyle.Regular
			End If

		End Sub

		Private Sub FileViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
