Public Class Payment
    Dim MouseLocation As Point
    Dim new_total As Double
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown





        If e.Button = Windows.Forms.MouseButtons.Left Then MouseLocation = e.Location



    End Sub



    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove





        If e.Button = Windows.Forms.MouseButtons.Left Then





            Me.Left += e.Location.X - MouseLocation.X



            Me.Top += e.Location.Y - MouseLocation.Y



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        amount.Label6.Text = new_total
        Me.Label3.Text = new_total.ToString("0.00")
        

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        credit.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        paypal.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = new_total.ToString("0.00")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class