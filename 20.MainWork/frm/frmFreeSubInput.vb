Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports _01.Common
Imports _10.SysCommon

''' <summary>
''' 登録サブ画面
''' 
'''   Create: 2019/05/12 H.Tamitani
''' 
''' 
''' </summary>
Public Class frmFreeSubInput
    Inherits _10.SysCommon.frmBaseForm

#Region "変数"

    Private clsConst As New clsConst

#End Region

#Region "イベント"

    ''' <summary>
    ''' Ｎｅｗ
    ''' 
    '''   Create: 2019/05/12 H.Tamitani
    ''' 
    ''' </summary>
    Public Sub New()

        MyBase.New()
        InitializeComponent()

    End Sub

    ''' <summary>
    ''' フォームロード
    ''' 
    '''   Create: 2019/05/12 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmFreeSubInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ActiveControl = Me.cmbHantei

    End Sub

    ''' <summary>
    ''' 閉じるボタン　クリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Try

            ' 閉じる
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, clsConst.msbbOk, clsConst.msbiExc)

        End Try

    End Sub

    ''' <summary>
    ''' 登録ボタン　クリック
    ''' 
    '''   Create: 2019/05/12 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Try

            ' 登録


            ' 閉じる

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, clsConst.msbbOk, clsConst.msbiExc)

        End Try

    End Sub

    ''' <summary>
    ''' 管理コード　Validating
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtKanriCd_Validating(sender As Object, e As CancelEventArgs) Handles txtKanriCd.Validating

        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, clsConst.msbbOk, clsConst.msbiExc)
        End Try

    End Sub

    ''' <summary>
    ''' フォーム　キーダウン
    ''' 
    '''   Create: 2019/05/12 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmFreeSubInput_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If

    End Sub

#End Region

#Region "メソッド"
#End Region

End Class