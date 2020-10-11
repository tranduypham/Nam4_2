Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace Print
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\Template.docx")
			'Print doc file.
			Dim dialog As New PrintDialog()
			dialog.AllowCurrentPage = True
			dialog.AllowSomePages = True
			dialog.UseEXDialog = True
			Try
				document.PrintDialog = dialog
				dialog.Document = document.PrintDocument
				dialog.Document.Print()
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub
	End Class
End Namespace
