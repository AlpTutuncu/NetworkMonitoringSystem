namespace NetworkMonitoringWF.Forms
{
    partial class VlanEkleForm
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
            this.txtVlanNo = new System.Windows.Forms.TextBox();
            this.txtVlanAdi = new System.Windows.Forms.TextBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.pnlRenk = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblVlanAdi = new System.Windows.Forms.Label();
            this.lblVlanNo = new System.Windows.Forms.Label();
            this.lblVlanEkle = new ReaLTaiizor.Controls.MoonLabel();
            this.lblRenk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVlanNo
            // 
            this.txtVlanNo.Location = new System.Drawing.Point(289, 101);
            this.txtVlanNo.Name = "txtVlanNo";
            this.txtVlanNo.Size = new System.Drawing.Size(246, 26);
            this.txtVlanNo.TabIndex = 0;
            // 
            // txtVlanAdi
            // 
            this.txtVlanAdi.Location = new System.Drawing.Point(289, 144);
            this.txtVlanAdi.Name = "txtVlanAdi";
            this.txtVlanAdi.Size = new System.Drawing.Size(246, 26);
            this.txtVlanAdi.TabIndex = 1;
            // 
            // txtSubnet
            // 
            this.txtSubnet.Location = new System.Drawing.Point(289, 190);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(246, 26);
            this.txtSubnet.TabIndex = 2;
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(289, 234);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(251, 26);
            this.txtGateway.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(289, 323);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(246, 26);
            this.txtAciklama.TabIndex = 4;
            // 
            // cmbKonum
            // 
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Location = new System.Drawing.Point(289, 277);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(251, 28);
            this.cmbKonum.TabIndex = 5;
            // 
            // pnlRenk
            // 
            this.pnlRenk.Location = new System.Drawing.Point(289, 370);
            this.pnlRenk.Name = "pnlRenk";
            this.pnlRenk.Size = new System.Drawing.Size(46, 37);
            this.pnlRenk.TabIndex = 6;
            this.pnlRenk.Click += new System.EventHandler(this.pnlRenk_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(595, 396);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 42);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(12, 12);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(91, 39);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(176, 236);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(76, 20);
            this.lblGateway.TabIndex = 12;
            this.lblGateway.Text = "Gateway:";
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Location = new System.Drawing.Point(189, 281);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(63, 20);
            this.lblKonum.TabIndex = 11;
            this.lblKonum.Text = "Konum:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(174, 326);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(77, 20);
            this.lblAciklama.TabIndex = 10;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Location = new System.Drawing.Point(187, 193);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(65, 20);
            this.lblSubnet.TabIndex = 9;
            this.lblSubnet.Text = "Subnet:";
            // 
            // lblVlanAdi
            // 
            this.lblVlanAdi.AutoSize = true;
            this.lblVlanAdi.Location = new System.Drawing.Point(171, 148);
            this.lblVlanAdi.Name = "lblVlanAdi";
            this.lblVlanAdi.Size = new System.Drawing.Size(82, 20);
            this.lblVlanAdi.TabIndex = 8;
            this.lblVlanAdi.Text = "VLAN Adı:";
            // 
            // lblVlanNo
            // 
            this.lblVlanNo.AutoSize = true;
            this.lblVlanNo.Location = new System.Drawing.Point(174, 103);
            this.lblVlanNo.Name = "lblVlanNo";
            this.lblVlanNo.Size = new System.Drawing.Size(79, 20);
            this.lblVlanNo.TabIndex = 7;
            this.lblVlanNo.Text = "VLAN No:";
            // 
            // lblVlanEkle
            // 
            this.lblVlanEkle.AutoSize = true;
            this.lblVlanEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblVlanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVlanEkle.ForeColor = System.Drawing.Color.Coral;
            this.lblVlanEkle.Location = new System.Drawing.Point(290, 36);
            this.lblVlanEkle.Name = "lblVlanEkle";
            this.lblVlanEkle.Size = new System.Drawing.Size(173, 37);
            this.lblVlanEkle.TabIndex = 13;
            this.lblVlanEkle.Text = "VLAN Ekle";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(151, 372);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(99, 20);
            this.lblRenk.TabIndex = 30;
            this.lblRenk.Text = "Renk Etiketi:";
            // 
            // VlanEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblVlanEkle);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblSubnet);
            this.Controls.Add(this.lblVlanAdi);
            this.Controls.Add(this.lblVlanNo);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.pnlRenk);
            this.Controls.Add(this.cmbKonum);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtSubnet);
            this.Controls.Add(this.txtVlanAdi);
            this.Controls.Add(this.txtVlanNo);
            this.Name = "VlanEkleForm";
            this.Text = "VlanEkleForm";
            this.Load += new System.EventHandler(this.VlanEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVlanNo;
        private System.Windows.Forms.TextBox txtVlanAdi;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.Panel pnlRenk;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblVlanAdi;
        private System.Windows.Forms.Label lblVlanNo;
        private ReaLTaiizor.Controls.MoonLabel lblVlanEkle;
        private System.Windows.Forms.Label lblRenk;
    }
}