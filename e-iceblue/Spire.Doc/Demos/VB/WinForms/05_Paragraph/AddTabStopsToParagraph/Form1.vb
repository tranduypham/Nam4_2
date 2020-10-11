Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace AddTabStopsToParagraph
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Add a section.
			Dim section As Section = document.AddSection()

			'Add paragraph 1.
			Dim paragraph1 As Paragraph = section.AddParagraph()

			'Add tab and set its position (in points).
			Dim tab As Tab = paragraph1.Format.Tabs.AddTab(28)

			'Set tab alignment.
			tab.Justification = TabJustification.Left

			'Move to next tab and append text.
			paragraph1.AppendText(vbTab & "Washing Machine")

			'Add another tab and set its position (in points).
			tab = paragraph1.Format.Tabs.AddTab(280)

			'Set tab alignment.
			tab.Justification = TabJustification.Left

			'Specify tab leader type.
			tab.TabLeader = TabLeader.Dotted

			'Move to next tab and append text.
			paragraph1.AppendText(vbTab & "$650")

			'Add paragraph 2.
			Dim paragraph2 As Paragraph = section.AddParagraph()

			'Add tab and set its position (in points).
			tab = paragraph2.Format.Tabs.AddTab(28)

			'Set tab alignment.
			tab.Justification = TabJustification.Left

			'Move to next tab and append text.
			paragraph2.AppendText(vbTab & "Refrigerator")

			'Add another tab and set its position (in points).
			tab = paragraph2.Format.Tabs.AddTab(280)

			'Set tab alignment.
			tab.Justification = TabJustification.Left

			'Specify tab leader type.
			tab.TabLeader = TabLeader.NoLeader

			'Move to next tab and append text.
			paragraph2.AppendText(vbTab & "$800")

			Dim result As String = "Result-AddTabStopsToParagraph.docx"

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
