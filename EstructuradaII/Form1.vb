Imports System.Data.SqlClient
Public Class Form1
    Dim query As String
    Dim con As New ClsConexion
    Dim dv As New DataView
    Dim dr As SqlDataReader
    Dim holamundo As Integer

    Public Sub limpiar()
        TxtId.Text = ""
        TxtProducto.Text = ""
        TxtCantidad.Text = ""
        TxtModelo.Text = ""
    End Sub
    Public Sub cargar()
        query = "select * from Vista_Producto"
        If con.val(query) = True Then
            Dim da As New SqlDataAdapter(query, con.cnn)
            Dim ds As New DataSet
            With DataGridView1
                .MultiSelect = False 'no permite selecciones multiples
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv

        Else
            MsgBox("No hay registros")
        End If
    End Sub

    Public Sub cargarcombo()
        query = "select Id_Tipo, Desc_Tipo from Tipo"
        Dim da As New SqlDataAdapter(query, con.cnn)

        Dim dt As DataTable = New DataTable()
        con.conectar()
        da.Fill(dt)

        With CmbTipo
            .DataSource = dt
            .DisplayMember = "Desc_Tipo"
            .ValueMember = "Id_Tipo"
        End With
        con.desconectar()
        da = Nothing
    End Sub

    Public Sub autonum()
        query = "select * from Producto"
        If con.val(query) = True Then
            query = "select MAX(Id_Producto )from Producto"
            dr = con.reader(query)
            While dr.Read
                TxtId.Text = dr.GetValue(0) + 1
            End While
            dr.Close()

        Else
            TxtId.Text = 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
        cargarcombo()
        autonum()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        query = "insert into Producto values(" & TxtId.Text & ",'" & TxtProducto.Text & "', " & TxtCantidad.Text & ", '" & CmbMarca.Text & "','" & TxtModelo.Text & "'," & CmbTipo.SelectedValue & ",1)"
        con.manipular(query)
        MsgBox("Registro Almacenado correctamente")
        cargar()
        limpiar()
        autonum()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        query = "UPDATE Producto  SET Nom_Producto = '" & TxtProducto.Text & "',Can_Producto = " & TxtCantidad.Text & ",Modelo = '" & TxtModelo.Text & "',Marca = '" & CmbMarca.Text & "' ,Id_Tipo = " & CmbTipo.SelectedValue & "  WHERE Id_Producto = " & TxtId.Text
        con.manipular(query)
        MsgBox("Registro Modificado correctamente")
        cargar()
        limpiar()
        autonum()
    End Sub



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TxtId.Text = DataGridView1.CurrentRow.Cells(0).Value
        TxtProducto.Text = DataGridView1.CurrentRow.Cells(1).Value
        TxtCantidad.Text = DataGridView1.CurrentRow.Cells(2).Value
        CmbMarca.Text = DataGridView1.CurrentRow.Cells(3).Value
        TxtModelo.Text = DataGridView1.CurrentRow.Cells(4).Value
        CmbTipo.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub
End Class
