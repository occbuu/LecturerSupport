using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AES
{
    public partial class Form1 : Form
    {
        private string _publicKeyPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncryped_Click(object sender, EventArgs e)
        {
            var rsaParams = new RSAWithRSAParameterKey();
            string original = txtPlaintext.Text;
            var encrypted = rsaParams.EncryptData(_publicKeyPath, Encoding.UTF8.GetBytes(original));

            txtEncrypt.Text = rsaParams.ConvertToString(encrypted);
            txtEncrypt.Text = Convert.ToBase64String(encrypted);
        }

        private void txtPublic_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (openFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                openFileDialogKey.Filter = "XML Files|*.xml";
                _publicKeyPath = openFileDialogKey.FileName;
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                string str = null;
                FileStream fs = new FileStream(_publicKeyPath, FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("RSAKeyValue");
                xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                txtPublic.Text = str;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreateKey create = new FormCreateKey();
            create.ShowDialog();
        }

        public void AssignNewKey(string publicKeyPath, string privateKeyPath)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;

                if (File.Exists(privateKeyPath))
                {
                    File.Delete(privateKeyPath);
                }

                if (File.Exists(publicKeyPath))
                {
                    File.Delete(publicKeyPath);
                }

                var publicKeyfolder = Path.GetDirectoryName(publicKeyPath);
                var privateKeyfolder = Path.GetDirectoryName(privateKeyPath);

                if (!Directory.Exists(publicKeyfolder))
                {
                    Directory.CreateDirectory(publicKeyfolder);
                }

                if (!Directory.Exists(privateKeyfolder))
                {
                    Directory.CreateDirectory(privateKeyfolder);
                }

                var publicKey = rsa.ToXmlString(false);
                File.WriteAllText(publicKeyPath, publicKey);
                File.WriteAllText(privateKeyPath, rsa.ToXmlString(true));
            }
        }
    }
}