namespace NetworkMonitoringWF.Forms
{
    partial class TopolojiForm
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
            this.panelTopoloji = new NetworkMonitoringWF.DoubleBufferedPanel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblKonumSec = new System.Windows.Forms.Label();
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBaglantiBaslat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBaglantiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopoloji
            // 
            this.panelTopoloji.BackColor = System.Drawing.Color.White;
            this.panelTopoloji.Location = new System.Drawing.Point(-3, 121);
            this.panelTopoloji.Name = "panelTopoloji";
            this.panelTopoloji.Size = new System.Drawing.Size(1280, 615);
            this.panelTopoloji.TabIndex = 0;
            this.panelTopoloji.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopoloji_Paint);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnGeri.Location = new System.Drawing.Point(1130, 10);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(135, 54);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "↩   Ana Sayfa";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblKonumSec
            // 
            this.lblKonumSec.AutoSize = true;
            this.lblKonumSec.Location = new System.Drawing.Point(10, 90);
            this.lblKonumSec.Name = "lblKonumSec";
            this.lblKonumSec.Size = new System.Drawing.Size(95, 20);
            this.lblKonumSec.TabIndex = 1;
            this.lblKonumSec.Text = "Konum Seç:";
            // 
            // cmbKonum
            // 
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Items.AddRange(new object[] {
            "İzmir Ofis",
            "Ankara Ofis",
            "Hakkari Ofis",
            "Dış Ağ",
            "Zonguldak Ofis"});
            this.cmbKonum.Location = new System.Drawing.Point(115, 87);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(274, 28);
            this.cmbKonum.TabIndex = 0;
            this.cmbKonum.SelectedIndexChanged += new System.EventHandler(this.cmbKonum_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPing,
            this.tsmGuncelle,
            this.tsmSil,
            this.tsmDetay,
            this.tsmBaglantiBaslat,
            this.tsmBaglantiSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 196);
            // 
            // tsmPing
            // 
            this.tsmPing.Name = "tsmPing";
            this.tsmPing.Size = new System.Drawing.Size(198, 32);
            this.tsmPing.Text = "Ping At";
            this.tsmPing.Click += new System.EventHandler(this.tsmPing_Click);
            // 
            // tsmGuncelle
            // 
            this.tsmGuncelle.Name = "tsmGuncelle";
            this.tsmGuncelle.Size = new System.Drawing.Size(198, 32);
            this.tsmGuncelle.Text = "Güncelle";
            this.tsmGuncelle.Click += new System.EventHandler(this.tsmGuncelle_Click);
            // 
            // tsmSil
            // 
            this.tsmSil.Name = "tsmSil";
            this.tsmSil.Size = new System.Drawing.Size(198, 32);
            this.tsmSil.Text = "Sil";
            this.tsmSil.Click += new System.EventHandler(this.tsmSil_Click);
            // 
            // tsmDetay
            // 
            this.tsmDetay.Name = "tsmDetay";
            this.tsmDetay.Size = new System.Drawing.Size(198, 32);
            this.tsmDetay.Text = "Detaylar";
            this.tsmDetay.Click += new System.EventHandler(this.tsmDetay_Click);
            // 
            // tsmBaglantiBaslat
            // 
            this.tsmBaglantiBaslat.Name = "tsmBaglantiBaslat";
            this.tsmBaglantiBaslat.Size = new System.Drawing.Size(198, 32);
            this.tsmBaglantiBaslat.Text = "Bağlantı Başlat";
            this.tsmBaglantiBaslat.Click += new System.EventHandler(this.tsmBaglantiBaslat_Click);
            // 
            // tsmBaglantiSil
            // 
            this.tsmBaglantiSil.Name = "tsmBaglantiSil";
            this.tsmBaglantiSil.Size = new System.Drawing.Size(198, 32);
            this.tsmBaglantiSil.Text = "Bağlantıyı Sil";
            this.tsmBaglantiSil.Click += new System.EventHandler(this.tsmBaglantiSil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 73);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "🕸️";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(95, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "AĞ TOPOLOJİSİ";
            // 
            // TopolojiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 731);
            this.Controls.Add(this.lblKonumSec);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbKonum);
            this.Controls.Add(this.panelTopoloji);
            this.Name = "TopolojiForm";
            this.Text = "TopolojiForm";
            this.Load += new System.EventHandler(this.TopolojiForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NetworkMonitoringWF.DoubleBufferedPanel panelTopoloji;
        private System.Windows.Forms.Label lblKonumSec;
        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmPing;
        private System.Windows.Forms.ToolStripMenuItem tsmGuncelle;
        private System.Windows.Forms.ToolStripMenuItem tsmSil;
        private System.Windows.Forms.ToolStripMenuItem tsmDetay;
        private System.Windows.Forms.ToolStripMenuItem tsmBaglantiBaslat;
        private System.Windows.Forms.ToolStripMenuItem tsmBaglantiSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}