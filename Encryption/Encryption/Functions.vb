Imports System.Net.Mail
Public Class Functions
    Dim test As Double
    Dim Server As New SmtpClient
    Dim email As New MailMessage()
    Public Function Stirling(ByRef n As Integer)
        Return Math.Sqrt(2 * Math.PI * n) * ((n / Math.E) ^ n)
    End Function
    Sub Emails(ByRef address As String, ByRef body As String)
        Server.UseDefaultCredentials = False
        Server.Credentials = New Net.NetworkCredential("EncryptionSending@gmail.com", "3ncrypTi*n")
        Server.Port = 587
        Server.EnableSsl = True
        Server.Host = "smtp.gmail.com"

        Try
            email = New MailMessage()
            email.From = New MailAddress("EncrptionSending@gmail.com")
            email.To.Add(address)
            email.Subject = "Your encryted text"
            email.IsBodyHtml = False
            email.Body = body
            Server.Send(email)
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

    End Sub


End Class
