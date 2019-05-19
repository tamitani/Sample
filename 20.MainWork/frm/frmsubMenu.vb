Option Strict On
Option Explicit On

Imports _01.Common

''' <summary>
''' サブメニュー
''' 
'''  Create: 2019/05/11 H.Tamitani
''' 
''' </summary>
Public Class frmSubMenu

    Private clsConst As New clsConst

    ''' <summary>
    ''' 登録画面➀
    ''' 
    '''   Create: 2019/05/11 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFreeInput_Click(sender As Object, e As EventArgs) Handles btnFreeInput.Click

        Try

            Dim frm As New frmFreeInput

            ' 画面表示
            Me.Hide()
            frm.ShowDialog()
            Me.Show()
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, clsConst.msbbOk, clsConst.msbiExc)

        End Try

    End Sub

    ''' <summary>
    ''' フォームロード
    ''' 
    '''   Create: 2019/05/11 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim frm As New frmOya

            ' 画面表示
            Me.Hide()
            frm.ShowDialog()
            Me.Show()
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, clsConst.msbbOk, clsConst.msbiExc)

        End Try

    End Sub

    ''' <summary>
    ''' frmList
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            Dim frm As New frmList

            ' 画面表示
            Me.Hide()
            frm.ShowDialog()
            Me.Show()
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, clsConst.msbbOk, clsConst.msbiExc)

        End Try

    End Sub

    ''' <summary>
    ''' frmLinq
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim frm As New frmLinq

        ' 画面表示
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
        frm.Dispose()

    End Sub

    ''' <summary>
    ''' frmList
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim frm As New frmList

        ' 画面表示
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
        frm.Dispose()

    End Sub

    ''' <summary>
    ''' 別フォーム(引数)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim frm As New frmHikisuMain

        ' 画面表示
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
        frm.Dispose()

    End Sub
End Class