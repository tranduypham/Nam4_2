Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace FromParagraphToTable
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create the first document
			Dim sourceDocument As New Document()

			'Load the source document from disk.
			sourceDocument.LoadFromFile("..\..\..\..\..\..\Data\IncludingTable.docx")

			'Create a destination document
			Dim destinationDoc As New Document()

			'Add a section
			Dim destinationSection As Section = destinationDoc.AddSection()

			'Extract the content from the first paragraph to the first table
			ExtractByTable(sourceDocument, destinationDoc, 1, 1)

			'Save the document.
			destinationDoc.SaveToFile("Output.docx", FileFormat.Docx)

			'Launch the Word file.
			WordDocViewer("Output.docx")
		End Sub

		Private Shared Sub ExtractByTable(ByVal sourceDocument As Document, ByVal destinationDocument As Document, ByVal startPara As Integer, ByVal tableNo As Integer)
			'Get the table from the source document
			Dim table As Table = TryCast(sourceDocument.Sections(0).Tables(tableNo - 1), Table)

			'Get the table index
			Dim index As Integer = sourceDocument.Sections(0).Body.ChildObjects.IndexOf(table)
			For i As Integer = startPara - 1 To index
				'Clone the ChildObjects of source document
				Dim doobj As DocumentObject = sourceDocument.Sections(0).Body.ChildObjects(i).Clone()

				'Add to destination document 
				destinationDocument.Sections(0).Body.ChildObjects.Add(doobj)
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
