Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace GetMergeFieldName
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim sb As New StringBuilder()

			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\MailMerge.doc")

			'Get merge field name
			Dim fieldNames() As String = document.MailMerge.GetMergeFieldNames()

			sb.Append("The document has " & fieldNames.Length.ToString() & " merge fields.")
			sb.Append(" The below is the name of the merge field:" & vbCrLf)
			For Each name As String In fieldNames
				sb.AppendLine(name)
			Next name

			File.WriteAllText("result.txt", sb.ToString())

			'Launch result file
			WordDocViewer("result.txt")

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
