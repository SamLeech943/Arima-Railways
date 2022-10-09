Public Class paypal
    Dim MouseLocation As Point

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown





        If e.Button = Windows.Forms.MouseButtons.Left Then MouseLocation = e.Location



    End Sub



    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove





        If e.Button = Windows.Forms.MouseButtons.Left Then





            Me.Left += e.Location.X - MouseLocation.X



            Me.Top += e.Location.Y - MouseLocation.Y



        End If
    End Sub
    Private Sub paypal_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Payment.Timer1.Start()



        ProgressBar1.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Hide()
        ProgressBar1.Show()
        Timer1.Start()


        

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
        If ProgressBar1.Value = 500 Then
            Timer1.Stop()
            Payment.Label3.Text = 0.ToString("0.00")
            Me.Hide()
            Payment.Hide()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Visible = True



        WebBrowser1.Navigate(New Uri("https://www.paypal.com/uk/signin"))
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class