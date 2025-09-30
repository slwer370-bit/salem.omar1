Public Class Form1
    Dim x, y, w, k As String
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w = Chr(13) + Chr(10)
        x = "جامعة الملك سعود" + w
        x = x + " مركز التدريب وخدمة المجتمع " + w
        x = x + " دبلوم الحاسب الآلي " + w
        x = x + " اعداد الأستاذ  عبدالله بن سماء " + w
        x = x + " للعام الدراسي 1447ه "
        y = "حول المشروع"
        MsgBox(x, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, y)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        x = " هل حقا تريد الخروج من المشروع ؟ "
        y = " تحذير "
        k = MsgBox(x, MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, y)

        If k = 6 Then End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        i = InputBox("صندوق ادخال الألوان", "الرجاء ادخال عدد بين 0 و 15 ")

        If i >= 0 And i <= 15 Then
            Me.BackColor = System.Drawing.ColorTranslator.FromOle(QBColor(Val(i)))
        Else
            MsgBox("الادخال خاطئ", , "تنبيه ")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Randomize()
        BackColor = System.Drawing.ColorTranslator.FromOle(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        w = Chr(13) + Chr(10)
        TextBox1.Text = "  الحمد لله" + w + " رب العالمين"
        Label1.Text = " الحمد لله" + w + " رب العالمين"

    End Sub
End Class
