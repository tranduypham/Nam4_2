Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace Text
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Initialize a document
			Dim document As New Document()
			'Add a section
			Dim sec As Section = document.AddSection()
			'Add paragraph and set list style
			Dim paragraph As Paragraph = sec.AddParagraph()
			paragraph.AppendText("Lists")
			paragraph.ApplyStyle(BuiltinStyle.Title)

			paragraph = sec.AddParagraph()
			paragraph.AppendText("Numbered List:").CharacterFormat.Bold = True

			'Create list style
			Dim numberList As New ListStyle(document, ListType.Numbered)
			numberList.Name = "numberList"
			numberList.Levels(1).NumberPrefix=ChrW(&H0000).ToString() & "."
			numberList.Levels(1).PatternType = ListPatternType.Arabic
			numberList.Levels(2).NumberPrefix = ChrW(&H0000).ToString() & "." & ChrW(&H0001).ToString() & "."
			numberList.Levels(2).PatternType = ListPatternType.Arabic

			Dim bulletList As New ListStyle(document, ListType.Bulleted)
			bulletList.Name = "bulletList"

			'add the list style into document
			document.ListStyles.Add(numberList)
			document.ListStyles.Add(bulletList)

			'Add paragraph and apply the list style
			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 1")
			paragraph.ListFormat.ApplyStyle(numberList.Name)

			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2")
			paragraph.ListFormat.ApplyStyle(numberList.Name)

			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2.1")
			paragraph.ListFormat.ApplyStyle(numberList.Name)
			paragraph.ListFormat.ListLevelNumber = 1

			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2.2")
			paragraph.ListFormat.ApplyStyle(numberList.Name)
			paragraph.ListFormat.ListLevelNumber = 1

			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2.2.1")
			paragraph.ListFormat.ApplyStyle(numberList.Name)
			paragraph.ListFormat.ListLevelNumber = 2
			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2.2.2")
			paragraph.ListFormat.ApplyStyle(numberList.Name)
			paragraph.ListFormat.ListLevelNumber = 2
			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2.2.3")
			paragraph.ListFormat.ApplyStyle(numberList.Name)
			paragraph.ListFormat.ListLevelNumber = 2

			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2.3")
			paragraph.ListFormat.ApplyStyle(numberList.Name)
			paragraph.ListFormat.ListLevelNumber = 1

			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 3")
			paragraph.ListFormat.ApplyStyle(numberList.Name)

			paragraph = sec.AddParagraph()
			paragraph.AppendText("Bulleted List:").CharacterFormat.Bold = True

			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 1")
			paragraph.ListFormat.ApplyStyle(bulletList.Name)
			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2")
			paragraph.ListFormat.ApplyStyle(bulletList.Name)

			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2.1")
			paragraph.ListFormat.ApplyStyle(bulletList.Name)
			paragraph.ListFormat.ListLevelNumber = 1
			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 2.2")
			paragraph.ListFormat.ApplyStyle(bulletList.Name)
			paragraph.ListFormat.ListLevelNumber = 1
			paragraph = sec.AddParagraph()
			paragraph.AppendText("List Item 3")
			paragraph.ListFormat.ApplyStyle(bulletList.Name)

			'Save doc file.
			Dim filePath As String = "Lists.docx"
			document.SaveToFile(filePath, FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer(filePath)


		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
