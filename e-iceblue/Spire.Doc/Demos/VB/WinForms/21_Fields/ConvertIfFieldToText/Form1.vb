Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Collections

Namespace ConvertIfFieldToText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document
			Dim document As New Document("..\..\..\..\..\..\Data\IfFieldSample.docx")


			'Get all fields in document
			Dim fields As FieldCollection = document.Fields

			For i As Integer = 0 To fields.Count - 1
				Dim field As Field = fields(i)
				If field.Type = FieldType.FieldIf Then
					Dim original As TextRange = TryCast(field, TextRange)
					'Get field text
					Dim text As String = field.FieldText
					'Create a new textRange and set its format
					Dim textRange As New TextRange(document)
					textRange.Text = text
					textRange.CharacterFormat.FontName = original.CharacterFormat.FontName
					textRange.CharacterFormat.FontSize = original.CharacterFormat.FontSize

					Dim par As Paragraph = field.OwnerParagraph
					'Get the index of the if field
					Dim index As Integer = par.ChildObjects.IndexOf(field)
					'Remove if field via index
					par.ChildObjects.RemoveAt(index)
					'Insert field text at the position of if field
					par.ChildObjects.Insert(index, textRange)
				End If

			Next i

			Dim result As String ="result.docx"
			'Save doc file
			document.SaveToFile(result, FileFormat.Docx)

			'Launch the Word file
			WordDocViewer(result)

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
