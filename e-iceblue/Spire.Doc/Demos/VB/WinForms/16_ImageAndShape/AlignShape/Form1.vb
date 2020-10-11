Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace AlignShape
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Document
			Dim input As String = "..\..\..\..\..\..\Data\Shapes.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			Dim section As Section = doc.Sections(0)

			For Each para As Paragraph In section.Paragraphs
				For Each obj As DocumentObject In para.ChildObjects
					If TypeOf obj Is ShapeObject Then
						'Set the horizontal alignment as center
						TryCast(obj, ShapeObject).HorizontalAlignment = ShapeHorizontalAlignment.Center

						'//Set the vertical alignment as top
						'(obj as ShapeObject).VerticalAlignment = ShapeVerticalAlignment.Top;
					End If
				Next obj
			Next para

			'Save and launch document
			Dim output As String = "AlignShape.docx"
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
