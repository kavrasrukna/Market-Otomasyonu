
namespace marketentityproc
{
    partial class kullanicigirisi
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
            this.kayitol = new System.Windows.Forms.GroupBox();
            this.btnkayit = new System.Windows.Forms.Button();
            this.maskedtxttel = new System.Windows.Forms.MaskedTextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kayitsifre = new System.Windows.Forms.TextBox();
            this.kayitkullaniciadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.girisyap = new System.Windows.Forms.GroupBox();
            this.txtgsifre = new System.Windows.Forms.TextBox();
            this.txtgkullaniciadi = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kayitol.SuspendLayout();
            this.girisyap.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayitol
            // 
            this.kayitol.BackColor = System.Drawing.Color.Transparent;
            this.kayitol.Controls.Add(this.btnkayit);
            this.kayitol.Controls.Add(this.maskedtxttel);
            this.kayitol.Controls.Add(this.txtmail);
            this.kayitol.Controls.Add(this.label5);
            this.kayitol.Controls.Add(this.label6);
            this.kayitol.Controls.Add(this.kayitsifre);
            this.kayitol.Controls.Add(this.kayitkullaniciadi);
            this.kayitol.Controls.Add(this.label3);
            this.kayitol.Controls.Add(this.label4);
            this.kayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitol.Location = new System.Drawing.Point(463, 123);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(234, 257);
            this.kayitol.TabIndex = 4;
            this.kayitol.TabStop = false;
            this.kayitol.Text = "KAYIT OL";
            // 
            // btnkayit
            // 
            this.btnkayit.BackColor = System.Drawing.Color.Tomato;
            this.btnkayit.Location = new System.Drawing.Point(73, 217);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(75, 23);
            this.btnkayit.TabIndex = 14;
            this.btnkayit.Text = "Kayıt Ol";
            this.btnkayit.UseVisualStyleBackColor = false;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // maskedtxttel
            // 
            this.maskedtxttel.Location = new System.Drawing.Point(103, 174);
            this.maskedtxttel.Mask = "(999) 000-0000";
            this.maskedtxttel.Name = "maskedtxttel";
            this.maskedtxttel.Size = new System.Drawing.Size(100, 21);
            this.maskedtxttel.TabIndex = 13;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(103, 128);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 21);
            this.txtmail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-Mail:";
            // 
            // kayitsifre
            // 
            this.kayitsifre.Location = new System.Drawing.Point(103, 85);
            this.kayitsifre.Name = "kayitsifre";
            this.kayitsifre.PasswordChar = '*';
            this.kayitsifre.Size = new System.Drawing.Size(100, 21);
            this.kayitsifre.TabIndex = 8;
            // 
            // kayitkullaniciadi
            // 
            this.kayitkullaniciadi.Location = new System.Drawing.Point(103, 39);
            this.kayitkullaniciadi.Name = "kayitkullaniciadi";
            this.kayitkullaniciadi.Size = new System.Drawing.Size(100, 21);
            this.kayitkullaniciadi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // girisyap
            // 
            this.girisyap.BackColor = System.Drawing.Color.Transparent;
            this.girisyap.Controls.Add(this.txtgsifre);
            this.girisyap.Controls.Add(this.txtgkullaniciadi);
            this.girisyap.Controls.Add(this.btngiris);
            this.girisyap.Controls.Add(this.label2);
            this.girisyap.Controls.Add(this.label1);
            this.girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisyap.Location = new System.Drawing.Point(147, 123);
            this.girisyap.Name = "girisyap";
            this.girisyap.Size = new System.Drawing.Size(238, 257);
            this.girisyap.TabIndex = 3;
            this.girisyap.TabStop = false;
            this.girisyap.Text = "GİRİŞ YAP";
            // 
            // txtgsifre
            // 
            this.txtgsifre.Location = new System.Drawing.Point(104, 79);
            this.txtgsifre.Name = "txtgsifre";
            this.txtgsifre.PasswordChar = '*';
            this.txtgsifre.Size = new System.Drawing.Size(100, 21);
            this.txtgsifre.TabIndex = 4;
            // 
            // txtgkullaniciadi
            // 
            this.txtgkullaniciadi.Location = new System.Drawing.Point(104, 33);
            this.txtgkullaniciadi.Name = "txtgkullaniciadi";
            this.txtgkullaniciadi.Size = new System.Drawing.Size(100, 21);
            this.txtgkullaniciadi.TabIndex = 3;
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Tomato;
            this.btngiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngiris.Location = new System.Drawing.Point(75, 134);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(75, 23);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // kullanicigirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::marketentityproc.Properties.Resources.a51;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.kayitol);
            this.Controls.Add(this.girisyap);
            this.Name = "kullanicigirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI GİRİŞİ";
           // this.Load += new System.EventHandler(this.kullanicigirisi_Load);
            this.kayitol.ResumeLayout(false);
            this.kayitol.PerformLayout();
            this.girisyap.ResumeLayout(false);
            this.girisyap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox kayitol;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.MaskedTextBox maskedtxttel;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kayitsifre;
        private System.Windows.Forms.TextBox kayitkullaniciadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox girisyap;
        private System.Windows.Forms.TextBox txtgsifre;
        private System.Windows.Forms.TextBox txtgkullaniciadi;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}