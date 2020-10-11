Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO

Namespace PrintDocViaXpsPrint
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Using ms As New MemoryStream()
				'Create a document
				Using document As New Document()
					'Load file
					document.LoadFromFile("..\..\..\..\..\..\Data\Template.docx")
					'Save to Xps file
					document.SaveToStream(ms, FileFormat.XPS)
				End Using
				ms.Position = 0
				Dim printerName As String = "HP LaserJet P1007"
				XpsPrint.XpsPrintHelper.Print(ms, printerName, "My printing job", True)
			End Using
		End Sub
	End Class
End Namespace
