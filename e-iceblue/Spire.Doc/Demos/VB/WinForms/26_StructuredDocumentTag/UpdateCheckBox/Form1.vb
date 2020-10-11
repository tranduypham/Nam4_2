Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace UpdateCheckBox
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()

			'Load the document from disk.
			document.LoadFromFile("..\..\..\..\..\..\Data\CheckBoxContentControl.docx")

			'Call StructureTags
			Dim structureTags As StructureTags = GetAllTags(document)

			'Create list 
			Dim tagInlines As List(Of StructureDocumentTagInline) = structureTags.tagInlines

			'Get the controls
			For i As Integer = 0 To tagInlines.Count - 1
				'Get the type
				Dim type As String = tagInlines(i).SDTProperties.SDTType.ToString()

				'Update the status
				If type = "CheckBox" Then
					Dim scb As SdtCheckBox = TryCast(tagInlines(i).SDTProperties.ControlProperties, SdtCheckBox)
					If scb.Checked Then
						scb.Checked = False
					Else
						scb.Checked = True
					End If
				End If

			Next i
			'Save the document.
			document.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")

		End Sub

		Private Shared Function GetAllTags(ByVal document As Document) As StructureTags

			'Create StructureTags
			Dim structureTags As New StructureTags()

			'Travel document sections
			For Each section As Section In document.Sections
				For Each obj As DocumentObject In section.Body.ChildObjects
					'Travel document paragraphs
					If obj.DocumentObjectType = DocumentObjectType.Paragraph Then
						For Each pobj As DocumentObject In (TryCast(obj, Paragraph)).ChildObjects
							'Get StructureDocumentTagInline
							If pobj.DocumentObjectType = DocumentObjectType.StructureDocumentTagInline Then
								structureTags.tagInlines.Add(TryCast(pobj, StructureDocumentTagInline))
							End If
						Next pobj
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
		End Class
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
