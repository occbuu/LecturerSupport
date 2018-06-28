using MailKit.Net.Pop3;
using MimeKit;
using System;

namespace EmailProcessing
{
    public class EmailParser : IDisposable
    {

        protected string User { get; set; }
        protected string Pwd { get; set; }
        protected string MailServer { get; set; }
        protected int Port { get; set; }

        public Pop3Client Pop3 { get; set; }

        public EmailParser(string user, string pwd, string mailserver, int port)
        {
            User = user;
            Pwd = pwd;
            MailServer = mailserver;
            Port = port;
            Pop3 = null;
        }

        public void OpenPop3()
        {
            if (Pop3 == null)
            {
                Pop3 = new Pop3Client();

                Pop3.Connect(MailServer, Port, false);
                Pop3.AuthenticationMechanisms.Remove("XOAUTH2");
                Pop3.Authenticate(User, Pwd);
            }
        }

        public void ClosePop3()
        {
            if (Pop3 != null)
            {
                Pop3.Disconnect(true);
                Pop3.Dispose();
                Pop3 = null;
            }
        }

        public void DisplayPop3Subjects()
        {
            for (int i = 0; i < Pop3?.Count; i++)
            {
                MimeMessage message = Pop3.GetMessage(i);
                Console.WriteLine("Subject: {0}", message.Subject);
            }
        }
        public void Dispose() { }

        public void DisplayPop3HeaderInfo()
        {
            for (int i = 0; i < Pop3?.Count; i++)
            {
                MimeMessage message = Pop3.GetMessage(i);
                Console.WriteLine("Subject: {0}", message?.Subject);

                foreach (Header h in message?.Headers)
                {
                    Console.WriteLine("Header Field: {0} = {1}", h.Field, h.Value);
                }
            }
        }
    }
}