Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SplitDocByPageBreak
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim original As New Document()

			'Load the file from disk.
			original.LoadFromFile("..\..\..\..\..\..\..\Data\SplitWordFileByPageBreak.docx")

			'Create a new word document and add a section to it.
			Dim newWord As New Document()
			Dim section As Section = newWord.AddSection()
			original.CloneDefaultStyleTo(newWord)
			original.CloneThemesTo(newWord)
			original.CloneCompatibilityTo(newWord)

			'Split the original word document into separate documents according to page break.
			Dim index As Integer = 0

			'Traverse through all sections of original document.
			For Each sec As Section In original.Sections
				'Traverse through all body child objects of each section.
				For Each obj As DocumentObject In sec.Body.ChildObjects
					If TypeOf obj Is Paragraph Then
						Dim para As Paragraph = TryCast(obj, Paragraph)
						sec.CloneSectionPropertiesTo(section)
						'Add paragraph object in original section into section of new document.
						section.Body.ChildObjects.Add(para.Clone())

						For Each parobj As DocumentObject In para.ChildObjects
							If TypeOf parobj Is Break AndAlso (TryCast(parobj, Break)).BreakType = BreakType.PageBreak Then
								'Get the index of page break in paragraph.
								Dim i As Integer = para.ChildObjects.IndexOf(parobj)

								'Remove the page break from its paragraph.
								section.Body.LastParagraph.ChildObjects.RemoveAt(i)

								'Save the new document to a Docx file.
								newWord.SaveToFile(String.Format("Result-SplitWordFileByPageBreak-{0}.docx", index), FileFormat.Docx)
								index += 1

								'Create a new document and add a section.
								newWord = New Document()
								section = newWord.AddSection()
								original.CloneDefaultStyleTo(newWord)
								original.CloneThemesTo(newWord)
								original.CloneCompatibilityTo(newWord)
								sec.CloneSectionPropertiesTo(section)
								'Add paragraph object in original section into section of new document.
								section.Body.ChildObjects.Add(para.Clone())
								If section.Paragraphs(0).ChildObjects.Count = 0 Then
									'Remove the first blank paragraph.
									section.Body.ChildObjects.RemoveAt(0)
								Else
									'Remove the child objects before the page break.
									Do While i >= 0
										section.Paragraphs(0).ChildObjects.RemoveAt(i)
										i -= 1
									Loop
								End If
							End If
						Next parobj
					End If
					If TypeOf obj Is Table Then
						'Add table object in original section into section of new document.
						section.Body.ChildObjects.Add(obj.Clone())
					End If
				Next obj
			Next sec

			'Save to file.
			Dim result As String = String.Format("Result-SplitWordFileByPageBreak-{0}.docx", index)
			newWord.SaveToFile(result, FileFormat.Docx2013)

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
