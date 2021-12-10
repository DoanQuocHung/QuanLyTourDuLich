using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTourDuLich
{
    public partial class QuanLyKhachHang : Form
    {
        List<KhachDTO> list;

        public QuanLyKhachHang()
        {
            InitializeComponent();
            Grid_Danhsachkhachhang.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Khách hàng", "Họ Tên", "CMND/CCCD",
                "Địa chỉ", "Giới tính", "Số điện thoại", "Quốc tịch"};
            SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }
        public void BindGrid(List<KhachDTO> list)
        {
            Grid_Danhsachkhachhang.Rows.Clear();
            Grid_Danhsachkhachhang.Refresh();
            list = new KhachHangBUS().List();
            foreach (KhachDTO item in list)
            {
                Grid_Danhsachkhachhang.Rows.Add(item.Id_Khach,item.Hoten_Khach, item.Cmnd_Khach
                    , item.Diachi_Khach, item.Gioitinh_Khach, item.Sdt_Khach, item.Quoctich, item.Tinh_Trang);
            }
            this.list = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyKhachHang_Them(list))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    list = form.list;
                    BindGrid(list);
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachkhachhang.RowCount != 0)

            {
                int selectedrowindex = Grid_Danhsachkhachhang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachkhachhang.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_KhachC"].Value);

                using (var form = new QuanLyKhachHang_Sua(list, cellValue))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        list = form.list;
                        BindGrid(list);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachkhachhang.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachkhachhang.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_KhachC"].Value);

            if (new KhachHangBUS().Delete(cellValue))
            {
                MessageBox.Show("Xóa thành công");
            }
            BindGrid(list);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindGrid(list);

        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            string searchkey = txtSearch.Text;
            List<KhachDTO> listsearch = new List<KhachDTO>();
            switch (typesearch)
            {
                case "Mã Khách hàng":
                    listsearch = list.FindAll(x => x.Id_Khach.Contains(searchkey));
                    break;
                case "Họ tên":
                    listsearch = list.FindAll(x => x.Id_Khach.Contains(searchkey));
                    break;
                case "CMND/CCCD":
                    listsearch = list.FindAll(x => x.Id_Khach.Contains(searchkey));
                    break;
                case "Địa chỉ":
                    listsearch = list.FindAll(x => x.Id_Khach.Contains(searchkey));
                    break;
                case "Giới tính":
                    listsearch = list.FindAll(x => x.Id_Khach.Contains(searchkey));
                    break;
                case "Số điện thoại":
                    listsearch = list.FindAll(x => x.Id_Khach.Contains(searchkey));
                    break;
                case "Quốc tịch":
                    listsearch = list.FindAll(x => x.Id_Khach.Contains(searchkey));
                    break;
                default:
                    break;
            }
            BindGrid(listsearch);
        }
    }
}
