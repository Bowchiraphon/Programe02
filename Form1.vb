Public Class Form1
    Dim a As String
    Dim s As String
    Dim d As String
    Dim f As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            f = CSng(TextBox1.Text)
            d = CSng(TextBox2.Text)
            a = TextBox1.Text
            s = TextBox2.Text
            If a >= s + 110 Then
                TextBox3.Text = "ผ่าน"
            Else
                TextBox3.Text = "ไม่ผ่าน"

            End If
        Catch ex As Exception
            MessageBox.Show("ใส่เฉพาะตัวเลข")


        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        รายชื่อสมาชิกในกลุ่ม.Show()



    End Sub
End Class
