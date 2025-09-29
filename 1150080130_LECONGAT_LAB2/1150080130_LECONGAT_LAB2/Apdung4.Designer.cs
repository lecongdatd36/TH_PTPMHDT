namespace ApDung4
{
    partial class FrmChonMatHang
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstNguon;
        private System.Windows.Forms.ListBox lstDich;
        private System.Windows.Forms.Label lblNguon;
        private System.Windows.Forms.Label lblDich;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveAllRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveAllLeft;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lstNguon = new System.Windows.Forms.ListBox();
            this.lstDich = new System.Windows.Forms.ListBox();
            this.lblNguon = new System.Windows.Forms.Label();
            this.lblDich = new System.Windows.Forms.Label();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveAllRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveAllLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Name = "FrmChonMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập 7 - Chọn mặt hàng (ApDung4)";
            // 
            // lblNguon
            // 
            this.lblNguon.AutoSize = true;
            this.lblNguon.Location = new System.Drawing.Point(20, 15);
            this.lblNguon.Text = "Danh sách các mặt hàng";
            // 
            // lblDich
            // 
            this.lblDich.AutoSize = true;
            this.lblDich.Location = new System.Drawing.Point(340, 15);
            this.lblDich.Text = "Các mặt hàng lựa chọn";
            // 
            // lstNguon
            // 
            this.lstNguon.Location = new System.Drawing.Point(20, 35);
            this.lstNguon.Size = new System.Drawing.Size(220, 220);
            this.lstNguon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // lstDich
            // 
            this.lstDich.Location = new System.Drawing.Point(320, 35);
            this.lstDich.Size = new System.Drawing.Size(220, 220);
            this.lstDich.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // btnMoveRight (>)
            //
            this.btnMoveRight.Location = new System.Drawing.Point(255, 70);
            this.btnMoveRight.Size = new System.Drawing.Size(50, 28);
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // btnMoveAllRight (>>)
            // 
            this.btnMoveAllRight.Location = new System.Drawing.Point(255, 105);
            this.btnMoveAllRight.Size = new System.Drawing.Size(50, 28);
            this.btnMoveAllRight.Text = ">>";
            this.btnMoveAllRight.Click += new System.EventHandler(this.BtnMoveAllRight_Click);
            // 
            // btnMoveLeft (<)
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(255, 140);
            this.btnMoveLeft.Size = new System.Drawing.Size(50, 28);
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // btnMoveAllLeft (<<)
            // 
            this.btnMoveAllLeft.Location = new System.Drawing.Point(255, 175);
            this.btnMoveAllLeft.Size = new System.Drawing.Size(50, 28);
            this.btnMoveAllLeft.Text = "<<";
            this.btnMoveAllLeft.Click += new System.EventHandler(this.BtnMoveAllLeft_Click);
            // 
            // Add controls
            // 
            this.Controls.Add(this.lblNguon);
            this.Controls.Add(this.lblDich);
            this.Controls.Add(this.lstNguon);
            this.Controls.Add(this.lstDich);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveAllRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveAllLeft);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}