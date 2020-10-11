Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.Text

Namespace AddSectionFromOtherDoc
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document as target document
			Dim TarDoc As New Document("..\..\..\..\..\..\..\Data\SampleB_1.docx")

			'Open a Word document as source document
			Dim SouDoc As New Document("..\..\..\..\..\..\..\Data\Sample_two sections.docx")

			'Get the second section from source document
			Dim Ssection As Section = SouDoc.Sections(1)

			'Add the section in target document
			TarDoc.Sections.Add(Ssection.Clone())

			Dim result As String = "result.docx"

			'Save to file
			TarDoc.SaveToFile(result, FileFormat.Docx)

			'Launch result file
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
