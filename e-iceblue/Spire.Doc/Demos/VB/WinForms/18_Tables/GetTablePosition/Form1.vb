Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO

Namespace GetTablePosition
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()
			'Load file
			document.LoadFromFile("..\..\..\..\..\..\Data\TableSample-Az.docx")
			'Get the first section
			Dim section As Section = document.Sections(0)
			'Get the first table
			Dim table As Table = TryCast(section.Tables(0), Table)

			Dim stringBuidler As New StringBuilder()

			'Verify whether the table uses "Around" text wrapping or not.
			If table.TableFormat.WrapTextAround Then
				Dim positon As RowFormat.TablePositioning = table.TableFormat.Positioning

				stringBuidler.AppendLine("Horizontal:")
				stringBuidler.AppendLine("Position:" & positon.HorizPosition & " pt")
				stringBuidler.AppendLine("Absolute Position:" & positon.HorizPositionAbs & ", Relative to:" & positon.HorizRelationTo)
				stringBuidler.AppendLine()
				stringBuidler.AppendLine("Vertical:")
				stringBuidler.AppendLine("Position:" & positon.VertPosition & " pt")
				stringBuidler.AppendLine("Absolute Position:" & positon.VertPositionAbs & ", Relative to:" & positon.VertRelationTo)
				stringBuidler.AppendLine()
				stringBuidler.AppendLine("Distance from surrounding text:")
				stringBuidler.AppendLine("Top:" & positon.DistanceFromTop & " pt, Left:" & positon.DistanceFromLeft & " pt")
				stringBuidler.AppendLine("Bottom:" & positon.DistanceFromBottom & "pt, Right:" & positon.DistanceFromRight & " pt")
			End If


			Dim result As String = "GetTablePosition_out.txt"

			'Save file.
			File.WriteAllText(result, stringBuidler.ToString())
			'Launching the Word file.
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
