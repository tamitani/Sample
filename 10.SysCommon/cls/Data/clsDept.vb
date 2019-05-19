Public Class clsDept

    Public Property DEPTNO As String

    Public Property DNAME As String

    Public Property LOC As String

End Class

Public Class clsFrmDept

    Dim tbl As New clsDept

    Public Function PSelect(ByVal tbl) As Boolean

        Dim blnResult As Boolean = False

        Try

        Catch ex As Exception

        End Try

        Return blnResult

    End Function


End Class
