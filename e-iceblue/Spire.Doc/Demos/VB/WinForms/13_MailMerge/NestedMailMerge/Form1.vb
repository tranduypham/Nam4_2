Imports System.Collections
Imports Spire.Doc

Namespace NestedMailMerage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim list As New List(Of DictionaryEntry)()
			Dim dsData As New DataSet()

			dsData.ReadXml("..\..\..\..\..\..\Data\Orders.xml")

			'Create word document
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\NestedMailMerge.doc")

			Dim dictionaryEntry As New DictionaryEntry("Customer", String.Empty)
			list.Add(dictionaryEntry)

			dictionaryEntry = New DictionaryEntry("Order", "Customer_Id = %Customer.Customer_Id%")
			list.Add(dictionaryEntry)

			document.MailMerge.ExecuteWidthNestedRegion(dsData, list)

			'Save as docx file.
			document.SaveToFile("Sample.docx", FileFormat.Docx)

			'Launching the MS Word file.
			WordDocViewer("Sample.docx")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
