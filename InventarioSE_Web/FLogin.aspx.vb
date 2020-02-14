Public Class FLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If inputRut.Value = "153486735" And inputPassword.Value = "123456" Then
            Response.Write("http://www.google.cl")
        End If
    End Sub
End Class