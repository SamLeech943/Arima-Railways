Public Class Form1
    Dim MouseLocation As Point
   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown





        If e.Button = Windows.Forms.MouseButtons.Left Then MouseLocation = e.Location



    End Sub



    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove





        If e.Button = Windows.Forms.MouseButtons.Left Then





            Me.Left += e.Location.X - MouseLocation.X



            Me.Top += e.Location.Y - MouseLocation.Y



        End If

    End Sub




End Class
