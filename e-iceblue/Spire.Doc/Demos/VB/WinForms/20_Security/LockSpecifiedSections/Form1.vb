Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace LockSpecifiedSections
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create Word document.
			Dim document As New Document()

			'Add new sections.
			Dim s1 As Section = document.AddSection()
			Dim s2 As Section = document.AddSection()

			'Append some text to section 1 and section 2.
			s1.AddParagraph().AppendText("Spire.Doc demo, section 1")
			s2.AddParagraph().AppendText("Spire.Doc demo, section 2")

			'Protect the document with AllowOnlyFormFields protection type.
			document.Protect(ProtectionType.AllowOnlyFormFields, "123")

			'Unprotect section 2
			s2.ProtectForm = False

			Dim result As String = "Result-LockSpecifiedSections.docx"

			'Save to file.
			document.SaveToFile(result, FileFormat.Docx2013)

			'Launch the file.
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
