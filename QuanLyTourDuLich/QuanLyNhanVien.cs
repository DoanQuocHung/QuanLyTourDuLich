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
    public partial class QuanLyNhanVien : Form
    {
        DataTable dt;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            BindGrid();
            radioButton1.Checked = true;
        }

        public void BindGrid()
        {
            List<NhanVienDTO> list = new NhanVienBUS().List();
            dt = new DataTable();

            //Tạo cấu trúc bảng
            dt.Columns.AddRange(new DataColumn[6] {
                new DataColumn("Mã nhân viên"),
                new DataColumn("Họ tên"),
                new DataColumn("Email"),
                new DataColumn("SDT"),
                new DataColumn("Giới tính"),
                new DataColumn("Tình Trạng")});
            //Gán giá trị cho combobox tìm kiếm
            List<string> searchitems = new List<string> { "Mã nhân viên", "Tên", "Email","SDT" };
            SearchBox_cb.DataSource = searchitems;
            //Đưa giá trị vào datatable
            foreach (NhanVienDTO item in list)
            {
                dt.Rows.Add(item.Id_NV, item.Hoten_NV, item.Email_NV, item.Sdt_NV,item.Gioitinh_NV,item.Tinh_Trang);
            }
            //Đưa giá trị vào bảng
            Grid_Danhsachnhanvien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new QuanLyNhanVien_Them().ShowDialog();
            BindGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachnhanvien.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachnhanvien.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Mã nhân viên"].Value);
            new QuanLyNhanVien_Sua(cellValue).ShowDialog();
            BindGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachnhanvien.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachnhanvien.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Mã nhân viên"].Value);
            if (new NhanVienBUS().Delete(cellValue))
            {
                MessageBox.Show("Xóa thành công");
                BindGrid();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void SearchTour_txt_TextChanged(object sender, EventArgs e)
        {
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            string searchkey = SearchTour_txt.Text;
            DataTable searchtable = dt.Clone();
            searchtable.Clear();
            switch (typesearch)
            {
                case "Mã nhân viên":
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["Mã nhân viên"].ToString().Contains(searchkey))
                        {
                            searchtable.Rows.Add(
                                item["Mã nhân viên"],
                                item["Họ tên"],
                                item["Email"],
                                item["SDT"],
                                item["Giới tính"],
                                item["Tình Trạng"]);
                        }
                    }
                    break;
                case "Tên":
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["Họ tên"].ToString().Contains(searchkey))
                        {
                            searchtable.Rows.Add(
                                item["Mã nhân viên"],
                                item["Họ tên"],
                                item["Email"],
                                item["SDT"],
                                item["Giới tính"],
                                item["Tình Trạng"]);
                        }
                    }
                    break;
                case "Email":
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["Email"].ToString().Contains(searchkey))
                        {
                            searchtable.Rows.Add(
                                item["Mã nhân viên"],
                                item["Họ tên"],
                                item["Email"],
                                item["SDT"],
                                item["Giới tính"],
                                item["Tình Trạng"]);
                        }
                    }
                    break;
                case "SDT":
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["SDT"].ToString().Contains(searchkey))
                        {
                            searchtable.Rows.Add(
                                item["Mã nhân viên"],
                                item["Họ tên"],
                                item["Email"],
                                item["SDT"],
                                item["Giới tính"],
                                item["Tình Trạng"]);
                        }
                    }
                    break;
                default:
                    break;
            }
            Grid_Danhsachnhanvien.DataSource = searchtable;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            string searchkey = SearchTour_txt.Text;
            DataTable searchtable = dt.Clone();
            searchtable.Clear();
            if (radioButton1.Checked)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item["Tình Trạng"].ToString().Equals("đã Phân công"))
                    {
                        searchtable.Rows.Add(
                            item["Mã nhân viên"],
                            item["Họ tên"],
                            item["Email"],
                            item["SDT"],
                            item["Giới tính"],
                            item["Tình Trạng"]);
                    }
                }
            }
            else
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item["Tình Trạng"].ToString().Equals("chưa Phân công"))
                    {
                        searchtable.Rows.Add(
                            item["Mã nhân viên"],
                            item["Họ tên"],
                            item["Email"],
                            item["SDT"],
                            item["Giới tính"],
                            item["Tình Trạng"]);
                    }
                }
            }
        }
    }
}
