Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace ChangeTOCTabStyle
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load document from disk
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\Template_Toc.docx")

			'Loop through sections
			For Each section As Section In doc.Sections
				'Loop through content of section
				For Each obj As DocumentObject In section.Body.ChildObjects
					'Find the structure document tag
					If TypeOf obj Is StructureDocumentTag Then
						Dim tag As StructureDocumentTag = TryCast(obj, StructureDocumentTag)
						'Find the paragraph where the TOC1 locates
						For Each [cObj] As DocumentObject In tag.ChildObjects
							If TypeOf [cObj] Is Paragraph Then
								Dim para As Paragraph = TryCast([cObj], Paragraph)
								If para.StyleName = "TOC2" Then
									'Set the tab style of paragraph
									For Each tab As Tab In para.Format.Tabs
										tab.Position = tab.Position + 20
										tab.TabLeader = TabLeader.NoLeader
									Next tab
								End If
							End If
						Next [cObj]
					End If
				Next obj
			Next section

			'Save the Word file
			Dim output As String = "ChangeTOCTabStyle_out.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)

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
