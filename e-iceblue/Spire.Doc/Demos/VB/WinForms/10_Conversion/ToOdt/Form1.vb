Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace ToOdt
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create word document
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\ToOdt.doc")

			'Save doc file.
			document.SaveToFile("Sample.odt", FileFormat.Odt)

			'Launching the MS Word file.
			WordDocViewer("Sample.odt")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
