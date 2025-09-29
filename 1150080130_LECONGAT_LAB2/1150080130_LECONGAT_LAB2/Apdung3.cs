using System;
using System.Windows.Forms;

namespace ApDung3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Ẩn hiện mật khẩu
            chkShowPassword.CheckedChanged += (s, e) =>
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool ok = true;

            // Xóa lỗi cũ
            errorProvider1.SetError(txtUsername, "");
            errorProvider1.SetError(txtPassword, "");

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Username không được để trống");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password không được để trống");
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password.",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yêu cầu bài: chỉ kiểm tra không để trống. 
            // Bạn có thể bổ sung xác thực thật ở đây (gọi DB/API).
            MessageBox.Show("Đăng nhập hợp lệ (đã nhập đủ thông tin).",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // this.DialogResult = DialogResult.OK; // nếu dùng như hộp login
            // Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}