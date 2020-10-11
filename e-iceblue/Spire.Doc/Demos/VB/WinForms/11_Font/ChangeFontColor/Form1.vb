Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ChangeFontColor
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\Sample.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the first section and first paragraph
			Dim section As Section = doc.Sections(0)
			Dim p1 As Paragraph = section.Paragraphs(0)

			'Iterate through the childObjects of the paragraph 1 
			For Each childObj As DocumentObject In p1.ChildObjects
				If TypeOf childObj Is TextRange Then
					'Change text color
					Dim tr As TextRange = TryCast(childObj, TextRange)
					tr.CharacterFormat.TextColor = Color.RosyBrown
				End If
			Next childObj

			'Get the second paragraph
			Dim p2 As Paragraph = section.Paragraphs(1)

			'Iterate through the childObjects of the paragraph 2
			For Each childObj As DocumentObject In p2.ChildObjects
				If TypeOf childObj Is TextRange Then
					'Change text color
					Dim tr As TextRange = TryCast(childObj, TextRange)
					tr.CharacterFormat.TextColor = Color.DarkGreen
				End If
			Next childObj

			'Save and launch document
			Dim output As String = "ChangeFontColor.docx"
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
