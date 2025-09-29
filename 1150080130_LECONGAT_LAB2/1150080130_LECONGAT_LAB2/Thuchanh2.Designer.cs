namespace ThucHanh2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.GroupBox grpDichVu;

        private System.Windows.Forms.CheckBox chkCaoRang;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.CheckBox chkBocRang;

        private System.Windows.Forms.NumericUpDown numHanRang;
        private System.Windows.Forms.NumericUpDown numBeRang;
        private System.Windows.Forms.NumericUpDown numBocRang;

        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.grpDichVu = new System.Windows.Forms.GroupBox();

            this.chkCaoRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.chkBocRang = new System.Windows.Forms.CheckBox();

            this.numHanRang = new System.Windows.Forms.NumericUpDown();
            this.numBeRang = new System.Windows.Forms.NumericUpDown();
            this.numBocRang = new System.Windows.Forms.NumericUpDown();

            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();

            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Name = "Form1";
            this.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 60;
            this.lblTitle.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);

            // lblTen
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(20, 80);
            this.lblTen.Text = "Tên khách hàng:";

            // txtTenKH
            this.txtTenKH.Location = new System.Drawing.Point(140, 77);
            this.txtTenKH.Size = new System.Drawing.Size(350, 23);
            this.txtTenKH.Name = "txtTenKH";

            // grpDichVu
            this.grpDichVu.Text = "Dịch vụ tại phòng khám:";
            this.grpDichVu.Location = new System.Drawing.Point(20, 120);
            this.grpDichVu.Size = new System.Drawing.Size(600, 180);

            // CheckBoxes
            this.chkCaoRang.AutoSize = true;
            this.chkCaoRang.Location = new System.Drawing.Point(20, 30);
            this.chkCaoRang.Text = "Lấy cao răng (50.000đ/2 hàm)";

            this.chkTayTrang.AutoSize = true;
            this.chkTayTrang.Location = new System.Drawing.Point(20, 60);
            this.chkTayTrang.Text = "Tẩy trắng răng (100.000đ/2 hàm)";

            this.chkHanRang.AutoSize = true;
            this.chkHanRang.Location = new System.Drawing.Point(20, 90);
            this.chkHanRang.Text = "Hàn răng (100.000đ/1 răng)";

            this.chkBeRang.AutoSize = true;
            this.chkBeRang.Location = new System.Drawing.Point(20, 120);
            this.chkBeRang.Text = "Bẻ răng (10.000đ/1 răng)";

            this.chkBocRang.AutoSize = true;
            this.chkBocRang.Location = new System.Drawing.Point(20, 150);
            this.chkBocRang.Text = "Bọc răng (1.000.000đ/1 răng)";

            // NumericUpDowns
            this.numHanRang.Location = new System.Drawing.Point(440, 88);
            this.numHanRang.Minimum = 1; this.numHanRang.Maximum = 50; this.numHanRang.Value = 1;
            this.numHanRang.Size = new System.Drawing.Size(60, 23);

            this.numBeRang.Location = new System.Drawing.Point(440, 118);
            this.numBeRang.Minimum = 1; this.numBeRang.Maximum = 50; this.numBeRang.Value = 1;
            this.numBeRang.Size = new System.Drawing.Size(60, 23);

            this.numBocRang.Location = new System.Drawing.Point(440, 148);
            this.numBocRang.Minimum = 1; this.numBocRang.Maximum = 50; this.numBocRang.Value = 1;
            this.numBocRang.Size = new System.Drawing.Size(60, 23);

            // Buttons
            this.btnTinhTien.Location = new System.Drawing.Point(160, 320);
            this.btnTinhTien.Size = new System.Drawing.Size(140, 35);
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);

            this.btnThoat.Location = new System.Drawing.Point(340, 320);
            this.btnThoat.Size = new System.Drawing.Size(140, 35);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Add controls into group & form
            this.grpDichVu.Controls.Add(this.chkCaoRang);
            this.grpDichVu.Controls.Add(this.chkTayTrang);
            this.grpDichVu.Controls.Add(this.chkHanRang);
            this.grpDichVu.Controls.Add(this.chkBeRang);
            this.grpDichVu.Controls.Add(this.chkBocRang);
            this.grpDichVu.Controls.Add(this.numHanRang);
            this.grpDichVu.Controls.Add(this.numBeRang);
            this.grpDichVu.Controls.Add(this.numBocRang);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);

            // ErrorProvider
            this.errorProvider1.ContainerControl = this;

            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}