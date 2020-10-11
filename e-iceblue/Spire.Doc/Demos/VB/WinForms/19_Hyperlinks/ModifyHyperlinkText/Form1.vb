Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ModifyHyperlinkText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Document
			Dim input As String = "..\..\..\..\..\..\Data\Hyperlinks.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Find all hyperlinks in the Word document
			Dim hyperlinks As New List(Of Field)()
			For Each section As Section In doc.Sections
				For Each sec As DocumentObject In section.Body.ChildObjects
					If sec.DocumentObjectType = DocumentObjectType.Paragraph Then
						For Each para As DocumentObject In (TryCast(sec, Paragraph)).ChildObjects
							If para.DocumentObjectType = DocumentObjectType.Field Then
								Dim field As Field = TryCast(para, Field)

								If field.Type = FieldType.FieldHyperlink Then
									hyperlinks.Add(field)
								End If
							End If
						Next para
					End If
				Next sec
			Next section

			'Reset the property of hyperlinks[0].FieldText by using the index of the hyperlink
			hyperlinks(0).FieldText = "Spire.Doc component"

			'Save and launch document
			Dim output As String = "ModifyText.docx"
			doc.SaveToFile(output, FileFormat.Docx)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
