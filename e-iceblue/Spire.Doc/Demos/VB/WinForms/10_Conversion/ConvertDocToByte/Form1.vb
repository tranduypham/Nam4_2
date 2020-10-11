Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO

Namespace ConvertDocToByte
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim input As String = "..\..\..\..\..\..\Data\Template.docx"
			Dim doc As New Document()
			' Load the document from disk.
			doc.LoadFromFile(input)

			' Create a new memory stream.
			Dim outStream As New MemoryStream()
			' Save the document to stream.
			doc.SaveToStream(outStream, FileFormat.Docx)

			' Convert the document to bytes.
			Dim docBytes() As Byte = outStream.ToArray()

			' The bytes are now ready to be stored/transmitted.

			' Now reverse the steps to load the bytes back into a document object.
			Dim inStream As New MemoryStream(docBytes)

			' Load the stream into a new document object.
			Dim newDoc As New Document(inStream)
		End Sub
	End Class
End Namespace
