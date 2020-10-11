Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ChangeCase
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a new document and load from file
			Dim input As String = "..\..\..\..\..\..\Data\Text1.docx"

			Dim doc As New Document()
			doc.LoadFromFile(input)
			Dim textRange As TextRange
			'Get the first paragraph and set its CharacterFormat to AllCaps
			Dim para1 As Paragraph = doc.Sections(0).Paragraphs(1)

			For Each obj As DocumentObject In para1.ChildObjects
				If TypeOf obj Is TextRange Then
					textRange = TryCast(obj, TextRange)
					textRange.CharacterFormat.AllCaps = True
				End If
			Next obj

			'Get the third paragraph and set its CharacterFormat to IsSmallCaps
			Dim para2 As Paragraph = doc.Sections(0).Paragraphs(3)
			For Each obj As DocumentObject In para2.ChildObjects
				If TypeOf obj Is TextRange Then
					textRange = TryCast(obj, TextRange)
					textRange.CharacterFormat.IsSmallCaps = True
				End If
			Next obj


			'Save and launch the document
			Dim output As String = "ChangeCase.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)
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
