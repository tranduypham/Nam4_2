Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports System.IO

Namespace ExtractOLE
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create document and load file from disk
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\OLEs.docx")

			'Traverse through all sections of the word document    
			For Each sec As Section In doc.Sections
				'Traverse through all Child Objects in the body of each section
				For Each obj As DocumentObject In sec.Body.ChildObjects
					'find the paragraph
					If TypeOf obj Is Paragraph Then
						Dim par As Paragraph = TryCast(obj, Paragraph)
						For Each o As DocumentObject In par.ChildObjects
							'check whether the object is OLE
							If o.DocumentObjectType = DocumentObjectType.OleObject Then
								Dim Ole As DocOleObject = TryCast(o, DocOleObject)
								Dim s As String = Ole.ObjectType

								'check whether the object type is "Acrobat.Document.11"
								If s = "AcroExch.Document.DC" Then
									'write the data of OLE into file
									File.WriteAllBytes("Result.pdf", Ole.NativeData)
									FileViewer("Result.pdf")

								'check whether the object type is "Excel.Sheet.8"
								ElseIf s = "Excel.Sheet.8" Then
									File.WriteAllBytes("ExcelResult.xls", Ole.NativeData)
									FileViewer("ExcelResult.xls")

								'check whether the object type is "PowerPoint.Show.12"
								ElseIf s = "PowerPoint.Show.12" Then
									File.WriteAllBytes("PPTResult.pptx", Ole.NativeData)
									FileViewer("PPTResult.pptx")
								End If
							End If
						Next o
					End If
				Next obj
			Next sec
		End Sub
		Private Sub FileViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
