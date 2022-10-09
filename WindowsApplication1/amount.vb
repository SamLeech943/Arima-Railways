Public Class amount
    Dim anum, cnum, snum, number, total As Double
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub amount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cnum += 1.7
        Label9.Text = cnum.ToString("0.00")
        total = anum + cnum + snum

        Label6.Text = total.ToString("0.00")
        Payment.Label3.Text = total.ToString("0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        anum += 3.2
        Label8.Text = anum.ToString("0.00")

        total = anum + cnum + snum

        Label6.Text = total.ToString("0.00")
        Payment.Label3.Text = total.ToString("0.00")





    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        snum += 2.0
        Label10.Text = snum.ToString("0.00")
        total = anum + cnum + snum

        Label6.Text = total.ToString("0.00")
        Payment.Label3.Text = total.ToString("0.00")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If anum < 1.6 Then
			anum = 0                   'anum = adult number this can be added or subtracted

		Else
            anum -= 3.2

        End If


		Label8.Text = anum.ToString("0.00")                                     'displays number to two decimal places
		total = anum + cnum + snum                                      'adds all sub totals together and displays in the total box

		Label6.Text = total.ToString("0.00")
        Payment.Label3.Text = total.ToString("0.00")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

		If cnum < 1.6 Then
			cnum = 0

		Else                                           'cnum = child number this can be added or subtracted
			cnum -= 1.7

        End If


        Label9.Text = cnum.ToString("0.00")
		total = anum + cnum + snum                                            'adds all sub totals together and displays in the total box

		Label6.Text = total.ToString("0.00")
        Payment.Label3.Text = total.ToString("0.00")
    End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		Me.Hide()
		Home.Show()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

		If snum < 1.3 Or snum < 1.8 Then
			snum = 0

		Else
			snum -= 2.0                                 'snum = senior number this can be added or subtracted

		End If


		Label10.Text = snum.ToString("0.00")
		total = anum + cnum + snum                          'adds all sub totals together and displays in the total box

		Label6.Text = total.ToString("0.00")
		Payment.Label3.Text = total.ToString("0.00")
	End Sub

	Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Payment.Show()
        Payment.Label3.Text = total.ToString("0.00")
    End Sub
End Class