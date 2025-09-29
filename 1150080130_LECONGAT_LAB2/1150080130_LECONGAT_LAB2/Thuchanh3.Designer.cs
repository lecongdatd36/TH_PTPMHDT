namespace ThucHanh3
{
    partial class frmXuLySo
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnNhapSo;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChonChanDau;
        private System.Windows.Forms.Button btnChonLeCuoi;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnXoaDaySo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnNhapSo = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChonChanDau = new System.Windows.Forms.Button();
            this.btnChonLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Teal;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(605, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhap
            //
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(20, 65);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(108, 16);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "Nhập số nguyên:";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(140, 62);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(120, 22);
            this.txtSo.TabIndex = 2;
            // 
            // btnNhapSo
            // 
            this.btnNhapSo.Location = new System.Drawing.Point(270, 60);
            this.btnNhapSo.Name = "btnNhapSo";
            this.btnNhapSo.Size = new System.Drawing.Size(75, 23);
            this.btnNhapSo.TabIndex = 3;
            this.btnNhapSo.Text = "Nhập số";
            this.btnNhapSo.Click += new System.EventHandler(this.btnNhapSo_Click);
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.ItemHeight = 16;
            this.lsbDaySo.Location = new System.Drawing.Point(20, 100);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(180, 180);
            this.lsbDaySo.TabIndex = 4;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnTang2);
            this.grpChucNang.Controls.Add(this.btnChonChanDau);
            this.grpChucNang.Controls.Add(this.btnChonLeCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaDangChon);
            this.grpChucNang.Controls.Add(this.btnXoaDau);
            this.grpChucNang.Controls.Add(this.btnXoaCuoi);
            this.grpChucNang.Location = new System.Drawing.Point(220, 100);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(200, 240);
            this.grpChucNang.TabIndex = 5;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng:";
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(20, 30);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(160, 23);
            this.btnTang2.TabIndex = 0;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnChonChanDau
            // 
            this.btnChonChanDau.Location = new System.Drawing.Point(20, 65);
            this.btnChonChanDau.Name = "btnChonChanDau";
            this.btnChonChanDau.Size = new System.Drawing.Size(160, 23);
            this.btnChonChanDau.TabIndex = 1;
            this.btnChonChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonChanDau.Click += new System.EventHandler(this.btnChonChanDau_Click);
            //
            // btnChonLeCuoi
            // 
            this.btnChonLeCuoi.Location = new System.Drawing.Point(20, 100);
            this.btnChonLeCuoi.Name = "btnChonLeCuoi";
            this.btnChonLeCuoi.Size = new System.Drawing.Size(160, 23);
            this.btnChonLeCuoi.TabIndex = 2;
            this.btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonLeCuoi.Click += new System.EventHandler(this.btnChonLeCuoi_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(20, 135);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(160, 23);
            this.btnXoaDangChon.TabIndex = 3;
            this.btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Location = new System.Drawing.Point(20, 170);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(160, 23);
            this.btnXoaDau.TabIndex = 4;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Location = new System.Drawing.Point(20, 205);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(160, 23);
            this.btnXoaCuoi.TabIndex = 5;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnXoaDaySo
            // 
            this.btnXoaDaySo.BackColor = System.Drawing.Color.Gray;
            this.btnXoaDaySo.ForeColor = System.Drawing.Color.White;
            this.btnXoaDaySo.Location = new System.Drawing.Point(20, 360);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(120, 35);
            this.btnXoaDaySo.TabIndex = 6;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = false;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.DarkRed;
            this.btnKetThuc.ForeColor = System.Drawing.Color.White;
            this.btnKetThuc.Location = new System.Drawing.Point(160, 360);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(160, 35);
            this.btnKetThuc.TabIndex = 7;
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // frmXuLySo
            // 
            this.ClientSize = new System.Drawing.Size(605, 441);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.btnNhapSo);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnXoaDaySo);
            this.Controls.Add(this.btnKetThuc);
            this.Name = "frmXuLySo";
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}