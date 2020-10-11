Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO

Namespace CheckFileFormat
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			   Dim input As String = "..\..\..\..\..\..\Data\Template.docx"

			   Dim doc As New Document()
			   doc.LoadFromFile(input)
			  'Get file format
			   Dim ff As FileFormat = doc.DetectedFormatType
			   Dim fileFormat As String ="The file format is "
			   'Check the format info
			   Select Case ff
                Case Spire.Doc.FileFormat.Doc
                    fileFormat &= "Microsoft Word 97-2003 document."
                Case Spire.Doc.FileFormat.Dot
                    fileFormat &= "Microsoft Word 97-2003 template."
                Case Spire.Doc.FileFormat.Docx
                    fileFormat &= "Office Open XML WordprocessingML Macro-Free Document."
                Case Spire.Doc.FileFormat.Docm
                    fileFormat &= "Office Open XML WordprocessingML Macro-Enabled Document."
                Case Spire.Doc.FileFormat.Dotx
                    fileFormat &= "Office Open XML WordprocessingML Macro-Free Template."
                Case Spire.Doc.FileFormat.Dotm
                    fileFormat &= "Office Open XML WordprocessingML Macro-Enabled Template."
                Case Spire.Doc.FileFormat.Rtf
                    fileFormat &= "RTF format."
                Case Spire.Doc.FileFormat.WordML
                    fileFormat &= "Microsoft Word 2003 WordprocessingML format."
                Case Spire.Doc.FileFormat.Html
                    fileFormat &= "HTML format."
                Case Spire.Doc.FileFormat.WordXml
                    fileFormat &= "Microsoft Word xml format for word 2007-2013."
                Case Spire.Doc.FileFormat.Odt
                    fileFormat &= "OpenDocument Text."
                Case Spire.Doc.FileFormat.Ott
                    fileFormat &= "OpenDocument Text Template."
                Case Spire.Doc.FileFormat.DocPre97
                    fileFormat &= "Microsoft Word 6 or Word 95 format."
				   Case Else
						fileFormat &="Unknown format."
			   End Select
			   MessageBox.Show(fileFormat)
		End Sub
	End Class
End Namespace
