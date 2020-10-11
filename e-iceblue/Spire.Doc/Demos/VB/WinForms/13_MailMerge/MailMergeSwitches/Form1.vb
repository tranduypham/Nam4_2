Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO
Imports Spire.Doc.Fields
Imports System.Data.OleDb
Namespace MailMergeSwitches
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim input As String = "..\..\..\..\..\..\Data\MailMergeSwitches.docx"

			Dim doc As New Document()
			'Load a mail merge template file
			doc.LoadFromFile(input)

			Dim fieldName() As String = { "XX_Name" }
			Dim fieldValue() As String = { "Jason Tang" }

			doc.MailMerge.Execute(fieldName, fieldValue)
			Dim result As String = "MailMergeSwitches_out.docx"
			doc.SaveToFile(result, FileFormat.Docx)
			WordViewer(result)
		End Sub
		Private Sub WordViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
