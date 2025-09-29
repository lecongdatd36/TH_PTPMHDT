using System;
using System.Windows.Forms;

namespace _1150080130_LECONGAT_LAB2
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private bool TryGetNumbers(out double a, out double b)
        {
            if (!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Số a không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus(); txtA.SelectAll(); b = 0; return false;
            }
            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Số b không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus(); txtB.SelectAll(); return false;
            }
            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!TryGetNumbers(out double a, out double b)) return;
            txtKQ.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!TryGetNumbers(out double a, out double b)) return;
            txtKQ.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!TryGetNumbers(out double a, out double b)) return;
            txtKQ.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!TryGetNumbers(out double a, out double b)) return;
            if (b == 0)
                MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                txtKQ.Text = (a / b).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear(); txtB.Clear(); txtKQ.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}