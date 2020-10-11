Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports System.Xml.XPath

Namespace FillFormField
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Open a Word document with form.
			Dim document As New Document("..\..\..\..\..\..\Data\FillFormField.doc")

			'Load data.
			Using stream As Stream = File.OpenRead("..\..\..\..\..\..\Data\User.xml")
				Dim xpathDoc As New XPathDocument(stream)
				Dim user As XPathNavigator = xpathDoc.CreateNavigator().SelectSingleNode("/user")

				'Fill data.
				For Each field As FormField In document.Sections(0).Body.FormFields
					Dim path As String = String.Format("{0}/text()", field.Name)
					Dim propertyNode As XPathNavigator = user.SelectSingleNode(path)
					If propertyNode IsNot Nothing Then
						Select Case field.Type
							Case FieldType.FieldFormTextInput
								field.Text = propertyNode.Value

							Case FieldType.FieldFormDropDown
								Dim combox As DropDownFormField = TryCast(field, DropDownFormField)
								For i As Integer = 0 To combox.DropDownItems.Count - 1
									If combox.DropDownItems(i).Text = propertyNode.Value Then
										combox.DropDownSelectedIndex = i
										Exit For
									End If
									If field.Name = "country" AndAlso combox.DropDownItems(i).Text = "Others" Then
										combox.DropDownSelectedIndex = i
									End If
								Next i

							Case FieldType.FieldFormCheckBox
								If Convert.ToBoolean(propertyNode.Value) Then
									Dim checkBox As CheckBoxFormField = TryCast(field, CheckBoxFormField)
									checkBox.Checked = True
								End If
						End Select
					End If
				Next field
			End Using

			'Save doc file.
			document.SaveToFile("Sample.doc",FileFormat.Doc)

			'Launch the Word file.
			WordDocViewer("Sample.doc")
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
