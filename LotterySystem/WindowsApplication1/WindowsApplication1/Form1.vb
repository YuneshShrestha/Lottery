
Public Class Form1

    Dim count As Integer
    Dim count2, count3 As Integer
    Dim num, num2 As Integer
    Dim flag As Boolean = False
    Dim robot = CreateObject("SAPI.spvoice")


    Private Sub btnLuckyDraw_Click(sender As Object, e As EventArgs) Handles btnLuckyDraw.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = False

        'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        flag = False
        count = 0
        count2 = 0
        count3 = 0
        Timer2.Interval = 10
        Timer1.Interval = 100
    End Sub

    Private Sub btnLuckyDraw_MouseEnter(sender As Object, e As EventArgs) Handles btnLuckyDraw.MouseEnter
        btnLuckyDraw.BackColor = Color.Black
        btnLuckyDraw.ForeColor = Color.White
    End Sub

    Private Sub btnLuckyDraw_MouseLeave(sender As Object, e As EventArgs) Handles btnLuckyDraw.MouseLeave
        btnLuckyDraw.BackColor = Color.LightGray
        btnLuckyDraw.ForeColor = Color.Black
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        count = count + 1
        num = CInt(Rnd() * 8)
        txtNumber1.Text = num

        If count = 200 Then

            Timer1.Enabled = False
        ElseIf count = 150 Then
            Timer1.Interval = Timer1.Interval + 4
        ElseIf count = 190 Then
            Timer1.Interval = Timer1.Interval + 7

        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        count2 = count2 + 1
        num2 = CInt(Rnd() * 9)
        txtNumber2.Text = num2


        If count2 = 1500 Then

            Timer2.Enabled = False

            Timer3.Enabled = True

            TextBox1.Text = txtNumber1.Text & txtNumber2.Text
        ElseIf count2 = 1450 Then

            Timer2.Interval = Timer2.Interval + 50

        ElseIf count2 = 1480 Then

            Timer2.Interval = Timer2.Interval + 70

        End If


        'If txtNumber2.Text = num2 Then

        '    robot.speak("Here Is The Lucky Student")

        'End 





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        count3 = count3 + 1
        If count3 = 3 Then
            Timer3.Enabled = False
            robot.speak("Here Is The Lucky Student " & TextBox1.Text)
            robot.speak("Congratulations Student Number" & TextBox1.Text)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim ask As DialogResult
        ask = MsgBox("Do You Want To Exit?", vbYesNo, "Exit")
        If ask = vbYes Then
            End

        End If
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.BackColor = Color.Black
        btnExit.ForeColor = Color.White
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.LightGray
        btnExit.ForeColor = Color.Black
    End Sub
End Class

