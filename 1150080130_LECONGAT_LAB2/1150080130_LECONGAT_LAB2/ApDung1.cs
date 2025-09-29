using System;
using System.Windows.Forms;

namespace ApDung1
{
    public partial class ApDung1 : Form
    {
        public ApDung1()
        {
            InitializeComponent();
        }

        // ƯCLN Euclid
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        // BCNN: 0 nếu có 0; ngược lại |a*b| / UCLN
        private int BCNN(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            return Math.Abs(a * b) / UCLN(a, b);
        }

        private bool TryGetInputs(out int a, out int b)
        {
            if (!int.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Số nguyên a không hợp lệ!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus(); txtA.SelectAll(); b = 0; return false;
            }
            if (!int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Số nguyên b không hợp lệ!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus(); txtB.SelectAll(); return false;
            }
            return true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out int a, out int b)) return;

            if (rdoUCLN.Checked)
                txtKQ.Text = $"USCLN({a}, {b}) = {UCLN(a, b)}";
            else
                txtKQ.Text = $"BSCNN({a}, {b}) = {BCNN(a, b)}";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}