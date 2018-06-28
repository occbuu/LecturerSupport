namespace EmailProcessing
{
    class EmailExample
    {

        private const string cPopUserName = "test@popserver.com";
        private const string cPopPwd = "1234";
        private const string cPopMailServer = "mail.popserver.com";
        private const int cPopPort = 110;

        private const string cImapUserName = "test@imapserver.com";
        private const string cImapPwd = "1234";
        private const string cImapMailServer = "mail.imapserver.com";
        private const int cImapPort = 993;

        private const string cSmtpUserName = "test@smtpserver.com";
        private const string cSmtpPwd = "1234";
        private const string cSmtpMailServer = "mail.smtpserver.com";
        private const int cSmptPort = 465;

        public static void ShowPop3Subjects()
        {
            using (EmailParser ep = new EmailParser(cPopUserName, cPopPwd, cPopMailServer, cPopPort))
            {
                ep.OpenPop3();
                ep.DisplayPop3Subjects();
                ep.ClosePop3();
            }
        }

        public static void ShowImapSubjects()
        {
            using (EmailParser ep = new EmailParser(cImapUserName, cImapPwd, cImapMailServer, cImapPort))
            {
                //ep.OpenImap();
                //ep.DisplayImapSubjects();
                //ep.CloseImap();
            }
        }
    }
}