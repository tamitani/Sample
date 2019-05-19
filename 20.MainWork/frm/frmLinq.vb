Imports _10.SysCommon

''' <summary>
''' 
''' </summary>
Public Class frmLinq

    Private clsOra As New ClsOracle
    Private dt As DataTable = New DataTable

    ''' <summary>
    ''' データ取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Oracle 接続
        Call clsOra.SubOracleOpen()

        ' データ取得
        Dim strSql As String = String.Empty
        Dim blnResult As Boolean = False

        strSql = "SELECT * FROM DEPT"

        ' データ取得
        blnResult = clsOra.FncOracleSelect(strSql, dt)
        If blnResult = False Then
            MessageBox.Show("取得失敗")
        End If

        ' Oracle 切断
        clsOra.SubOracleClose()


    End Sub

    ''' <summary>
    ''' LINQ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dtv As DataTable = New DataTable

        dtv = dt

        Dim query = From dtrow In dtv
                    Where dtrow("DEPTNO") = 22
                    Select dtrow

        'MessageBox.Show(query(0).Field(Of String)("DNAME"))
        MessageBox.Show(query(0).Field(Of String)("DNAME"))
        MessageBox.Show(query(0).Field(Of Int16)("DEPTNO"))

    End Sub

    ''' <summary>
    ''' 名称取得
    ''' </summary>
    ''' <param name="strNo"></param>
    ''' <param name="strName"></param>
    ''' <returns></returns>
    Private Function GetName(ByVal intNo As Integer, ByRef strName As String) As Boolean

        Dim blnResult As Boolean = False

        Try

            ' Oracle 接続
            Call clsOra.SubOracleOpen()

            ' データ取得
            Dim strSql As String = String.Empty

            strSql = "SELECT * FROM DEPT"

            ' データ取得
            blnResult = clsOra.FncOracleSelect(strSql, dt)
            If blnResult = False Then
                MessageBox.Show("取得失敗")
                Exit Try
            End If

            Dim query = From row In dt
                        Where row("DEPTNO") = intNo

            If query.Count = 0 Then
                strName = "空白"
                MessageBox.Show("データ無し")
            ElseIf query(0).Field(Of String)("DNAME") Is Nothing Then
                strName = "空白"
                MessageBox.Show("DNAME:NULL")
            Else
                strName = query(0).Field(Of String)("DNAME")
            End If

            ' Oracle 切断
            clsOra.SubOracleClose()

            ' 正常終了
            blnResult = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Return blnResult

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim blnResult As Boolean = False

        Try

            Dim intNo As Integer = 0
            Dim strName As String = String.Empty

            intNo = 22

            blnResult = Me.GetName(intNo, strName)
            If blnResult = False Then
                MessageBox.Show("取得失敗")
                Exit Try
            End If

            MessageBox.Show(strName)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class