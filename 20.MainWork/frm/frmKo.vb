Public Class frmKo

    ''' <summary>
    ''' 閉じる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' OK
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click


        'Dim frm As New frmOya

        CType(Me.Owner, frmOya).MUpd = True

        Me.Close()


    End Sub

    Private Sub frmKo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Dim strCode As String = CType(Me.Owner, frmOya).lblCd.Text
        'Dim strName As String = CType(Me.Owner, frmOya).lblName.Text

        'Me.lblCd.Text = strCode
        'Me.lblName.Text = strName

        Me.lblCd.Text = CType(Me.Owner, frmOya).MCode
        Me.lblName.Text = CType(Me.Owner, frmOya).MName

    End Sub
End Class