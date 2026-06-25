namespace NetworkMonitoringWF
{
    partial class CihazYonetimForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCihazEkle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblAra = new System.Windows.Forms.Label();
            this.lblCihazYonetimi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 576);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.ForeColor = System.Drawing.Color.Black;
            this.btnGeri.Location = new System.Drawing.Point(13, 50);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(142, 37);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Ana Sayfaya Dön";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCihazEkle
            // 
            this.btnCihazEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnCihazEkle.Location = new System.Drawing.Point(1035, 53);
            this.btnCihazEkle.Name = "btnCihazEkle";
            this.btnCihazEkle.Size = new System.Drawing.Size(119, 34);
            this.btnCihazEkle.TabIndex = 2;
            this.btnCihazEkle.Text = "Cihaz Ekle";
            this.btnCihazEkle.UseVisualStyleBackColor = false;
            this.btnCihazEkle.Click += new System.EventHandler(this.btnCihazEkle_Click);
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.White;
            this.txtAra.Location = new System.Drawing.Point(414, 58);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(335, 26);
            this.txtAra.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(767, 55);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(76, 32);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(849, 55);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(94, 32);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(290, 61);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(109, 20);
            this.lblAra.TabIndex = 6;
            this.lblAra.Text = "Ağ Cihazı Ara:";
            // 
            // lblCihazYonetimi
            // 
            this.lblCihazYonetimi.AutoSize = true;
            this.lblCihazYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCihazYonetimi.ForeColor = System.Drawing.Color.Coral;
            this.lblCihazYonetimi.Location = new System.Drawing.Point(462, 9);
            this.lblCihazYonetimi.Name = "lblCihazYonetimi";
            this.lblCihazYonetimi.Size = new System.Drawing.Size(247, 37);
            this.lblCihazYonetimi.TabIndex = 7;
            this.lblCihazYonetimi.Text = "Cihaz Yönetimi";
            // 
            // CihazYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 681);
            this.Controls.Add(this.lblCihazYonetimi);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnCihazEkle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CihazYonetimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CihazYonetimForm";
            this.Load += new System.EventHandler(this.CihazYonetimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCihazEkle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Label lblCihazYonetimi;
    }
}