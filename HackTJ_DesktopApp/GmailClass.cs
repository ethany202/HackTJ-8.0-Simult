using System;
using System.Collections.Generic;
using System.Text;
using AE.Net.Mail;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;

namespace HackTJ_DesktopApp
{
    class GmailClass
    {
        public string username = "";
        public string accessKey = "";
        public string recipient = "";
        public string subject = "";
        public string body = "";

        public object media;
        public string mediaPath = "";

        public void WriteEmail()
        {
            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(username, accessKey);
                    System.Net.Mail.MailMessage msgObj = new System.Net.Mail.MailMessage();


                    if (media != null)
                    {
                        System.Net.Mail.Attachment data = new System.Net.Mail.Attachment(mediaPath, MediaTypeNames.Application.Octet);
                        ContentDisposition disposition = data.ContentDisposition;
                        disposition.CreationDate = System.IO.File.GetCreationTime(mediaPath);
                        disposition.ModificationDate = System.IO.File.GetLastWriteTime(mediaPath);
                        disposition.ReadDate = System.IO.File.GetLastAccessTime(mediaPath);
                        msgObj.Attachments.Add(data);
                    }

                    msgObj.To.Add(recipient);
                    msgObj.From = new MailAddress(username);
                    msgObj.Subject = subject;
                    msgObj.Body = body;
                    
                    client.Send(msgObj);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public void ResetVariables()
        {
            username = "";
            accessKey = "";
            recipient = "";
            subject = "";
            body = "";
            media = null;
            mediaPath = "";
        }
    }
}
