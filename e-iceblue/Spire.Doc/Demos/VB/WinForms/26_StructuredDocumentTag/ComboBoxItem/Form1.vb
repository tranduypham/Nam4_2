Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace ComboBoxItem
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a new document and load from file
			Dim input As String = "..\..\..\..\..\..\Data\ComboBox.docx"
			Dim doc As New Document()
			doc.LoadFromFile(input)

			'Get the combo box from the file
			For Each section As Section In doc.Sections
				For Each bodyObj As DocumentObject In section.Body.ChildObjects
					If bodyObj.DocumentObjectType = DocumentObjectType.StructureDocumentTag Then
						'If SDTType is ComboBox
						If (TryCast(bodyObj, StructureDocumentTag)).SDTProperties.SDTType = SdtType.ComboBox Then
							Dim combo As SdtComboBox = TryCast((TryCast(bodyObj, StructureDocumentTag)).SDTProperties.ControlProperties, SdtComboBox)
							'Remove the second list item
							combo.ListItems.RemoveAt(1)
							'Add a new item
							Dim item As New SdtListItem("D", "D")
							combo.ListItems.Add(item)

							'If the value of list items is "D"
							For Each sdtItem As SdtListItem In combo.ListItems
								If String.CompareOrdinal(sdtItem.Value, "D") = 0 Then
									'Select the item
									combo.ListItems.SelectedValue = sdtItem
								End If
							Next sdtItem
						End If
					End If
				Next bodyObj
			Next section

			'Save the document and launch it
			Dim output As String = "ComboBoxItem.docx"
			doc.SaveToFile(output, FileFormat.Docx2013)
			Viewer(output)
		End Sub
		Private Sub Viewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
