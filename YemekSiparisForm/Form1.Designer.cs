namespace YemekSiparisForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbRestoran = new ComboBox();
            cmbYemekCesit = new ComboBox();
            cmbMalzemeler = new ComboBox();
            txtFiyat = new TextBox();
            btnSiparis = new Button();
            listBox1 = new ListBox();
            label6 = new Label();
            label7 = new Label();
            txtIcecek = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 43);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Restoran:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 99);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Yemek Çeşitleri:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 150);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Malzemeler:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 233);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 294);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Sonuç:";
            label5.Click += label5_Click;
            // 
            // cmbRestoran
            // 
            cmbRestoran.FormattingEnabled = true;
            cmbRestoran.Items.AddRange(new object[] { "Burger King ", "Dominos", "Usta Döner" });
            cmbRestoran.Location = new Point(135, 41);
            cmbRestoran.Name = "cmbRestoran";
            cmbRestoran.Size = new Size(121, 23);
            cmbRestoran.TabIndex = 5;
            cmbRestoran.SelectedIndexChanged += cmbRestoran_SelectedIndexChanged;
            // 
            // cmbYemekCesit
            // 
            cmbYemekCesit.FormattingEnabled = true;
            cmbYemekCesit.Items.AddRange(new object[] { "Chicken Burger", "Köfte Burger", "Bol Malzemos", "Vegan Pizza", "Tavuk Dürüm", "Et Dürüm" });
            cmbYemekCesit.Location = new Point(135, 99);
            cmbYemekCesit.Name = "cmbYemekCesit";
            cmbYemekCesit.Size = new Size(121, 23);
            cmbYemekCesit.TabIndex = 6;
            cmbYemekCesit.SelectedIndexChanged += cmbYemekCesit_SelectedIndexChanged;
            // 
            // cmbMalzemeler
            // 
            cmbMalzemeler.FormattingEnabled = true;
            cmbMalzemeler.Items.AddRange(new object[] { "Marul", "Soğan", "Ketçap", "Mayonez", "Mantar", "Sucuk" });
            cmbMalzemeler.Location = new Point(135, 147);
            cmbMalzemeler.Name = "cmbMalzemeler";
            cmbMalzemeler.Size = new Size(121, 23);
            cmbMalzemeler.TabIndex = 7;
            cmbMalzemeler.SelectedIndexChanged += cmbMalzemeler_SelectedIndexChanged;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(135, 225);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(121, 23);
            txtFiyat.TabIndex = 8;
            // 
            // btnSiparis
            // 
            btnSiparis.Location = new Point(181, 267);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(75, 23);
            btnSiparis.TabIndex = 9;
            btnSiparis.Text = "Sipariş Ver";
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(317, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(374, 184);
            listBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 292);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 11;
            label6.Text = "Sipariş Sonuç:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 197);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 12;
            label7.Text = "İçecek:";
            // 
            // txtIcecek
            // 
            txtIcecek.Location = new Point(135, 189);
            txtIcecek.Name = "txtIcecek";
            txtIcecek.Size = new Size(121, 23);
            txtIcecek.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 351);
            Controls.Add(txtIcecek);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(btnSiparis);
            Controls.Add(txtFiyat);
            Controls.Add(cmbMalzemeler);
            Controls.Add(cmbYemekCesit);
            Controls.Add(cmbRestoran);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbRestoran;
        private ComboBox cmbYemekCesit;
        private ComboBox cmbMalzemeler;
        private TextBox txtFiyat;
        private Button btnSiparis;
        private ListBox listBox1;
        private Label label6;
        private Label label7;
        private TextBox txtIcecek;
    }
}