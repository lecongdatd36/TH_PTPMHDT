namespace ApDung2
{
    partial class ApDung2
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpKeyboard = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button(); this.btn2 = new System.Windows.Forms.Button(); this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button(); this.btn5 = new System.Windows.Forms.Button(); this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button(); this.btn8 = new System.Windows.Forms.Button(); this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button(); this.btnEnter = new System.Windows.Forms.Button(); this.btnRing = new System.Windows.Forms.Button();
            this.grpLog = new System.Windows.Forms.GroupBox(); this.dgvLog = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpKeyboard.SuspendLayout(); this.grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit(); this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.AcceptButton = this.btnEnter; this.CancelButton = this.btnRing;

            // Password label
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 20);
            this.lblPassword.Name = "lblPassword"; this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.Text = "Password:";

            // Password textbox
            this.txtPassword.Location = new System.Drawing.Point(100, 17);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 22);
            this.txtPassword.UseSystemPasswordChar = true;

            // Group Keyboard
            this.grpKeyboard.Controls.Add(this.btn1); this.grpKeyboard.Controls.Add(this.btn2); this.grpKeyboard.Controls.Add(this.btn3);
            this.grpKeyboard.Controls.Add(this.btn4); this.grpKeyboard.Controls.Add(this.btn5); this.grpKeyboard.Controls.Add(this.btn6);
            this.grpKeyboard.Controls.Add(this.btn7); this.grpKeyboard.Controls.Add(this.btn8); this.grpKeyboard.Controls.Add(this.btn9);
            this.grpKeyboard.Controls.Add(this.btnClear); this.grpKeyboard.Controls.Add(this.btnEnter); this.grpKeyboard.Controls.Add(this.btnRing);
            this.grpKeyboard.Location = new System.Drawing.Point(20, 55);
            this.grpKeyboard.Name = "grpKeyboard"; this.grpKeyboard.Size = new System.Drawing.Size(480, 180);
            this.grpKeyboard.TabStop = false; this.grpKeyboard.Text = "Keyboard:";

            // Buttons 1..9
            int size = 50;
            this.btn1.Location = new System.Drawing.Point(20, 30); this.btn1.Size = new System.Drawing.Size(size, size); this.btn1.Text = "1"; this.btn1.Click += new System.EventHandler(this.Number_Click);
            this.btn2.Location = new System.Drawing.Point(80, 30); this.btn2.Size = new System.Drawing.Size(size, size); this.btn2.Text = "2"; this.btn2.Click += new System.EventHandler(this.Number_Click);
            this.btn3.Location = new System.Drawing.Point(140, 30); this.btn3.Size = new System.Drawing.Size(size, size); this.btn3.Text = "3"; this.btn3.Click += new System.EventHandler(this.Number_Click);
            this.btn4.Location = new System.Drawing.Point(20, 90); this.btn4.Size = new System.Drawing.Size(size, size); this.btn4.Text = "4"; this.btn4.Click += new System.EventHandler(this.Number_Click);
            this.btn5.Location = new System.Drawing.Point(80, 90); this.btn5.Size = new System.Drawing.Size(size, size); this.btn5.Text = "5"; this.btn5.Click += new System.EventHandler(this.Number_Click);
            this.btn6.Location = new System.Drawing.Point(140, 90); this.btn6.Size = new System.Drawing.Size(size, size); this.btn6.Text = "6"; this.btn6.Click += new System.EventHandler(this.Number_Click);
            this.btn7.Location = new System.Drawing.Point(20, 150); this.btn7.Size = new System.Drawing.Size(size, size); this.btn7.Text = "7"; this.btn7.Click += new System.EventHandler(this.Number_Click);
            this.btn8.Location = new System.Drawing.Point(80, 150); this.btn8.Size = new System.Drawing.Size(size, size); this.btn8.Text = "8"; this.btn8.Click += new System.EventHandler(this.Number_Click);
            this.btn9.Location = new System.Drawing.Point(140, 150); this.btn9.Size = new System.Drawing.Size(size, size); this.btn9.Text = "9"; this.btn9.Click += new System.EventHandler(this.Number_Click);

            // Clear
            this.btnClear.Location = new System.Drawing.Point(220, 30);
            this.btnClear.Size = new System.Drawing.Size(90, size);
            this.btnClear.BackColor = System.Drawing.Color.Yellow; this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Enter
            this.btnEnter.Location = new System.Drawing.Point(220, 90);
            this.btnEnter.Size = new System.Drawing.Size(90, size);
            this.btnEnter.BackColor = System.Drawing.Color.LimeGreen; this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            // Ring
            this.btnRing.Location = new System.Drawing.Point(220, 150);
            this.btnRing.Size = new System.Drawing.Size(90, size);
            this.btnRing.BackColor = System.Drawing.Color.Red; this.btnRing.ForeColor = System.Drawing.Color.White;
            this.btnRing.Text = "RING";
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);

            // Log group & grid
            this.grpLog.Controls.Add(this.dgvLog);
            this.grpLog.Location = new System.Drawing.Point(20, 250);
            this.grpLog.Size = new System.Drawing.Size(640, 200);
            this.grpLog.Text = "Login Log:";

            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colTime, this.colGroup, this.colResult });

            this.colTime.HeaderText = "Ngày giờ"; this.colTime.Width = 200;
            this.colGroup.HeaderText = "Nhóm"; this.colGroup.Width = 200;
            this.colResult.HeaderText = "Kết quả"; this.colResult.Width = 200;

            // Add controls
            this.Controls.Add(this.lblPassword); this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.grpKeyboard); this.Controls.Add(this.grpLog);

            this.grpKeyboard.ResumeLayout(false); this.grpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpKeyboard;
        private System.Windows.Forms.Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        private System.Windows.Forms.Button btnClear, btnEnter, btnRing;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime, colGroup, colResult;
    }
}