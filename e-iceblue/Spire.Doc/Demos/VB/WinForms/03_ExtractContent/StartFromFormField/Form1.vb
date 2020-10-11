Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace StartFromFormField
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

			'Create a destination document
			Dim destinationDoc As New Document()

			'Add a section
			Dim section As Section = destinationDoc.AddSection()

			'Define a variables
			Dim index As Integer = 0

			'Traverse FormFields
			For Each field As FormField In sourceDocument.Sections(0).Body.FormFields
				'Find FieldFormTextInput type field
				If field.Type = FieldType.FieldFormTextInput Then
					'Get the paragraph
					Dim paragraph As Paragraph = field.OwnerParagraph

					'Get the index
					index = sourceDocument.Sections(0).Body.ChildObjects.IndexOf(paragraph)
					Exit For
				End If
			Next field

			'Extract the content
			For i As Integer = index To index + 3 - 1
				'Clone the ChildObjects of source document
				Dim doobj As DocumentObject = sourceDocument.Sections(0).Body.ChildObjects(i).Clone()

				'Add to destination document 
				section.Body.ChildObjects.Add(doobj)
			Next i

			'Save the document.
			destinationDoc.SaveToFile("FromFormField.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("FromFormField.docx")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
