Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO
Imports Spire.Doc.Fields
Namespace SplitDocIntoHtmlPages
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim input As String = "..\..\..\..\..\..\..\Data\SplitDocIntoHtmlPages.doc"
			Dim outDir As String = Path.Combine("output")
			Directory.CreateDirectory(outDir)

			'Split a document into multiple html pages.
			SplitDocIntoMultipleHtml(input, outDir)
		End Sub
		Private Sub SplitDocIntoMultipleHtml(ByVal input As String, ByVal outDirectory As String)
			Dim document As New Document()
			document.LoadFromFile(input)

			Dim subDoc As Document = Nothing
			Dim first As Boolean = True
			Dim index As Integer = 0
			For Each sec As Section In document.Sections
				For Each element As DocumentObject In sec.Body.ChildObjects
					If IsInNextDocument(element) Then
						If Not first Then
							'Embed css tyle and image data into html page
							subDoc.HtmlExportOptions.CssStyleSheetType = CssStyleSheetType.Internal
							subDoc.HtmlExportOptions.ImageEmbedded = True
							'Save to html file
							subDoc.SaveToFile(Path.Combine(outDirectory, String.Format("out-{0}.html", index)),FileFormat.Html)
							index += 1
							subDoc = Nothing
						End If
						first = False
					End If
					If subDoc Is Nothing Then
						subDoc = New Document()
						subDoc.AddSection()
					End If
					subDoc.Sections(0).Body.ChildObjects.Add(element.Clone())
				Next element
			Next sec
			If subDoc IsNot Nothing Then
				'Embed css tyle and image data into html page
				subDoc.HtmlExportOptions.CssStyleSheetType = CssStyleSheetType.Internal
				subDoc.HtmlExportOptions.ImageEmbedded = True
				'Save to html file
				subDoc.SaveToFile(Path.Combine(outDirectory, String.Format("out-{0}.html", index)), FileFormat.Html)
				index += 1
			End If
		End Sub
		Private Function IsInNextDocument(ByVal element As DocumentObject) As Boolean
			If TypeOf element Is Paragraph Then
				Dim p As Paragraph = TryCast(element, Paragraph)
				If p.StyleName = "Heading1" Then
					Return True
				End If
			End If
			Return False
		End Function
	End Class
End Namespace
