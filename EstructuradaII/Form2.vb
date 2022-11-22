Public Class Form2
    Dim i As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = mensaje
        TxtNombre.Enabled = False
        BtnGuardar.Enabled = False
        Lbxregistros.Visible = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNombre.Text <> "" Then
            For i = 1 To 12
                Lbxregistros.Items.Add(TxtNombre.Text & " x " & i & " = " & Val(TxtNombre.Text) * i)
            Next

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRegistro.CheckedChanged
        If ChkRegistro.Checked = False Then
            TxtNombre.Enabled = False
            BtnGuardar.Enabled = False
            Lbxregistros.Visible = False
        Else
            TxtNombre.Enabled = True
            BtnGuardar.Enabled = True
            Lbxregistros.Visible = True
        End If
    End Sub



    Private Sub Lbxregistros_DoubleClick(sender As Object, e As EventArgs) Handles Lbxregistros.DoubleClick
        Lblretorno.Text = Lbxregistros.SelectedItem
    End Sub
End Class