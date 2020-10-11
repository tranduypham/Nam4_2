Imports Spire.Doc
Imports System.Drawing.Printing

Namespace CustomPaperSize
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\Sample.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the PrintDocument object
			Dim printDoc As PrintDocument = doc.PrintDocument

			'Custom the paper size
			printDoc.DefaultPageSettings.PaperSize = New PaperSize("custom", 900, 800)

			'Print the document
			printDoc.Print()
		End Sub
	End Class
End Namespace
