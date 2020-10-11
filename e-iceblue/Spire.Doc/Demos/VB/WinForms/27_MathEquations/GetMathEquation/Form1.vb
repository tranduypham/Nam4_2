Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Fields.OMath
Imports Spire.Doc.Documents
Imports System.IO
Namespace GetMathEquation
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\GetMathEquation.docx")
			Dim mathEquations As New List(Of OfficeMath)()
			Dim stringBuilder As New StringBuilder()
			For Each section As Section In doc.Sections
				For Each paragraph As Paragraph In section.Paragraphs
					For Each obj As DocumentObject In paragraph.ChildObjects
						If TypeOf obj Is OfficeMath Then
							stringBuilder.AppendLine((TryCast(obj, OfficeMath)).ToMathMLCode())
							stringBuilder.AppendLine()
							mathEquations.Add(TryCast(obj, OfficeMath))
						End If
					Next obj

				Next paragraph
			Next section
			Dim output As String ="MathMLCode.txt"
			File.WriteAllText(output, stringBuilder.ToString())
			WordDocViewer(output)
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
