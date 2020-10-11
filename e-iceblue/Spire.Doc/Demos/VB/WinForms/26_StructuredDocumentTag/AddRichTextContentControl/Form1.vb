Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace AddRichTextContentControl
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()

			'Add a new section.
			Dim section As Section = document.AddSection()

			'Add a paragraph
			Dim paragraph As Paragraph = section.AddParagraph()

			'Append textRange for the paragraph
			Dim txtRange As TextRange = paragraph.AppendText("The following example shows how to add RichText content control in a Word document. " & vbLf)

			'Append textRange 
			txtRange = paragraph.AppendText("Add RichText Content Control:  ")

			'Set the font format
			txtRange.CharacterFormat.Italic = True

			'Create StructureDocumentTagInline for document
			Dim sdt As New StructureDocumentTagInline(document)

			'Add sdt in paragraph
			paragraph.ChildObjects.Add(sdt)

			'Specify the type
			sdt.SDTProperties.SDTType = SdtType.RichText

			'Set displaying text
			Dim text As New SdtText(True)
			text.IsMultiline = True
			sdt.SDTProperties.ControlProperties = text

			'Crate a TextRange
			Dim rt As New TextRange(document)
			rt.Text = "Welcome to use "
			rt.CharacterFormat.TextColor = Color.Green
			sdt.SDTContent.ChildObjects.Add(rt)

			rt = New TextRange(document)
			rt.Text = "Spire.Doc"
			rt.CharacterFormat.TextColor = Color.OrangeRed
			sdt.SDTContent.ChildObjects.Add(rt)

			'Save the document.
			document.SaveToFile("Output.docx", FileFormat.Docx)

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
