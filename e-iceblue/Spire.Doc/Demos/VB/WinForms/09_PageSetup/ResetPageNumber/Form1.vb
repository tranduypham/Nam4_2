Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ResetPageNumber
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create three Word documents and load three different Word documents from disk.
			Dim document1 As New Document()
			document1.LoadFromFile("..\..\..\..\..\..\Data\ResetPageNumber1.docx")

			Dim document2 As New Document()
			document2.LoadFromFile("..\..\..\..\..\..\Data\ResetPageNumber2.docx")

			Dim document3 As New Document()
			document3.LoadFromFile("..\..\..\..\..\..\Data\ResetPageNumber3.docx")

			'Use section method to combine all documents into one word document.
			For Each sec As Section In document2.Sections
				document1.Sections.Add(sec.Clone())
			Next sec
			For Each sec As Section In document3.Sections
				document1.Sections.Add(sec.Clone())
			Next sec

			'Traverse every section of document1.
			For Each sec As Section In document1.Sections
				'Traverse every object of the footer.
				For Each obj As DocumentObject In sec.HeadersFooters.Footer.ChildObjects
					If obj.DocumentObjectType = DocumentObjectType.StructureDocumentTag Then
						Dim para As DocumentObject = obj.ChildObjects(0)
						For Each item As DocumentObject In para.ChildObjects
							If item.DocumentObjectType = DocumentObjectType.Field Then
								'Find the item and its field type is FieldNumPages.
								If (TryCast(item, Field)).Type = FieldType.FieldNumPages Then
									'Change field type to FieldSectionPages.
									TryCast(item, Field).Type = FieldType.FieldSectionPages
								End If
							End If
						Next item
					End If
				Next obj
			Next sec

			'Restart page number of section and set the starting page number to 1.
			document1.Sections(1).PageSetup.RestartPageNumbering = True
			document1.Sections(1).PageSetup.PageStartingNumber = 1

			document1.Sections(2).PageSetup.RestartPageNumbering = True
			document1.Sections(2).PageSetup.PageStartingNumber = 1

			Dim result As String = "Result-ResetPageNumber.docx"

			'Save to file.
			document1.SaveToFile(result, FileFormat.Docx2013)

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
