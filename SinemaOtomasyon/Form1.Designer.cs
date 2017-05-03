namespace SinemaOtomasyon
{
    partial class Giris
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
            this.Yenipersonel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.cboxBenihatırla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Yenipersonel
            // 
            this.Yenipersonel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Yenipersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Yenipersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yenipersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenipersonel.ForeColor = System.Drawing.Color.DimGray;
            this.Yenipersonel.Location = new System.Drawing.Point(25, 179);
            this.Yenipersonel.Name = "Yenipersonel";
            this.Yenipersonel.Size = new System.Drawing.Size(131, 36);
            this.Yenipersonel.TabIndex = 12;
            this.Yenipersonel.Text = "Yeni Personel";
            this.Yenipersonel.UseVisualStyleBackColor = false;
            this.Yenipersonel.Click += new System.EventHandler(this.Yenipersonel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(174, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parola:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı(Tc):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.Info;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(174, 98);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(131, 29);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.Text = "1234qqqQ";
            // 
            // txtKullanıcıAdi
            // 
            this.txtKullanıcıAdi.BackColor = System.Drawing.SystemColors.Info;
            this.txtKullanıcıAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdi.Location = new System.Drawing.Point(174, 44);
            this.txtKullanıcıAdi.Multiline = true;
            this.txtKullanıcıAdi.Name = "txtKullanıcıAdi";
            this.txtKullanıcıAdi.Size = new System.Drawing.Size(131, 29);
            this.txtKullanıcıAdi.TabIndex = 7;
            this.txtKullanıcıAdi.TextChanged += new System.EventHandler(this.txtKullanıcıAdi_TextChanged);
            // 
            // cboxBenihatırla
            // 
            this.cboxBenihatırla.BackColor = System.Drawing.Color.Transparent;
            this.cboxBenihatırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxBenihatırla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboxBenihatırla.Location = new System.Drawing.Point(162, 133);
            this.cboxBenihatırla.Name = "cboxBenihatırla";
            this.cboxBenihatırla.Size = new System.Drawing.Size(143, 40);
            this.cboxBenihatırla.TabIndex = 13;
            this.cboxBenihatırla.Text = "Beni Hatırla";
            this.cboxBenihatırla.UseMnemonic = false;
            this.cboxBenihatırla.UseVisualStyleBackColor = false;
            this.cboxBenihatırla.CheckedChanged += new System.EventHandler(this.cboxBenihatırla_CheckedChanged);
            // 
            // Giris
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SinemaOtomasyon.Properties.Resources.grafiti_fondos_fondo_blue_windows_119578;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 281);
            this.Controls.Add(this.cboxBenihatırla);
            this.Controls.Add(this.Yenipersonel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcıAdi);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Yenipersonel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanıcıAdi;
        private System.Windows.Forms.CheckBox cboxBenihatırla;
    }
}

