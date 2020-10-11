Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace RemoveContentControls
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load document from disk
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\RemoveContentControls.docx")

			'Loop through sections
			For s As Integer = 0 To doc.Sections.Count - 1
				Dim section As Section = doc.Sections(s)
				Dim i As Integer = 0
				Do While i < section.Body.ChildObjects.Count
					'Loop through contents in paragraph
					If TypeOf section.Body.ChildObjects(i) Is Paragraph Then
						Dim para As Paragraph = TryCast(section.Body.ChildObjects(i), Paragraph)
						Dim j As Integer = 0
						Do While j < para.ChildObjects.Count
							'Find the StructureDocumentTagInline
							If TypeOf para.ChildObjects(j) Is StructureDocumentTagInline Then
								Dim sdt As StructureDocumentTagInline = TryCast(para.ChildObjects(j), StructureDocumentTagInline)
								'Remove the content control from paragraph
								para.ChildObjects.Remove(sdt)
								j -= 1
							End If
							j += 1
						Loop
					End If
					If TypeOf section.Body.ChildObjects(i) Is StructureDocumentTag Then
						Dim sdt As StructureDocumentTag = TryCast(section.Body.ChildObjects(i), StructureDocumentTag)
						section.Body.ChildObjects.Remove(sdt)
						i -= 1
					End If
					i += 1
				Loop
			Next s

			'Save the Word document
			Dim output As String = "RemoveContentControls_out.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)

			'Launch the file
			WordDocViewer(output)
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
