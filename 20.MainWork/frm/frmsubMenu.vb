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
End Class