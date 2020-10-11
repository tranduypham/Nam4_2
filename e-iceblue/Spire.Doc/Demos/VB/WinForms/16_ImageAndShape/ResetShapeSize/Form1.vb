Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ResetShapeSize
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

			'Get the first section and the first paragraph that contains the shape
			Dim section As Section = doc.Sections(0)
			Dim para As Paragraph = section.Paragraphs(0)

			'Get the second shape and reset the width and height for the shape
			Dim shape As ShapeObject = TryCast(para.ChildObjects(1), ShapeObject)
			shape.Width = 200
			shape.Height = 200

			'Save and launch document
			Dim output As String = "ResetShapeSize.docx"
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
