Imports System.IO
Imports System.Xml.XPath
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ModifyPageSetupOfSection
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Word from disk
			Dim doc As New Document()
			doc.LoadFromFile("../../../../../../Data/Template_N2.docx")

			'Loop through all sections
			For Each section As Section In doc.Sections
				'Modify the margins
				section.PageSetup.Margins = New MarginsF(100, 80, 100, 80)
				'Modify the page size
				section.PageSetup.PageSize = PageSize.Letter
			Next section

			' Or only modify one section
			' For example, modify the page setup of the first section
			'Section section0 = doc.Sections[0];
			'section0.PageSetup.Margins = new MarginsF(100, 80, 100, 80);
			'section0.PageSetup.FooterDistance = 35.4f;
			'section0.PageSetup.HeaderDistance = 34.4f;

			'Save the Word file
			Dim output As String = "ModifyPageSetupOfAllSections_out.docx"
			doc.SaveToFile(output,FileFormat.Docx2013)

			'Launch the file
			WordDocViewer(output)
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
