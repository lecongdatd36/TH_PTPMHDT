using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ApDung4
{
    public partial class FrmChonMatHang : Form
    {
        public FrmChonMatHang()
        {
            InitializeComponent();

            // Khởi tạo danh sách bên trái
            lstNguon.Items.AddRange(new object[]
            {
                "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN"
            });

            // Double-click để chuyển nhanh
            lstNguon.DoubleClick += (s, e) => BtnMoveRight_Click(s, e);
            lstDich.DoubleClick += (s, e) => BtnMoveLeft_Click(s, e);
        }

        private void BtnMoveRight_Click(object sender, EventArgs e) => MoveSelected(lstNguon, lstDich);
        private void BtnMoveAllRight_Click(object sender, EventArgs e) => MoveAll(lstNguon, lstDich);
        private void BtnMoveLeft_Click(object sender, EventArgs e) => MoveSelected(lstDich, lstNguon);
        private void BtnMoveAllLeft_Click(object sender, EventArgs e) => MoveAll(lstDich, lstNguon);

        // Chuyển các phần tử đang chọn
        private void MoveSelected(ListBox from, ListBox to)
        {
            if (from.SelectedItems.Count == 0) return;

            // Lấy snapshot trước khi xóa
            var items = from.SelectedItems.Cast<object>().ToList();

            foreach (var it in items)
            {
                if (!to.Items.Contains(it)) to.Items.Add(it); // tránh trùng
                from.Items.Remove(it);
            }

            from.ClearSelected();
            to.ClearSelected();
        }

        // Chuyển toàn bộ
        private void MoveAll(ListBox from, ListBox to)
        {
            if (from.Items.Count == 0) return;

            var items = from.Items.Cast<object>().ToList();
            foreach (var it in items)
                if (!to.Items.Contains(it)) to.Items.Add(it);

            from.Items.Clear();
            from.ClearSelected();
            to.ClearSelected();
        }
    }
}