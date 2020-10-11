Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SetGradientBackground
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_2.docx")

			'Set the background type as Gradient.
			document.Background.Type = BackgroundType.Gradient
			Dim Test As BackgroundGradient = document.Background.Gradient

			'Set the first color and second color for Gradient.
			Test.Color1 = Color.White
			Test.Color2 = Color.LightBlue

			'Set the Shading style and Variant for the gradient.
			Test.ShadingVariant = GradientShadingVariant.ShadingDown
			Test.ShadingStyle = GradientShadingStyle.Horizontal

			Dim result As String = "Result-SetGradientBackground.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

			'Launch the MS Word file.
			WordDocViewer(result)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
