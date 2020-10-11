Imports System.Drawing.Imaging
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields
Imports Spire.Doc.Interface

Namespace ExtractImage
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            'open document
            Dim document As New Document("..\..\..\..\..\..\Data\Template.docx")

            'document elements, each of them has child elements
            Dim nodes As New Queue(Of ICompositeObject)()
            nodes.Enqueue(document)

            'embedded images list.
            Dim images As IList(Of Image) = New List(Of Image)()

            'traverse
            Do While nodes.Count > 0
                Dim node As ICompositeObject = nodes.Dequeue()
                For Each child As IDocumentObject In node.ChildObjects
                    If TypeOf child Is ICompositeObject Then
                        nodes.Enqueue(TryCast(child, ICompositeObject))

                        If child.DocumentObjectType = DocumentObjectType.Picture Then
                            Dim picture As DocPicture = TryCast(child, DocPicture)
                            images.Add(picture.Image)
                        End If
                    End If
                Next child
            Loop
            'save images
            For i As Integer = 0 To images.Count - 1
                Dim fileName As String = String.Format("Image-{0}.png", i)
                images(i).Save(fileName, ImageFormat.Png)
            Next i

            If images.Count > 0 Then
                'show the first image
                Process.Start("Image-0.png")
            End If
        End Sub

    End Class
End Namespace
