Public Class frmHikisuSub

    Public SeizoCode As String = String.Empty
    Public SeizoRev As String = String.Empty
    Public ShiyoCode As String = String.Empty

    ''' <summary>
    ''' 閉じる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    Private Sub frmHikisuSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 親からの引数
        MessageBox.Show("SeizoCode:" & SeizoCode)
        MessageBox.Show("SeizoRev:" & SeizoRev)
        MessageBox.Show("ShiyoCode:" & ShiyoCode)

        If SeizoCode <> String.Empty Then
            Me.Label11.Text = SeizoCode
            Me.Label12.Text = SeizoRev
            Me.Label13.Text = ShiyoCode
        End If



    End Sub
End Class