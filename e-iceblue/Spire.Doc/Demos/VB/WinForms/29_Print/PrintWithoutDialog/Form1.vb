Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.Drawing.Printing

Namespace PrintWithoutDialog
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

			'Add the property PrintController to hide the print processing dialog
			printDoc.PrintController = New StandardPrintController()

			'Print the word document
			printDoc.Print()
		End Sub
	End Class
End Namespace
