Public Class frmHikisuMain

    Public Property SeizoCode As String
        Get
            Return Me.Label1.Text
        End Get
        Set(value As String)
            Me.Label1.Text = value
        End Set
    End Property

    Public Property SeizoRev As String
        Get
            Return Me.Label2.Text
        End Get
        Set(value As String)
            Me.Label2.Text = value
        End Set
    End Property

    Public Property ShiyoCode As String
        Get
            Return Me.Label3.Text
        End Get
        Set(value As String)
            Me.Label3.Text = value
        End Set
    End Property

    ''' <summary>
    ''' セット
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.SeizoCode = "12345"
        Me.SeizoRev = "67"

        Me.ShiyoCode = "8901"


    End Sub

    ''' <summary>
    ''' 閉じる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' 呼び出し
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' 呼び出し
        Dim frm As New frmHikisuSub()

        frm.SeizoCode = Me.SeizoCode
        frm.SeizoRev = Me.SeizoRev
        frm.ShiyoCode = Me.ShiyoCode

        'frm.Owner = Me

        frm.Show()

        'frm.Dispose()

    End Sub
End Class