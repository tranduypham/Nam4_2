Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO
Imports Spire.Doc.Fields
Namespace LoadAndSaveToStream
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim input As String = "..\..\..\..\..\..\Data\Template.docx"

            ' Open the stream. Read only access is enough to load a document.
            Dim stream As Stream = File.OpenRead(input)

            ' Load the entire document into memory.
            Dim doc As New Document(stream)

            ' You can close the stream now, it is no longer needed because the document is in memory.
            stream.Close()
            ' Do something with the document

            ' Convert the document to a different format and save to stream.
            Dim newStream As New MemoryStream()
            doc.SaveToStream(newStream, FileFormat.Rtf)

            ' Rewind the stream position back to zero so it is ready for the next reader.
            newStream.Position = 0

            ' Save the document from stream, to disk. Normally you would do something with the stream directly,
            ' For example, writing the data to a database.
            Dim result As String = "LoadAndSaveToStream_out.rtf"
            File.WriteAllBytes(result, newStream.ToArray())

            'Launching the MS Word file.
            WordDocViewer("LoadAndSaveToStream_out.rtf")
        End Sub
        Private Sub WordDocViewer(ByVal fileName As String)
            Try
                Process.Start(fileName)
            Catch
            End Try
        End Sub
    End Class
End Namespace
