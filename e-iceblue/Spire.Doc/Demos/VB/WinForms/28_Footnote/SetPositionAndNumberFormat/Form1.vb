Imports Spire.Doc

Namespace SetPositionAndNumberFormat
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\Footnote.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the first section
			Dim sec As Section = doc.Sections(0)

			'Set the number format, restart rule and position for the footnote
			sec.FootnoteOptions.NumberFormat = FootnoteNumberFormat.UpperCaseLetter
			sec.FootnoteOptions.RestartRule = FootnoteRestartRule.RestartPage
			sec.FootnoteOptions.Position = FootnotePosition.PrintAsEndOfSection

			'Save and launch document
			Dim output As String = "SetPositionAndNumberFormat.docx"
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
