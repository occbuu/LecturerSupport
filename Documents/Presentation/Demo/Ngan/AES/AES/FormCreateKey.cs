using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class FormCreateKey : Form
    {
        public FormCreateKey()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string name = folderBrowserDialog1.SelectedPath;
            string publicKey = name + "\\" + txtPublicName.Text + ".xml";
            string privateKey = name + "\\" + txtPrivateName.Text + ".xml";
            Form1 a = new Form1();
            a.AssignNewKey(publicKey, privateKey);
            Close();
        }
    }
}