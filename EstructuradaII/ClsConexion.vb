Imports System.Data.SqlClient
Public Class ClsConexion

    Public servidor As String = "Data Source=VIERNES\VIERNES;Initial Catalog=Inventario;Integrated Security=True"
    Public cnn As New SqlConnection(servidor)

    Public Sub conectar()
        Try
            If cnn.State = Data.ConnectionState.Closed Then
                cnn.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar la BD" & vbCrLf & ex.Message)
        End Try

    End Sub

    Public Sub desconectar()
        Try
            If cnn.State = Data.ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function reader(ByVal cons As String) As SqlDataReader
        Dim dr As SqlDataReader
        Try
            conectar()
            Dim cmdInstrunction As New SqlCommand(cons, cnn)
            dr = cmdInstrunction.ExecuteReader
        Catch ex As Exception
            dr = Nothing
            MsgBox(ex.Message)
        Finally
        End Try

        Return dr
    End Function

    Public Sub manipular(ByVal query As String)
        Dim comando As New SqlCommand(query, cnn)
        Try
            conectar()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try

    End Sub


    Public Function val(ByVal query As String) As Boolean
        Dim cmd As New SqlCommand
        Try
            conectar()
            cmd = New SqlCommand(query, cnn)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
