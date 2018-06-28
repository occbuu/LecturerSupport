using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Decrypt
{
    public partial class Form1 : Form
    {
        private string _privateKeyPath;

        public Form1()
        {
            InitializeComponent();
        }

        public byte[] DecryptData(string privateKeyPath, byte[] dataToEncrypt)
        {
            byte[] plain;
            try
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.FromXmlString(File.ReadAllText(privateKeyPath));
                    plain = rsa.Decrypt(dataToEncrypt, false);
                }

                return plain;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string encrypted = txtEncrypted.Text;
                byte[] toBytes = Convert.FromBase64String(encrypted);
                var decrypted = DecryptData(_privateKeyPath, toBytes);
                txtPlaintext.Text = Encoding.UTF8.GetString(decrypted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (openFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                openFileDialogKey.Filter = "XML Files|*.xml";
                _privateKeyPath = openFileDialogKey.FileName;
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                string str = null;
                FileStream fs = new FileStream(_privateKeyPath, FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("RSAKeyValue");
                xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
                txtPrivate.Text = str;
            }
        }
    }
}