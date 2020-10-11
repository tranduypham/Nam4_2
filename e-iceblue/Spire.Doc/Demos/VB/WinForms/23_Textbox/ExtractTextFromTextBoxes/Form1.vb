Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports System.IO
Imports Spire.Doc.Fields

Namespace ExtractTextFromTextBoxes
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a Word document.
			Dim document As New Document()

			'Load the file from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\ExtractTextFromTextBoxes.docx")

			Dim result As String = "Result-ExtractTextFromTextBoxes.txt"

			'Verify whether the document contains a textbox or not.
			If document.TextBoxes.Count > 0 Then
				Using sw As StreamWriter = File.CreateText(result)
					'Traverse the document.
					For Each section As Section In document.Sections
						For Each p As Paragraph In section.Paragraphs
							For Each obj As DocumentObject In p.ChildObjects
								If obj.DocumentObjectType = DocumentObjectType.TextBox Then
									Dim textbox As Spire.Doc.Fields.TextBox = TryCast(obj, Spire.Doc.Fields.TextBox)
									For Each objt As DocumentObject In textbox.ChildObjects
										'Extract text from paragraph in TextBox.
										If objt.DocumentObjectType = DocumentObjectType.Paragraph Then
											sw.Write((TryCast(objt, Paragraph)).Text)
										End If

										'Extract text from Table in TextBox.
										If objt.DocumentObjectType = DocumentObjectType.Table Then
											Dim table As Table = TryCast(objt, Table)
											ExtractTextFromTables(table, sw)
										End If
									Next objt
								End If
							Next obj
						Next p
					Next section
				End Using
			End If

			'Launch the result file.
			WordDocViewer(result)
		End Sub

		'Extract text from Table .
		Private Shared Sub ExtractTextFromTables(ByVal table As Table, ByVal sw As StreamWriter)
			For i As Integer = 0 To table.Rows.Count - 1
				Dim row As TableRow = table.Rows(i)
				For j As Integer = 0 To row.Cells.Count - 1
					Dim cell As TableCell = row.Cells(j)
					For Each paragraph As Paragraph In cell.Paragraphs
						sw.Write(paragraph.Text)
					Next paragraph
				Next j
			Next i
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
