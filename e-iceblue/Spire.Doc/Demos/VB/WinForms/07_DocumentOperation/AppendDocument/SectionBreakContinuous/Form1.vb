Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.Text

Namespace SectionBreakContinuous
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

			'Open a Word document
			Dim doc As New Document("..\..\..\..\..\..\..\Data\Sample_two sections.docx")

			For Each section As Section In doc.Sections
				'Set section break as continuous
				section.BreakCode = SectionBreakType.NoBreak
			Next section

			doc.SaveToFile("result.docx")

			'Launch result file
			WordDocViewer("result.docx")

		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
