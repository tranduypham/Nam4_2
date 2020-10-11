Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace OddAndEvenHeaderFooter
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load the document
			Dim input As String = "..\..\..\..\..\..\Data\MultiplePages.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the section and
			Dim section As Section = doc.Sections(0)

			'Set the DifferentOddAndEvenPagesHeaderFooter property to ture
			section.PageSetup.DifferentOddAndEvenPagesHeaderFooter = True

			'Add odd header
			Dim P3 As Paragraph = section.HeadersFooters.OddHeader.AddParagraph()
			Dim OH As TextRange = P3.AppendText("Odd Header")
			P3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			OH.CharacterFormat.FontName = "Arial"
			OH.CharacterFormat.FontSize = 10

			'Add even header
			Dim P4 As Paragraph = section.HeadersFooters.EvenHeader.AddParagraph()
			Dim EH As TextRange = P4.AppendText("Even Header from E-iceblue Using Spire.Doc")
			P4.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			EH.CharacterFormat.FontName = "Arial"
			EH.CharacterFormat.FontSize = 10

			'Add odd footer
			Dim P2 As Paragraph = section.HeadersFooters.OddFooter.AddParagraph()
			Dim [OF] As TextRange = P2.AppendText("Odd Footer")
			P2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center
			[OF].CharacterFormat.FontName = "Arial"
			[OF].CharacterFormat.FontSize = 10

			'Add even footer
			Dim P1 As Paragraph = section.HeadersFooters.EvenFooter.AddParagraph()
			Dim EF As TextRange = P1.AppendText("Even Footer from E-iceblue Using Spire.Doc")
			EF.CharacterFormat.FontName = "Arial"
			EF.CharacterFormat.FontSize = 10
			P1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center

			'Save and launch document
			Dim output As String = "OddAndEvenHeaderFooter.docx"
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
