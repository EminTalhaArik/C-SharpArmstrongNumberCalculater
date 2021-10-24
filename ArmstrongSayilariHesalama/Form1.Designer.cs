
namespace ArmstrongSayilariHesalama
{
    partial class frm_armstrong
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
            this.lbx_sayilar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_secenekler = new System.Windows.Forms.GroupBox();
            this.rBtn_aralikBelirt = new System.Windows.Forms.RadioButton();
            this.rBtn_sayiGir = new System.Windows.Forms.RadioButton();
            this.gbx_sayi = new System.Windows.Forms.GroupBox();
            this.lbl_sayi = new System.Windows.Forms.Label();
            this.tbx_sayi = new System.Windows.Forms.TextBox();
            this.gbx_sayiaraligi = new System.Windows.Forms.GroupBox();
            this.lbl_bitis = new System.Windows.Forms.Label();
            this.tbx_bitis = new System.Windows.Forms.TextBox();
            this.lbl_baslangic = new System.Windows.Forms.Label();
            this.tbx_baslangic = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.gbx_secenekler.SuspendLayout();
            this.gbx_sayi.SuspendLayout();
            this.gbx_sayiaraligi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_sayilar
            // 
            this.lbx_sayilar.Enabled = false;
            this.lbx_sayilar.FormattingEnabled = true;
            this.lbx_sayilar.ItemHeight = 16;
            this.lbx_sayilar.Location = new System.Drawing.Point(301, 29);
            this.lbx_sayilar.Name = "lbx_sayilar";
            this.lbx_sayilar.Size = new System.Drawing.Size(286, 516);
            this.lbx_sayilar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Armstrong Sayılar";
            // 
            // gbx_secenekler
            // 
            this.gbx_secenekler.Controls.Add(this.rBtn_aralikBelirt);
            this.gbx_secenekler.Controls.Add(this.rBtn_sayiGir);
            this.gbx_secenekler.Location = new System.Drawing.Point(15, 12);
            this.gbx_secenekler.Name = "gbx_secenekler";
            this.gbx_secenekler.Size = new System.Drawing.Size(277, 122);
            this.gbx_secenekler.TabIndex = 2;
            this.gbx_secenekler.TabStop = false;
            this.gbx_secenekler.Text = "Seçenekler";
            // 
            // rBtn_aralikBelirt
            // 
            this.rBtn_aralikBelirt.AutoSize = true;
            this.rBtn_aralikBelirt.Location = new System.Drawing.Point(144, 57);
            this.rBtn_aralikBelirt.Name = "rBtn_aralikBelirt";
            this.rBtn_aralikBelirt.Size = new System.Drawing.Size(100, 21);
            this.rBtn_aralikBelirt.TabIndex = 1;
            this.rBtn_aralikBelirt.TabStop = true;
            this.rBtn_aralikBelirt.Text = "Aralık Belirt";
            this.rBtn_aralikBelirt.UseVisualStyleBackColor = true;
            this.rBtn_aralikBelirt.CheckedChanged += new System.EventHandler(this.rBtn_aralikBelirt_CheckedChanged);
            // 
            // rBtn_sayiGir
            // 
            this.rBtn_sayiGir.AutoSize = true;
            this.rBtn_sayiGir.Location = new System.Drawing.Point(17, 57);
            this.rBtn_sayiGir.Name = "rBtn_sayiGir";
            this.rBtn_sayiGir.Size = new System.Drawing.Size(79, 21);
            this.rBtn_sayiGir.TabIndex = 0;
            this.rBtn_sayiGir.TabStop = true;
            this.rBtn_sayiGir.Text = "Sayı Gir";
            this.rBtn_sayiGir.UseVisualStyleBackColor = true;
            this.rBtn_sayiGir.CheckedChanged += new System.EventHandler(this.rBtn_sayiGir_CheckedChanged);
            // 
            // gbx_sayi
            // 
            this.gbx_sayi.Controls.Add(this.lbl_sayi);
            this.gbx_sayi.Controls.Add(this.tbx_sayi);
            this.gbx_sayi.Enabled = false;
            this.gbx_sayi.Location = new System.Drawing.Point(12, 140);
            this.gbx_sayi.Name = "gbx_sayi";
            this.gbx_sayi.Size = new System.Drawing.Size(280, 140);
            this.gbx_sayi.TabIndex = 3;
            this.gbx_sayi.TabStop = false;
            this.gbx_sayi.Text = "Sayı";
            // 
            // lbl_sayi
            // 
            this.lbl_sayi.AutoSize = true;
            this.lbl_sayi.Location = new System.Drawing.Point(18, 66);
            this.lbl_sayi.Name = "lbl_sayi";
            this.lbl_sayi.Size = new System.Drawing.Size(47, 17);
            this.lbl_sayi.TabIndex = 1;
            this.lbl_sayi.Text = "Sayı : ";
            // 
            // tbx_sayi
            // 
            this.tbx_sayi.Location = new System.Drawing.Point(102, 63);
            this.tbx_sayi.Name = "tbx_sayi";
            this.tbx_sayi.Size = new System.Drawing.Size(132, 22);
            this.tbx_sayi.TabIndex = 0;
            // 
            // gbx_sayiaraligi
            // 
            this.gbx_sayiaraligi.Controls.Add(this.lbl_bitis);
            this.gbx_sayiaraligi.Controls.Add(this.tbx_bitis);
            this.gbx_sayiaraligi.Controls.Add(this.lbl_baslangic);
            this.gbx_sayiaraligi.Controls.Add(this.tbx_baslangic);
            this.gbx_sayiaraligi.Enabled = false;
            this.gbx_sayiaraligi.Location = new System.Drawing.Point(15, 286);
            this.gbx_sayiaraligi.Name = "gbx_sayiaraligi";
            this.gbx_sayiaraligi.Size = new System.Drawing.Size(280, 175);
            this.gbx_sayiaraligi.TabIndex = 4;
            this.gbx_sayiaraligi.TabStop = false;
            this.gbx_sayiaraligi.Text = "Sayı Aralığı";
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.AutoSize = true;
            this.lbl_bitis.Location = new System.Drawing.Point(15, 107);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(46, 17);
            this.lbl_bitis.TabIndex = 5;
            this.lbl_bitis.Text = "Bitiş : ";
            // 
            // tbx_bitis
            // 
            this.tbx_bitis.Location = new System.Drawing.Point(99, 104);
            this.tbx_bitis.Name = "tbx_bitis";
            this.tbx_bitis.Size = new System.Drawing.Size(132, 22);
            this.tbx_bitis.TabIndex = 4;
            // 
            // lbl_baslangic
            // 
            this.lbl_baslangic.AutoSize = true;
            this.lbl_baslangic.Location = new System.Drawing.Point(15, 64);
            this.lbl_baslangic.Name = "lbl_baslangic";
            this.lbl_baslangic.Size = new System.Drawing.Size(81, 17);
            this.lbl_baslangic.TabIndex = 3;
            this.lbl_baslangic.Text = "Başlangıç : ";
            // 
            // tbx_baslangic
            // 
            this.tbx_baslangic.Location = new System.Drawing.Point(99, 61);
            this.tbx_baslangic.Name = "tbx_baslangic";
            this.tbx_baslangic.Size = new System.Drawing.Size(132, 22);
            this.tbx_baslangic.TabIndex = 2;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Enabled = false;
            this.btn_hesapla.Location = new System.Drawing.Point(12, 467);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(280, 69);
            this.btn_hesapla.TabIndex = 5;
            this.btn_hesapla.Text = "Armstrong Sayı Kontrolü";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // frm_armstrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 548);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.gbx_sayiaraligi);
            this.Controls.Add(this.gbx_sayi);
            this.Controls.Add(this.gbx_secenekler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_sayilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_armstrong";
            this.Text = "Armstrong Sayı Hesaplama";
            this.gbx_secenekler.ResumeLayout(false);
            this.gbx_secenekler.PerformLayout();
            this.gbx_sayi.ResumeLayout(false);
            this.gbx_sayi.PerformLayout();
            this.gbx_sayiaraligi.ResumeLayout(false);
            this.gbx_sayiaraligi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_sayilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_secenekler;
        private System.Windows.Forms.GroupBox gbx_sayi;
        private System.Windows.Forms.GroupBox gbx_sayiaraligi;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.RadioButton rBtn_aralikBelirt;
        private System.Windows.Forms.RadioButton rBtn_sayiGir;
        private System.Windows.Forms.Label lbl_sayi;
        private System.Windows.Forms.TextBox tbx_sayi;
        private System.Windows.Forms.Label lbl_bitis;
        private System.Windows.Forms.TextBox tbx_bitis;
        private System.Windows.Forms.Label lbl_baslangic;
        private System.Windows.Forms.TextBox tbx_baslangic;
    }
}

