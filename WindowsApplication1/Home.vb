Public Class Home

    Dim MouseLocation As Point
    Dim location1 As String
    Dim time1 As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Button2.Enabled = False
        ComboBox3.Enabled = False


        Me.Top = (Me.Height \ 2)
        Me.Left = (Me.Width \ 2)
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        
        location1 = ComboBox1.Text


        If ComboBox1.Text.Contains("Manchester") Then
            ComboBox3.Enabled = True
        ElseIf ComboBox1.Text.Contains("Middleton") Then
            ComboBox3.Enabled = True
        ElseIf ComboBox1.Text.Contains("Ashton-Under-Lyne") Then    'adds different cities to he lising 
            ComboBox3.Enabled = True
        ElseIf ComboBox1.Text.Contains("Bury") Then
            ComboBox3.Enabled = True
        ElseIf ComboBox1.Text.Contains("Rochdale") Then
            ComboBox3.Enabled = True
        ElseIf ComboBox1.Text.Contains("Oldham") Then
            ComboBox3.Enabled = True

        End If


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        time1 = ComboBox3.Text


        If ComboBox3.Text.Contains("8:20") Then
            Button2.Enabled = True
        ElseIf ComboBox3.Text.Contains("9:10") Then
            Button2.Enabled = True
        ElseIf ComboBox3.Text.Contains("10:15") Then
            Button2.Enabled = True
        ElseIf ComboBox3.Text.Contains("11:10") Then       'adds different times to the lisings
            Button2.Enabled = True
        ElseIf ComboBox3.Text.Contains("12:20") Then
            Button2.Enabled = True
        ElseIf ComboBox3.Text.Contains("13:30") Then
            Button2.Enabled = True
        ElseIf ComboBox3.Text.Contains("14:00") Then
            Button2.Enabled = True
        ElseIf ComboBox3.Text.Contains("15:10") Then
            Button2.Enabled = True

        End If


    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub




    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        amount.Show()


    End Sub
End Class