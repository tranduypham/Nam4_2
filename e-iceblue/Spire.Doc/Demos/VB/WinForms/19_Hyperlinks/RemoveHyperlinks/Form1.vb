Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace RemoveHyperlinks
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

			'Get all hyperlinks
			Dim hyperlinks As List(Of Field) = FindAllHyperlinks(doc)

			'Flatten all hyperlinks
			For i As Integer = hyperlinks.Count - 1 To 0 Step -1
				FlattenHyperlinks(hyperlinks(i))
			Next i

			'Save and launch document
			Dim output As String = "RemoveHyperlinks.docx"
			doc.SaveToFile(output, FileFormat.Docx)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

		'Create a method FindAllHyperlinks() to get all the hyperlinks from the sample document
		Private Function FindAllHyperlinks(ByVal document As Document) As List(Of Field)
			Dim hyperlinks As New List(Of Field)()
			'Iterate through the items in the sections to find all hyperlinks
			For Each section As Section In document.Sections
				For Each sec As DocumentObject In section.Body.ChildObjects
					If sec.DocumentObjectType = DocumentObjectType.Paragraph Then
						For Each para As DocumentObject In (TryCast(sec, Paragraph)).ChildObjects
							If para.DocumentObjectType = DocumentObjectType.Field Then
								Dim field As Field = TryCast(para, Field)
								If field.Type = FieldType.FieldHyperlink Then
									hyperlinks.Add(field)
								End If
							End If
						Next para
					End If
				Next sec
			Next section
			Return hyperlinks
		End Function

		' Flatten the hyperlink field
		Private Sub FlattenHyperlinks(ByVal field As Field)
			Dim ownerParaIndex As Integer = field.OwnerParagraph.OwnerTextBody.ChildObjects.IndexOf(field.OwnerParagraph)
			Dim fieldIndex As Integer = field.OwnerParagraph.ChildObjects.IndexOf(field)
			Dim sepOwnerPara As Paragraph = field.Separator.OwnerParagraph
			Dim sepOwnerParaIndex As Integer = field.Separator.OwnerParagraph.OwnerTextBody.ChildObjects.IndexOf(field.Separator.OwnerParagraph)
			Dim sepIndex As Integer = field.Separator.OwnerParagraph.ChildObjects.IndexOf(field.Separator)
			Dim endIndex As Integer = field.End.OwnerParagraph.ChildObjects.IndexOf(field.End)
			Dim endOwnerParaIndex As Integer = field.End.OwnerParagraph.OwnerTextBody.ChildObjects.IndexOf(field.End.OwnerParagraph)

			FormatFieldResultText(field.Separator.OwnerParagraph.OwnerTextBody, sepOwnerParaIndex, endOwnerParaIndex, sepIndex, endIndex)

			field.End.OwnerParagraph.ChildObjects.RemoveAt(endIndex)

			For i As Integer = sepOwnerParaIndex To ownerParaIndex Step -1
				If i = sepOwnerParaIndex AndAlso i = ownerParaIndex Then
					For j As Integer = sepIndex To fieldIndex Step -1
						field.OwnerParagraph.ChildObjects.RemoveAt(j)

					Next j
				ElseIf i = ownerParaIndex Then
					For j As Integer = field.OwnerParagraph.ChildObjects.Count - 1 To fieldIndex Step -1
						field.OwnerParagraph.ChildObjects.RemoveAt(j)
					Next j

				ElseIf i = sepOwnerParaIndex Then
					For j As Integer = sepIndex To 0 Step -1
						sepOwnerPara.ChildObjects.RemoveAt(j)
					Next j
				Else
					field.OwnerParagraph.OwnerTextBody.ChildObjects.RemoveAt(i)
				End If
			Next i
		End Sub

		'Remove the font color and underline format of the hyperlinks
		Private Sub FormatFieldResultText(ByVal ownerBody As Body, ByVal sepOwnerParaIndex As Integer, ByVal endOwnerParaIndex As Integer, ByVal sepIndex As Integer, ByVal endIndex As Integer)
			For i As Integer = sepOwnerParaIndex To endOwnerParaIndex
				Dim para As Paragraph = TryCast(ownerBody.ChildObjects(i), Paragraph)
				If i = sepOwnerParaIndex AndAlso i = endOwnerParaIndex Then
					For j As Integer = sepIndex + 1 To endIndex - 1
						FormatText(TryCast(para.ChildObjects(j), TextRange))
					Next j

				ElseIf i = sepOwnerParaIndex Then
					For j As Integer = sepIndex + 1 To para.ChildObjects.Count - 1
						FormatText(TryCast(para.ChildObjects(j), TextRange))
					Next j
				ElseIf i = endOwnerParaIndex Then
					For j As Integer = 0 To endIndex - 1
						FormatText(TryCast(para.ChildObjects(j), TextRange))
					Next j
				Else
					For j As Integer = 0 To para.ChildObjects.Count - 1
						FormatText(TryCast(para.ChildObjects(j), TextRange))
					Next j
				End If
			Next i
		End Sub
		Private Sub FormatText(ByVal tr As TextRange)
			'Set the text color to black
			tr.CharacterFormat.TextColor = Color.Black
			'Set the text underline style to none
			tr.CharacterFormat.UnderlineStyle = UnderlineStyle.None
		End Sub
	End Class
End Namespace
