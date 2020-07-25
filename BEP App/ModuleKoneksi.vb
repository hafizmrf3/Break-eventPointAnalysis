Imports System.Data.OleDb

Module ModuleKoneksi
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public ds As DataSet
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public dt As DataTable
    Public dv As DataView
    Public dc As DataColumn

    Public Sub koneksi()
        '' acces 2007++ conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db\bep_db.accdb")

        ''conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; DataSource=" & Application.StartupPath & "\db\bep_db.accdb")
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db\bep_analysis.xlsx;Extended Properties=Excel 8.0;")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                ''MsgBox("Berhasil terkoneksi")
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module
