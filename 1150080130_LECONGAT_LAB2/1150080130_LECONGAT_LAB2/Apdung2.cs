using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ApDung2   // đổi cho khớp namespace project của bạn nếu khác
{
    public partial class ApDung2 : Form
    {
        // Bảng password -> nhóm
        private readonly Dictionary<string, string> passToGroup = new Dictionary<string, string>
        {
            { "1496", "Phát triển công nghệ" },
            { "2673", "Phát triển công nghệ" },
            { "7462", "Nghiên cứu viên" },
            { "8884", "Thiết kế mô hình"   },
            { "3842", "Thiết kế mô hình"   },
            { "3383", "Thiết kế mô hình"   },
        };

        public ApDung2()
        {
            InitializeComponent();

            // Setup textbox & grid nếu cần
            txtPassword.UseSystemPasswordChar = true;

            if (dgvLog.Columns.Count == 0)
            {
                dgvLog.RowHeadersVisible = false;
                dgvLog.Columns.Add("colTime", "Ngày giờ");
                dgvLog.Columns.Add("colGroup", "Nhóm");
                dgvLog.Columns.Add("colResult", "Kết quả");
                dgvLog.Columns["colTime"].Width = 200;
                dgvLog.Columns["colGroup"].Width = 220;
                dgvLog.Columns["colResult"].Width = 160;
            }
        }

        private void AppendLog(string group, string result)
        {
            // "g" -> dd/MM/yyyy HH:mm (tuỳ culture máy); có thể đổi sang "dd/MM/yyyy HH:mm:ss"
            dgvLog.Rows.Add(DateTime.Now.ToString("g"), group, result);
            // Auto scroll xuống cuối
            if (dgvLog.Rows.Count > 0)
            {
                int last = dgvLog.Rows.Count - 1;
                dgvLog.FirstDisplayedScrollingRowIndex = last;
                dgvLog.Rows[last].Selected = true;
            }
        }

        // Gán event Click của các nút số 1..9 vào handler này
        private void Number_Click(object sender, EventArgs e)
        {
            if (sender is Button btn) txtPassword.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = txtPassword.Text.Trim();

            if (passToGroup.TryGetValue(input, out string group))
            {
                // Chấp nhận
                AppendLog(group, "Chấp nhận!");
                MessageBox.Show($"Chào mừng nhóm: {group}", "Access Granted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Từ chối
                AppendLog("Không có", "Từ chối!");
                MessageBox.Show("Sai mật khẩu!", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            // Giả lập báo động
            System.Media.SystemSounds.Hand.Play();
            MessageBox.Show("🔔 Báo động!", "RING", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}