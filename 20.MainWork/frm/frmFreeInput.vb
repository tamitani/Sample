Option Strict On
Option Explicit On

Imports _01.Common

''' <summary>
''' 登録画面
''' 
'''   Create: 2019/05/11 H.Tamitani
''' 
''' </summary>
Public Class frmFreeInput
    Inherits _10.SysCommon.frmBaseForm

#Region "定数"

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
    '''   Create: 2019/05/11 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmFreeInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' グリッド　初期化
        initGrid()

    End Sub

    ''' <summary>
    ''' 登録サブ画面　呼び出し
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFrmSubInput_Click(sender As Object, e As EventArgs) Handles btnFrmSubInput.Click

        Try

            Dim frm As New frmFreeSubInput

            frm.txtKanriCd.Text = Me.lblKanriCdNm.Text
            frm.txtKanriName.Text = Me.lblKanriNameNm.Text

            frm.cmbHantei.Items.Clear()
            frm.cmbHantei.Items.Add("ＮＧ")
            frm.cmbHantei.Items.Add("ＯＫ")
            frm.cmbHantei.Items.Add("ＳＤ")
            frm.cmbHantei.Text = ""
            frm.cmbHantei.SelectionLength = 0

            frm.ShowDialog(Me)
            frm.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, clsConst.msbbOk, clsConst.msbiExc)

        End Try

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
    ''' フォーム　キーダウン
    ''' 
    '''   Create: 2019/05/12 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmFreeInput_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If

    End Sub

    ''' <summary>
    ''' 検索ボタン　クリック
    ''' 
    '''   Create: 2019/05/12 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

#End Region

#Region "メソッド"

    ''' <summary>
    ''' グリッド初期化
    ''' </summary>
    Private Sub initGrid()

    End Sub

#End Region

End Class
