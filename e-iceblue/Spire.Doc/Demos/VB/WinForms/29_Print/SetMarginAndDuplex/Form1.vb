Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.Drawing.Printing

Namespace SetMarginAndDuplex
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

			'Set graphics origin starts at the page margins
			printDoc.OriginAtMargins = True
			'Set the margin to 0
			printDoc.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

			'Double-sided, vertical printing
			printDoc.PrinterSettings.Duplex = Duplex.Vertical
			'Double-sided, horizontal printing
			'printDoc.PrinterSettings.Duplex = Duplex.Horizontal;

			'Print the word document
			printDoc.Print()
		End Sub
	End Class
End Namespace
