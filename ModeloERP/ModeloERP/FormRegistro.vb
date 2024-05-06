Public Class FormRegistro


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
        Form1.PictureBox1.Visible = True
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonSave.Click
        MsgBox("Cliente registrado")
        Form1.PictureBox1.Visible = True
        Close()

    End Sub
End Class