Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ConvertFieldToBodyText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create the source document
			Dim sourceDocument As New Document()

			'Load the source document from disk.
			sourceDocument.LoadFromFile("..\..\..\..\..\..\Data\TextInputField.docx")

			'Traverse FormFields
			For Each field As FormField In sourceDocument.Sections(0).Body.FormFields
				'Find FieldFormTextInput type field
				If field.Type = FieldType.FieldFormTextInput Then
					'Get the paragraph
					Dim paragraph As Paragraph = field.OwnerParagraph

					'Define variables
					Dim startIndex As Integer = 0
					Dim endIndex As Integer = 0

					'Create a new TextRange
					Dim textRange As New TextRange(sourceDocument)

					'Set text for textRange
					textRange.Text = paragraph.Text

					'Traverse DocumentObjectS of field paragraph
					For Each obj As DocumentObject In paragraph.ChildObjects
						'If its DocumentObjectType is BookmarkStart
						If obj.DocumentObjectType = DocumentObjectType.BookmarkStart Then
							'Get the index
							startIndex = paragraph.ChildObjects.IndexOf(obj)
						End If
						'If its DocumentObjectType is BookmarkEnd
						If obj.DocumentObjectType = DocumentObjectType.BookmarkEnd Then
							'Get the index
							endIndex = paragraph.ChildObjects.IndexOf(obj)
						End If
					Next obj
					'Remove ChildObjects
					For i As Integer = endIndex To startIndex + 1 Step -1
						'If it is TextFormField
						If TypeOf paragraph.ChildObjects(i) Is TextFormField Then
							Dim textFormField As TextFormField = TryCast(paragraph.ChildObjects(i), TextFormField)

							'Remove the field object
							paragraph.ChildObjects.Remove(textFormField)
						Else
							paragraph.ChildObjects.RemoveAt(i)
						End If
					Next i
					'Insert the new TextRange
					paragraph.ChildObjects.Insert(startIndex, textRange)
					Exit For
				End If

			Next field
			'Save the document.
			sourceDocument.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
