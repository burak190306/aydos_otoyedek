
namespace aydos_otoyedek.UI
{
    partial class FrmUrun
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDetay = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.Label();
            this.Soy = new System.Windows.Forms.Label();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.txtNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmStok = new System.Windows.Forms.NumericUpDown();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(207, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(126, 347);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDetay
            // 
            this.txtDetay.Location = new System.Drawing.Point(79, 218);
            this.txtDetay.Multiline = true;
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetay.Size = new System.Drawing.Size(219, 78);
            this.txtDetay.TabIndex = 6;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(38, 221);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(35, 13);
            this.Adres.TabIndex = 8;
            this.Adres.Text = "Detay";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(10, 119);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(63, 13);
            this.Mail.TabIndex = 9;
            this.Mail.Text = "Stok Miktarı";
            // 
            // txtTel
            // 
            this.txtTel.AutoSize = true;
            this.txtTel.Location = new System.Drawing.Point(44, 92);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(29, 13);
            this.txtTel.TabIndex = 10;
            this.txtTel.Text = "Fiyat";
            // 
            // Soy
            // 
            this.Soy.AutoSize = true;
            this.Soy.Location = new System.Drawing.Point(27, 67);
            this.Soy.Name = "Soy";
            this.Soy.Size = new System.Drawing.Size(46, 13);
            this.Soy.TabIndex = 11;
            this.Soy.Text = "Kategori";
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(79, 38);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(219, 20);
            this.txtUrun.TabIndex = 1;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(43, 41);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(30, 13);
            this.Ad.TabIndex = 12;
            this.Ad.Text = "Urun";
            // 
            // txtNO
            // 
            this.txtNO.Location = new System.Drawing.Point(79, 12);
            this.txtNO.Name = "txtNO";
            this.txtNO.ReadOnly = true;
            this.txtNO.Size = new System.Drawing.Size(219, 20);
            this.txtNO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Motor",
            "Triger Kayışı",
            "Şanzıman",
            "Balata",
            "Lastik",
            "Jant"});
            this.cbKategori.Location = new System.Drawing.Point(79, 64);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(219, 21);
            this.cbKategori.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nmFiyat
            // 
            this.nmFiyat.Location = new System.Drawing.Point(79, 90);
            this.nmFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(219, 20);
            this.nmFiyat.TabIndex = 3;
            // 
            // nmStok
            // 
            this.nmStok.DecimalPlaces = 2;
            this.nmStok.Location = new System.Drawing.Point(79, 116);
            this.nmStok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmStok.Name = "nmStok";
            this.nmStok.Size = new System.Drawing.Size(219, 20);
            this.nmStok.TabIndex = 4;
            this.nmStok.ThousandsSeparator = true;
            // 
            // cbBirim
            // 
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Items.AddRange(new object[] {
            "adet",
            "kg",
            "ton"});
            this.cbBirim.Location = new System.Drawing.Point(79, 142);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(219, 21);
            this.cbBirim.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Birim";
            // 
            // FrmUrun
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(360, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.nmStok);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDetay);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.Soy);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.txtNO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDetay;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label txtTel;
        private System.Windows.Forms.Label Soy;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.TextBox txtNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nmStok;
        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.Label label2;
    }
}