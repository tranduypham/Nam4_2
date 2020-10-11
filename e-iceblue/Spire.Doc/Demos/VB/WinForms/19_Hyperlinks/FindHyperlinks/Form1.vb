Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace FindHyperlinks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Document
			Dim input As String = "..\..\..\..\..\..\Data\Hyperlinks.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Create a hyperlink list
			Dim hyperlinks As New List(Of Field)()
			Dim hyperlinksText As String = Nothing
			'Iterate through the items in the sections to find all hyperlinks
			For Each section As Section In doc.Sections
				For Each sec As DocumentObject In section.Body.ChildObjects
					If sec.DocumentObjectType = DocumentObjectType.Paragraph Then
						For Each para As DocumentObject In (TryCast(sec, Paragraph)).ChildObjects
							If para.DocumentObjectType = DocumentObjectType.Field Then
								Dim field As Field = TryCast(para, Field)
								If field.Type = FieldType.FieldHyperlink Then
									hyperlinks.Add(field)
									'Get the hyperlink text
									hyperlinksText &= field.FieldText & vbCrLf
								End If
							End If
						Next para
					End If
				Next sec
			Next section

			'Save the text of all hyperlinks to TXT File and launch it
			Dim output As String = "HyperlinksText.txt"
			File.WriteAllText(output, hyperlinksText)
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
