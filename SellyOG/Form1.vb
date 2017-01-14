Imports System.Threading
Imports System.Net
Imports System.IO
Public Class Form1

    Dim startThread As Thread
    Dim i As Integer
    Dim SF As New SaveFileDialog
    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        Using FD As New OpenFileDialog()
            FD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            If FD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Input.Items.Clear()
                Input.Items.AddRange(IO.File.ReadAllLines(FD.FileName))
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Output.Items.Clear()
        startThread = New Thread(AddressOf StartCheck)
        startThread.Start()
        Button3.Enabled = True
        Button2.Enabled = False

    End Sub

    Private Sub StartCheck()

        For i = 0 To Input.Items.Count - 1
            Dim name As String = CStr(Input.Items(i))
            Try
                Dim Request As HttpWebRequest = DirectCast(WebRequest.Create("http://selly.gg/u/" + name), HttpWebRequest)
                Dim Response As HttpWebResponse = Request.GetResponse()
                Response.Close()
            Catch ex As System.Net.WebException
                If ex.Status = 7 Then
                    Output.Items.Add(name)
                    Continue For
                End If
            End Try
        Next
        Button2.Enabled = True
        Button3.Enabled = False
        MsgBox("Finished!")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Button2.Enabled = True
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        i = Input.Items.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SF.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If SF.ShowDialog() = DialogResult.OK Then
            Using writer = New StreamWriter(SF.FileName)
                For Each o As Object In Output.Items
                    writer.WriteLine(o)
                Next
            End Using
        End If

    End Sub
End Class
