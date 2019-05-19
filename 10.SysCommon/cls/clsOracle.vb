Option Strict On

Imports Oracle.DataAccess.Client

Public Class ClsOracle

    ' オラクル　クラス
    Public con As OracleConnection = New OracleConnection()

    ''' <summary>
    ''' オラクル　接続
    ''' </summary>
    Public Sub SubOracleOpen()

        Try

            ' スキーマー、パスワード、接続文字列　取得
            con.ConnectionString = My.Settings.conDataSource

            ' 接続
            con.Open()

        Catch ex As Exception
            '例外を再スローする
            Throw ex

        End Try

    End Sub

    ''' <summary>
    ''' オラクル　切断
    ''' </summary>
    Public Sub SubOracleClose()

        Try

            ' 切断
            con.Close()
            con.Dispose()
            con = Nothing

        Catch ex As Exception
            '例外を再スローする
            Throw ex

        End Try

    End Sub

    ''' <summary>
    ''' データ抽出(Select)
    ''' </summary>
    ''' <param name="strSql">Sql文</param>
    ''' <param name="dt">データテーブル</param>
    ''' <returns>True:正常 False:異常</returns>
    Public Function FncOracleSelect(strSql As String, dt As DataTable) As Boolean

        Try

            'データの取得
            Dim cmd As OracleCommand = New OracleCommand(strSql, con)
            Dim da As OracleDataAdapter = New OracleDataAdapter(cmd)

            da.Fill(dt)

            Return True

        Catch ex As Exception
            '例外を再スローする
            Throw ex

            Return False

        End Try

    End Function

    ''' <summary>
    ''' Sql発行
    ''' </summary>
    ''' <param name="strSql"></param>
    Public Sub SubOracleExecute(ByVal strSql As String)

        ' トランザクション開始
        Dim txn As OracleTransaction = con.BeginTransaction

        Try

            Dim cmd As OracleCommand = New OracleCommand(strSql, con)

            ' SQLの実行
            cmd.ExecuteNonQuery()

            ' コミット
            txn.Commit()

        Catch ex As Exception
            ' ロールバック
            txn.Rollback()

            '例外を再スローする
            Throw ex

        End Try

    End Sub

    ''' <summary>
    ''' ＰＬＳＱＬ実行
    ''' </summary>
    ''' <returns></returns>
    Public Function FncOraclePlSql() As String

        Try

            Dim cmd As OracleCommand = New OracleCommand

            cmd.Connection = con

            ' コマンドタイプをストアドプロシージャにする
            cmd.CommandType = CommandType.StoredProcedure

            ' 実行するストアドプロシージャを指定
            cmd.CommandText = "FUNCTION_TEST"

            ' ストアドファンクションの戻り値パラメータ作成
            Dim retVal As New OracleParameter("retVal", OracleDbType.Decimal)
            retVal.Direction = ParameterDirection.ReturnValue
            cmd.Parameters.Add(retVal)

            ' ストアドファンクションの引数１パラメータ作成
            Dim p1 As OracleParameter = New OracleParameter
            p1.ParameterName = "inParameter1"
            p1.OracleDbType = OracleDbType.Date
            p1.Direction = ParameterDirection.Input
            p1.Value = Now.Date
            cmd.Parameters.Add(p1)

            'ストアドファンクションの引数２パラメータ作成
            Dim p2 As OracleParameter = New OracleParameter
            p2.ParameterName = "inParameter2"
            p2.OracleDbType = OracleDbType.Varchar2
            p2.Direction = ParameterDirection.Input
            p2.Size = 20
            p2.Value = "TEST2"
            cmd.Parameters.Add(p2)

            'ストアドファンクションの引数３パラメータ作成
            Dim p3 As OracleParameter = New OracleParameter
            p3.ParameterName = "outParameter1"
            p3.OracleDbType = OracleDbType.Varchar2
            p3.Direction = ParameterDirection.Output
            p3.Size = 20
            cmd.Parameters.Add(p3)

            cmd.ExecuteNonQuery()

            'Debug.Print(cmd.Parameters("outParameter1").Value.ToString())
            Debug.WriteLine(cmd.Parameters("outParameter1").Value.ToString())

            Return cmd.Parameters("outParameter1").Value.ToString()

        Catch ex As Exception
            '例外を再スローする
            Throw ex
        End Try


    End Function

End Class
