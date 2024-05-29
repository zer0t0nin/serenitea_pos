
Public Class LoginMod
    

    Private Sub LoginMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openServer()

    End Sub

    Public Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call retrieveRecord("SELECT AcctUsername, AcctPassword FROM LoginQuery WHERE AcctUsername = '" & txtUsername.Text & "' AND AcctPassword = '" & txtPassword.Text & "'")
        Dim Uname As String


        If ds.Tables("a").Rows.Count > 0 Then
            MsgBox("Succesfully logged in!")


            Uname = txtUsername.Text
            MainMod.Show()

            Me.Hide()

        Else
            MsgBox("Invalid username and password!")

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub chkPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkPass.Checked
    End Sub
End Class