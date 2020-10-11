Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections
Imports System.Text

Namespace GetFieldText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim sb As New StringBuilder()

			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\SampleB_1.docx")

			'Get all fields in document
			Dim fields As FieldCollection = document.Fields

			For Each field As Field In fields
				'Get field text
				Dim fieldText As String = field.FieldText
				sb.Append("The field text is """ & fieldText & """." & vbCrLf)
			Next field

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
