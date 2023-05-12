namespace YemekSiparisForm
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            btnLogin = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 101);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(134, 28);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(100, 23);
            txtKullanici.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(134, 93);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(159, 158);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(49, 219);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(43, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 320);
            Controls.Add(lblSonuc);
            Controls.Add(btnLogin);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanici);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private Button btnLogin;
        private Label lblSonuc;
    }
}