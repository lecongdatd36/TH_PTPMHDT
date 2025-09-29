namespace ApDung1
{
    partial class ApDung1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();

            this.grpOption = new System.Windows.Forms.GroupBox();
            this.rdoUCLN = new System.Windows.Forms.RadioButton();
            this.rdoBCNN = new System.Windows.Forms.RadioButton();

            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();

            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpInput.SuspendLayout();
            this.grpOption.SuspendLayout();
            this.SuspendLayout();

            // ===== Form =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 340);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            this.AcceptButton = this.btnTim;
            this.CancelButton = this.btnThoat;

            // ===== grpInput =====
            this.grpInput.Controls.Add(this.lblA);
            this.grpInput.Controls.Add(this.txtA);
            this.grpInput.Controls.Add(this.lblB);
            this.grpInput.Controls.Add(this.txtB);
            this.grpInput.Location = new System.Drawing.Point(20, 20);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(400, 140);
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Nhập dữ liệu:";
            this.grpInput.BackColor = System.Drawing.Color.FromArgb(200, 255, 220);

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 40);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(84, 17);
            this.lblA.Text = "Số nguyên a:";

            // txtA
            this.txtA.Location = new System.Drawing.Point(120, 36);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(250, 22);
            this.txtA.TabIndex = 0;

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 80);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(84, 17);
            this.lblB.Text = "Số nguyên b:";

            // txtB
            this.txtB.Location = new System.Drawing.Point(120, 76);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(250, 22);
            this.txtB.TabIndex = 1;

            // ===== grpOption =====
            this.grpOption.Controls.Add(this.rdoUCLN);
            this.grpOption.Controls.Add(this.rdoBCNN);
            this.grpOption.Location = new System.Drawing.Point(440, 20);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(220, 140);
            this.grpOption.TabStop = false;
            this.grpOption.Text = "Tùy chọn:";

            // rdoUCLN
            this.rdoUCLN.AutoSize = true;
            this.rdoUCLN.Location = new System.Drawing.Point(20, 40);
            this.rdoUCLN.Name = "rdoUCLN";
            this.rdoUCLN.Size = new System.Drawing.Size(77, 21);
            this.rdoUCLN.Text = "USCLN";
            this.rdoUCLN.Checked = true;
            this.rdoUCLN.TabIndex = 2;
            this.rdoUCLN.UseVisualStyleBackColor = true;

            // rdoBCNN
            this.rdoBCNN.AutoSize = true;
            this.rdoBCNN.Location = new System.Drawing.Point(20, 80);
            this.rdoBCNN.Name = "rdoBCNN";
            this.rdoBCNN.Size = new System.Drawing.Size(72, 21);
            this.rdoBCNN.Text = "BSCNN";
            this.rdoBCNN.TabIndex = 3;
            this.rdoBCNN.UseVisualStyleBackColor = true;

            // ===== Kết quả =====
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(30, 190);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(59, 17);
            this.lblKQ.Text = "Kết quả:";

            this.txtKQ.Location = new System.Drawing.Point(110, 186);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(330, 22);
            this.txtKQ.ReadOnly = true;
            this.txtKQ.TabStop = false;

            // ===== Buttons =====
            this.btnTim.Location = new System.Drawing.Point(470, 178);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(90, 34);
            this.btnTim.Text = "Tìm";
            this.btnTim.TabIndex = 4;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            this.btnThoat.Location = new System.Drawing.Point(570, 178);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 34);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TabIndex = 5;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // ===== Add controls =====
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpOption);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;

        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.RadioButton rdoUCLN;
        private System.Windows.Forms.RadioButton rdoBCNN;

        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
    }
}