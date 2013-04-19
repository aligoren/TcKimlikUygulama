namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDogrula = new System.Windows.Forms.Button();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.BackColor = System.Drawing.Color.Salmon;
            this.txtTcKimlik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTcKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKimlik.Location = new System.Drawing.Point(87, 12);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(235, 20);
            this.txtTcKimlik.TabIndex = 0;
            this.txtTcKimlik.Tag = "";
            this.toolTip1.SetToolTip(this.txtTcKimlik, "TC Kimlik Numaranız");
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.Salmon;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(87, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(235, 20);
            this.txtAd.TabIndex = 2;
            this.txtAd.Tag = "";
            this.toolTip1.SetToolTip(this.txtAd, "ADINIZ BÜYÜK HARFLERLE YAZILMALI");
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.Salmon;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(87, 83);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(235, 20);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.Tag = "";
            this.toolTip1.SetToolTip(this.txtSoyad, "SOYADINIZ BÜYÜK HARFLERLE YAZILMALI");
            // 
            // txtYil
            // 
            this.txtYil.BackColor = System.Drawing.Color.Salmon;
            this.txtYil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(87, 118);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(235, 20);
            this.txtYil.TabIndex = 4;
            this.txtYil.Tag = "";
            this.toolTip1.SetToolTip(this.txtYil, "Doğum Tarihi Örnek: 1993");
            // 
            // btnTemizle
            // 
            this.btnTemizle.AccessibleDescription = "";
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(189, 144);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(39, 43);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Tag = "";
            this.toolTip1.SetToolTip(this.btnTemizle, "Kutucukları Temizler");
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnDogrula
            // 
            this.btnDogrula.FlatAppearance.BorderSize = 0;
            this.btnDogrula.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDogrula.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDogrula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDogrula.Image = ((System.Drawing.Image)(resources.GetObject("btnDogrula.Image")));
            this.btnDogrula.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDogrula.Location = new System.Drawing.Point(144, 144);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(39, 43);
            this.btnDogrula.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnDogrula, "TC Kimlik No Dogrulama Islemi");
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.FlatAppearance.BorderSize = 0;
            this.btnHakkinda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnHakkinda.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHakkinda.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkinda.Image")));
            this.btnHakkinda.Location = new System.Drawing.Point(234, 144);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(39, 43);
            this.btnHakkinda.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnHakkinda, "Program Hakkinda");
            this.btnHakkinda.UseVisualStyleBackColor = true;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTCNo.Location = new System.Drawing.Point(6, 15);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(53, 13);
            this.lblTCNo.TabIndex = 7;
            this.lblTCNo.Text = "TC NO: ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAd.Location = new System.Drawing.Point(6, 50);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 13);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "Ad: ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSoyad.Location = new System.Drawing.Point(6, 86);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 13);
            this.lblSoyad.TabIndex = 9;
            this.lblSoyad.Text = "Soyad: ";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.ForeColor = System.Drawing.Color.DarkRed;
            this.lblYil.Location = new System.Drawing.Point(6, 121);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(75, 13);
            this.lblYil.TabIndex = 10;
            this.lblYil.Text = "Doğum Yılı: ";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(279, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.button1, "Çıkış Yap");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHakkinda);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTcKimlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TC Kimlik No Dogrulama Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Button btnHakkinda;
        private System.Windows.Forms.Button button1;
    }
}

