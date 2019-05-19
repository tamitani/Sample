Public Class frmOya


    Public mUpdFlg As Boolean = False

    Private Shared _frmOyaInstance As frmOya

    Public Shared Property frmOyaInstance() As frmOya
        Get
            Return _frmOyaInstance
        End Get
        Set(ByVal Value As frmOya)
            _frmOyaInstance = Value
        End Set
    End Property

    ''' <summary>
    ''' コード
    ''' </summary>
    ''' <returns></returns>
    Public Property MCode() As String
        Get
            Return Me.lblCd.Text
        End Get
        Set(value As String)
            Me.lblCd.Text = value
        End Set
    End Property

    ''' <summary>
    ''' 名称
    ''' </summary>
    ''' <returns></returns>
    Public Property MName() As String
        Get
            Return Me.lblName.Text
        End Get
        Set(value As String)
            Me.lblName.Text = value
        End Set
    End Property

    ''' <summary>
    ''' 戻り
    ''' </summary>
    ''' <returns></returns>
    Public Property MUpd() As Boolean
        Get
            Return Me.mUpdFlg
        End Get
        Set(value As Boolean)
            Me.mUpdFlg = value
        End Set
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' 子画面
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click


        Dim f As New frmKo

        Me.MUpd = False

        f.ShowDialog(Me)

        If Me.MUpd = True Then
            MessageBox.Show("正常")
        Else
            MessageBox.Show("異常")
        End If

        f.Dispose()

        'Dim frm As New frmKo

        'Me.MUpd = False

        'frm.lblCd.Text = Me.mCode
        'frm.lblName.Text = Me.mName

        'frm.ShowDialog(Me)

        'If Me.MUpd = True Then
        '    MessageBox.Show("正常")
        'Else
        '    MessageBox.Show("異常")
        'End If

        'frm.Dispose()

    End Sub

    Private Sub frmOya_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    ''' <summary>
    ''' セット
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click

        Me.mCode = "00001"
        Me.mName = "大阪太郎"


    End Sub
End Class