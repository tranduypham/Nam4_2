Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace AddCheckBoxContentControl
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
			Dim txtRange As TextRange = paragraph.AppendText("The following example shows how to add CheckBox content control in a Word document. " & vbLf)

			'Append textRange 
			txtRange = paragraph.AppendText("Add CheckBox Content Control:  ")

			'Set the font format
			txtRange.CharacterFormat.Italic = True

			'Create StructureDocumentTagInline for document
			Dim sdt As New StructureDocumentTagInline(document)

			'Add sdt in paragraph
			paragraph.ChildObjects.Add(sdt)

			'Specify the type
			sdt.SDTProperties.SDTType = SdtType.CheckBox

			'Set properties for control
			Dim scb As New SdtCheckBox()
			sdt.SDTProperties.ControlProperties = scb

			'Add textRange format
			Dim tr As New TextRange(document)
			tr.CharacterFormat.FontName = "MS Gothic"
			tr.CharacterFormat.FontSize = 12

			'Add textRange to StructureDocumentTagInline
			sdt.ChildObjects.Add(tr)

			'Set checkBox as checked
			scb.Checked = True

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
