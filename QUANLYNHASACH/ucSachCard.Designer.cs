namespace QUANLYNHASACH
{
    partial class ucSachCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBiaSach = new System.Windows.Forms.PictureBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.btnMua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBiaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // picBiaSach
            // 
            this.picBiaSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBiaSach.Location = new System.Drawing.Point(0, 0);
            this.picBiaSach.Name = "picBiaSach";
            this.picBiaSach.Size = new System.Drawing.Size(239, 226);
            this.picBiaSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBiaSach.TabIndex = 0;
            this.picBiaSach.TabStop = false;
            this.picBiaSach.Click += new System.EventHandler(this.picBiaSach_Click);
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(0, 226);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(108, 16);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "Tên cuốn sách";
            this.lblTenSach.Click += new System.EventHandler(this.lblTenSach_Click);
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGiaTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.ForeColor = System.Drawing.Color.Red;
            this.lblGiaTien.Location = new System.Drawing.Point(0, 242);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(90, 20);
            this.lblGiaTien.TabIndex = 2;
            this.lblGiaTien.Text = "100.000 đ";
            // 
            // btnMua
            // 
            this.btnMua.BackColor = System.Drawing.Color.Yellow;
            this.btnMua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMua.ForeColor = System.Drawing.Color.Black;
            this.btnMua.Location = new System.Drawing.Point(0, 284);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(239, 34);
            this.btnMua.TabIndex = 3;
            this.btnMua.Text = "MUA NGAY";
            this.btnMua.UseVisualStyleBackColor = false;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // ucSachCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.picBiaSach);
            this.Name = "ucSachCard";
            this.Size = new System.Drawing.Size(239, 318);
            ((System.ComponentModel.ISupportInitialize)(this.picBiaSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBiaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Button btnMua;
    }
}
