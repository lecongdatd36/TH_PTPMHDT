using System;
using System.Globalization;
using System.Windows.Forms;

namespace ThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Khóa số lượng khi chưa tick
            numHanRang.Enabled = chkHanRang.Checked;
            numBeRang.Enabled = chkBeRang.Checked;
            numBocRang.Enabled = chkBocRang.Checked;

            // Gán sự kiện bật/tắt NumericUpDown theo CheckBox
            chkHanRang.CheckedChanged += (s, e) => numHanRang.Enabled = chkHanRang.Checked;
            chkBeRang.CheckedChanged += (s, e) => numBeRang.Enabled = chkBeRang.Checked;
            chkBocRang.CheckedChanged += (s, e) => numBocRang.Enabled = chkBocRang.Checked;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // Validate tên KH
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                errorProvider1.SetError(txtTenKH, "Tên khách hàng không được để trống.");
                txtTenKH.Focus();
                return;
            }
            errorProvider1.SetError(txtTenKH, "");

            double tongTien = 0;

            if (chkCaoRang.Checked) tongTien += 50_000;      // 2 hàm
            if (chkTayTrang.Checked) tongTien += 100_000;    // 2 hàm
            if (chkHanRang.Checked) tongTien += 100_000 * (int)numHanRang.Value;
            if (chkBeRang.Checked) tongTien += 10_000 * (int)numBeRang.Value;
            if (chkBocRang.Checked) tongTien += 1_000_000 * (int)numBocRang.Value;

            // Định dạng VN
            var vn = new CultureInfo("vi-VN");
            string tien = string.Format(vn, "{0:c0}", tongTien);

            MessageBox.Show($"Khách hàng: {txtTenKH.Text}\nTổng tiền: {tien}",
                            "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}