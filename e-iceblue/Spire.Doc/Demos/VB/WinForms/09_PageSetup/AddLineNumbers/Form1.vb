Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace AddLineNumbers
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\Template_Docx_1.docx")

			'Set the start value of the line numbers.
			document.Sections(0).PageSetup.LineNumberingStartValue = 1

			'Set the interval between displayed numbers.
			document.Sections(0).PageSetup.LineNumberingStep = 6

			'Set the distance between line numbers and text.
			document.Sections(0).PageSetup.LineNumberingDistanceFromText = 40f

			'Set the numbering mode of line numbers. There are four choices: None, Continuous, RestartPage and RestartSection.
			document.Sections(0).PageSetup.LineNumberingRestartMode = LineNumberingRestartMode.Continuous

			Dim result As String = "Result-AddLineNumbers.docx"

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
