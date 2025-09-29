using System;
using System.Linq;
using System.Windows.Forms;

namespace ThucHanh3
{
    public partial class frmXuLySo : Form
    {
        public frmXuLySo()
        {
            InitializeComponent();
        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text, out int so))
            {
                lsbDaySo.Items.Add(so);
                txtSo.Clear();
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                lsbDaySo.Items[i] = so + 2;
            }
        }

        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                if (so % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int so = Convert.ToInt32(lsbDaySo.Items[i]);
                if (so % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex >= 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}