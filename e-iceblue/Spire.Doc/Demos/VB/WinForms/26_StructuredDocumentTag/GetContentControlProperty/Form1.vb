Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace GetContentControlProperty
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a new document and load from file
			Dim input As String = "..\..\..\..\..\..\Data\ContentControl.docx"

			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get all structureTags in the Word document
			Dim structureTags As StructureTags = GetAllTags(doc)
			'Get all StructureDocumentTagInline objects
			Dim tagInlines As List(Of StructureDocumentTagInline) = structureTags.tagInlines
			Dim [property] As String = Nothing
			[property] &= "Alias of contentControl" & vbTab & "ID          " & vbTab & "Tag             " & vbTab & "STDType        " & vbCrLf
			'Get properties of all tagInlines
			For i As Integer = 0 To tagInlines.Count - 1
				Dim [alias] As String = tagInlines(i).SDTProperties.Alias
				Dim id As Decimal = tagInlines(i).SDTProperties.Id
				Dim tag As String = tagInlines(i).SDTProperties.Tag
				Dim STDType As String = tagInlines(i).SDTProperties.SDTType.ToString()
				[property] &= [alias] & "," & vbTab & id & "," & vbTab & tag & "," & vbTab & STDType & vbCrLf
			Next i

			'Get all StructureDocumentTag objects
			Dim tags As List(Of StructureDocumentTag) = structureTags.tags
			'Get properties of all tags
			For i As Integer = 0 To tags.Count - 1
				Dim [alias] As String = tags(i).SDTProperties.Alias
				Dim id As Decimal = tags(i).SDTProperties.Id
				Dim tag As String = tags(i).SDTProperties.Tag
				Dim STDType As String = tags(i).SDTProperties.SDTType.ToString()
				[property] &= [alias] & "," & vbTab & id & "," & vbTab & tag & "," & vbTab & STDType & vbCrLf
			Next i

			'Save the property to a text document and launch it
			Dim output As String = "Property.txt"
			File.WriteAllText(output, [property].ToString())
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

		'Get all StructureTags of the Word document
		Private Shared Function GetAllTags(ByVal document As Document) As StructureTags
			Dim structureTags As New StructureTags()
			For Each section As Section In document.Sections
				For Each obj As DocumentObject In section.Body.ChildObjects
					If obj.DocumentObjectType = DocumentObjectType.StructureDocumentTag Then
						structureTags.tags.Add(TryCast(obj, StructureDocumentTag))

					ElseIf obj.DocumentObjectType = DocumentObjectType.Paragraph Then
						For Each pobj As DocumentObject In (TryCast(obj, Paragraph)).ChildObjects
							If pobj.DocumentObjectType = DocumentObjectType.StructureDocumentTagInline Then
								structureTags.tagInlines.Add(TryCast(pobj, StructureDocumentTagInline))
							End If
						Next pobj
					ElseIf obj.DocumentObjectType = DocumentObjectType.Table Then
						For Each row As TableRow In (TryCast(obj, Table)).Rows
							For Each cell As TableCell In row.Cells
								For Each cellChild As DocumentObject In cell.ChildObjects
									If cellChild.DocumentObjectType = DocumentObjectType.StructureDocumentTag Then
										structureTags.tags.Add(TryCast(cellChild, StructureDocumentTag))
									ElseIf cellChild.DocumentObjectType = DocumentObjectType.Paragraph Then
										For Each pobj As DocumentObject In (TryCast(cellChild, Paragraph)).ChildObjects
											If pobj.DocumentObjectType = DocumentObjectType.StructureDocumentTagInline Then
												structureTags.tagInlines.Add(TryCast(pobj, StructureDocumentTagInline))
											End If
										Next pobj
									End If
								Next cellChild
							Next cell
						Next row
					End If
				Next obj
			Next section
			Return structureTags
		End Function
		Public Class StructureTags
			Private m_tagInlines As List(Of StructureDocumentTagInline)
			Public Property tagInlines() As List(Of StructureDocumentTagInline)
				Get
					If m_tagInlines Is Nothing Then
						m_tagInlines = New List(Of StructureDocumentTagInline)()
					End If
					Return m_tagInlines
				End Get
				Set(ByVal value As List(Of StructureDocumentTagInline))
					m_tagInlines = value
				End Set
			End Property
			Private m_tags As List(Of StructureDocumentTag)
			Public Property tags() As List(Of StructureDocumentTag)
				Get
					If m_tags Is Nothing Then
						m_tags = New List(Of StructureDocumentTag)()
					End If
					Return m_tags
				End Get
				Set(ByVal value As List(Of StructureDocumentTag))
					m_tags = value
				End Set
			End Property
		End Class
	End Class
End Namespace
