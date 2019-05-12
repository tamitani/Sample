Option Strict On
Option Explicit On

''' <summary>
''' コンボボックス　クラス
''' 
'''   Create: 2019/05/12 H.Tamitani
''' 
''' </summary>
Public Class clsComboBoxPlus
    Inherits System.Windows.Forms.ComboBox

#Region "定数"
    Private _BackColorOrg As System.Drawing.Color
    Private _ReadOnly As Boolean
#End Region

#Region "Public Property"
    ''' <summary>
    ''' (Property)ＲｅａｄＯｎｌｙ
    ''' </summary>
    ''' <returns></returns>
    Public Property [ReadOnly]() As Boolean

        Get
            Return _ReadOnly
        End Get

        Set(ByVal Value As Boolean)
            _ReadOnly = Value
            If Value Then
                BackColor = System.Drawing.SystemColors.Control
                SetStyle(ControlStyles.UserMouse, True)
            Else
                BackColor = _BackColorOrg
                SetStyle(ControlStyles.UserMouse, False)
            End If
        End Set

    End Property
#End Region

#Region "Public Sub"

    ''' <summary>
    ''' Ｎｅｗ
    ''' 
    '''   Create: 2019/05/12 H.Tamitani
    ''' 
    ''' </summary>
    Public Sub New()
        MyBase.New()
        _BackColorOrg = BackColor
    End Sub

#End Region

#Region "Protected Overrides Sub"

    ''' <summary>
    ''' (Overrides)キーダウン
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If _ReadOnly Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' (Overrides)キーアップ
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)

        If _ReadOnly Then
            e.Handled = True
        End If

    End Sub

    ''' <summary>
    ''' (Overrides)キープレス
    ''' 
    '''   Create: 2019/05/12 H.Tamitani
    ''' 
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If _ReadOnly Then
            e.Handled = True
        End If

    End Sub

#End Region

End Class
