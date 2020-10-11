Imports System.Text
Imports System.IO
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ReplaceWithHtml
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim HTML As String = File.ReadAllText("..\..\..\..\..\..\Data\InputHtml1.txt")

			'Load the document from disk.  
			Dim document As New Document("..\..\..\..\..\..\Data\ReplaceWithHtml.docx")

			'collect the objects which is used to replace text
			Dim replacement As New List(Of DocumentObject)()

			'create a temporary section
			Dim tempSection As Section = document.AddSection()

			'add a paragraph to append html
			Dim par As Paragraph = tempSection.AddParagraph()
			par.AppendHTML(HTML)

			'get the objects in temporary section
			For Each obj As DocumentObject In tempSection.Body.ChildObjects
				Dim docObj As DocumentObject = TryCast(obj, DocumentObject)
				replacement.Add(docObj)
			Next obj

			'Find all text which will be replaced.
			Dim selections() As TextSelection = document.FindAllString("[#placeholder]", False, True)

			Dim locations As New List(Of TextRangeLocation)()
			For Each selection As TextSelection In selections
				locations.Add(New TextRangeLocation(selection.GetAsOneRange()))
			Next selection
			locations.Sort()

			For Each location As TextRangeLocation In locations
				'replace the text with HTML
				ReplaceWithHTML(location, replacement)
			Next location

			'remove the temp section
			document.Sections.Remove(tempSection)

			'Save the document.
			document.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub

		Private Shared Sub ReplaceWithHTML(ByVal location As TextRangeLocation, ByVal replacement As List(Of DocumentObject))
			Dim textRange As TextRange = location.Text

			'textRange index
			Dim index As Integer = location.Index

			'get owener paragraph
			Dim paragraph As Paragraph = location.Owner

			'get owner text body
			Dim sectionBody As Body = paragraph.OwnerTextBody

			'get the index of paragraph in section
			Dim paragraphIndex As Integer = sectionBody.ChildObjects.IndexOf(paragraph)

			Dim replacementIndex As Integer = -1
			If index = 0 Then
				'remove the first child object
				paragraph.ChildObjects.RemoveAt(0)

				replacementIndex = sectionBody.ChildObjects.IndexOf(paragraph)
			ElseIf index = paragraph.ChildObjects.Count - 1 Then
				paragraph.ChildObjects.RemoveAt(index)
				replacementIndex = paragraphIndex + 1
			Else
				'split owner paragraph
				Dim paragraph1 As Paragraph = CType(paragraph.Clone(), Paragraph)
				Do While paragraph.ChildObjects.Count > index
					paragraph.ChildObjects.RemoveAt(index)
				Loop
				Dim i As Integer = 0
				Dim count As Integer = index + 1
				Do While i < count
					paragraph1.ChildObjects.RemoveAt(0)
					i += 1
				Loop
				sectionBody.ChildObjects.Insert(paragraphIndex + 1, paragraph1)

				replacementIndex = paragraphIndex + 1
			End If

			'insert replacement
			For i As Integer = 0 To replacement.Count - 1
				sectionBody.ChildObjects.Insert(replacementIndex + i, replacement(i).Clone())
			Next i
		End Sub

		Public Class TextRangeLocation
			Implements IComparable(Of TextRangeLocation)
			Public Sub New(ByVal text As TextRange)
				Me.Text = text
			End Sub

			Public Property Text() As TextRange
				Get
					Return m_Text
				End Get
				Set(ByVal value As TextRange)
					m_Text = value
				End Set
			End Property

			Private m_Text As TextRange
			Public ReadOnly Property Owner() As Paragraph
				Get
					Return Me.Text.OwnerParagraph
				End Get
			End Property

			Public ReadOnly Property Index() As Integer
				Get
					Return Me.Owner.ChildObjects.IndexOf(Me.Text)
				End Get
			End Property

			Public Function CompareTo(ByVal other As TextRangeLocation) As Integer Implements IComparable(Of TextRangeLocation).CompareTo
				Return -(Me.Index - other.Index)
			End Function
		End Class

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
