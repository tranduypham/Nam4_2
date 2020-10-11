Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO
Imports Spire.Doc.Fields
Imports System.Data.OleDb
Namespace DocAndDataBase
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim inputDataBase As String = "..\..\..\..\..\..\Data\demo.mdb"
			Dim inputFolder As String = "..\..\..\..\..\..\Data\"
			Dim fileName As String = "Template.docx"

			' Open a database connection
			Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & inputDataBase
			Dim connection As New OleDbConnection(connString)
			connection.Open()

			' Store the document to the database.
			StoreToDatabase(inputFolder & fileName, connection)
			' Read the document from the database and store the file to disk.
			Dim dbDoc As Document = ReadFromDatabase(fileName, connection)

			' Save the retrieved document to disk.
			Dim newFileName As String = "DocAndDataBase_out.docx"
			dbDoc.SaveToFile(newFileName, FileFormat.Docx)

			' Delete the document from the database.
			DeleteFromDatabase(fileName, connection)

			' Close the connection to the database.
			connection.Close()
			
			' Launching the MS Word file.
            WordDocViewer("DocAndDataBase_out.docx")
        End Sub
		'Store document to database 
		Public Shared Sub StoreToDatabase(ByVal input As String, ByVal connection As OleDbConnection)
			Dim doc As New Document(input)
			' Save the document to a MemoryStream object.
			Dim stream As New MemoryStream()
			doc.SaveToStream(stream, FileFormat.Docx)

			' Get the filename from the document.
			Dim fileName As String = Path.GetFileName(input)

			' Create the SQL command.
			Dim commandString As String = "INSERT INTO Documents (FileName, FileContent) VALUES('" & fileName & "', @Doc)"
			Dim command As New OleDbCommand(commandString, connection)

			' Add the @Doc parameter.
			command.Parameters.AddWithValue("Doc", stream.ToArray())

			' Write the document to the database.
			command.ExecuteNonQuery()
		End Sub

		' Read document from database 
		Public Shared Function ReadFromDatabase(ByVal fileName As String, ByVal mConnection As OleDbConnection) As Document
			' Create the SQL command.
			Dim commandString As String = "SELECT * FROM Documents WHERE FileName='" & fileName & "'"
			Dim command As New OleDbCommand(commandString, mConnection)

			' Create the data adapter.
			Dim adapter As New OleDbDataAdapter(command)

			' Fill the results from the database into a DataTable.
			Dim dataTable As New DataTable()
			adapter.Fill(dataTable)

			' Check whether there was a matching record found from the database and throw an exception if no record was found.
			If dataTable.Rows.Count = 0 Then
				Throw New ArgumentException(String.Format("Could not find any record matching the document ""{0}"" in the database.", fileName))
			End If

			' The document is stored in byte form in the FileContent column.
			' Retrieve these bytes of the first matching record to a new buffer.
			Dim buffer() As Byte = CType(dataTable.Rows(0)("FileContent"), Byte())

			' Wrap the bytes from the buffer into a new MemoryStream object.
			Dim newStream As New MemoryStream(buffer)

			' Read the document from the stream.
			Dim doc As New Document(newStream)

			' Return the retrieved document.
			Return doc
		End Function

        ' Delete document from database 
        Public Shared Sub DeleteFromDatabase(ByVal fileName As String, ByVal mConnection As OleDbConnection)
            ' Create the SQL command.
            Dim commandString As String = "DELETE * FROM Documents WHERE FileName='" & fileName & "'"
            Dim command As New OleDbCommand(commandString, mConnection)

            ' Delete the record.
            command.ExecuteNonQuery()

        End Sub
        Private Sub WordDocViewer(ByVal fileName As String)
            Try
                Process.Start(fileName)
            Catch
            End Try
        End Sub
    End Class
End Namespace
