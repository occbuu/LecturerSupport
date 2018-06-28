namespace AES
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublic = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.btnEncryped = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.openFileDialogKey = new System.Windows.Forms.OpenFileDialog();
            this.btnCreate = new System.Windows.Forms.Button();
            this.saveFileDialogKey = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plaintext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encrypted Text";
            // 
            // txtPublic
            // 
            this.txtPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublic.Location = new System.Drawing.Point(337, 88);
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.Size = new System.Drawing.Size(368, 35);
            this.txtPublic.TabIndex = 3;
            this.txtPublic.TextChanged += new System.EventHandler(this.txtPublic_TextChanged);
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaintext.Location = new System.Drawing.Point(337, 128);
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(368, 35);
            this.txtPlaintext.TabIndex = 4;
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncrypt.Location = new System.Drawing.Point(337, 172);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(368, 35);
            this.txtEncrypt.TabIndex = 5;
            // 
            // btnEncryped
            // 
            this.btnEncryped.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryped.Location = new System.Drawing.Point(440, 241);
            this.btnEncryped.Name = "btnEncryped";
            this.btnEncryped.Size = new System.Drawing.Size(150, 42);
            this.btnEncryped.TabIndex = 6;
            this.btnEncryped.Text = "Encrypt";
            this.btnEncryped.UseVisualStyleBackColor = true;
            this.btnEncryped.Click += new System.EventHandler(this.btnEncryped_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(750, 88);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(141, 35);
            this.btnChoose.TabIndex = 7;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(142, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 36);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Key";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 441);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnEncryped);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.txtPublic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublic;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.Button btnEncryped;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.OpenFileDialog openFileDialogKey;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.SaveFileDialog saveFileDialogKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

