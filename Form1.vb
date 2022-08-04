Imports System.Net.Mail 'Email connection
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mail As New MailMessage()
        Dim smtServers As New SmtpClient("smtp.gmail.com")
        mail.From = New MailAddress("haroldmenor25@gmail.com")
        mail.To.Add(TextBox1.Text)     'Enter Message
        mail.Subject = TextBox2.Text
        mail.Body = TextBox3.Text


        Dim attach As System.Net.Mail.Attachment
        attach = New System.Net.Mail.Attachment(Label4.Text)
        mail.Attachments.Add(attach)
        smtServers.Port = 587
        smtServers.Credentials = New System.Net.NetworkCredential("haroldmenor25@gmail.com", "hveyrccbiudsagdq")
        smtServers.EnableSsl = True
        smtServers.Send(mail)
        MessageBox.Show("Mail send") 'Show message mail send

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()   'attach file here!
        Label4.Text = OpenFileDialog1.FileName
    End Sub


End Class
