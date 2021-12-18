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
    public partial class QuanLyChiTietDoan : Form
    {
        string id;
        List<ChiTietDoanDTO> list;
        List<KhachDTO> listkhach;
        public QuanLyChiTietDoan(string id)
        {
            InitializeComponent();
            this.id = id;
            list = new ChiTietDoanBUS().List(id);
            listkhach = new KhachHangBUS().List();
            dataGridView_CT_Doan.AutoGenerateColumns = false;
            BindGrid(list);
        }
        public void BindGrid(List<ChiTietDoanDTO> list)
        {
            dataGridView_CT_Doan.Rows.Clear();
            dataGridView_CT_Doan.Refresh();
            foreach (ChiTietDoanDTO item in list)
            {
                string tenkhach = listkhach.Find(x => x.Id_Khach.Equals(item.Id_Khach)).Hoten_Khach;
                string cmndkhach = listkhach.Find(x => x.Id_Khach.Equals(item.Id_Khach)).Cmnd_Khach;
                dataGridView_CT_Doan.Rows.Add(item.Id_Khach, tenkhach, cmndkhach);
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyChiTietDoan_Them(list, listkhach, id))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_CT_Doan.RowCount != 0)
            {
                int selectedrowindex = dataGridView_CT_Doan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_CT_Doan.Rows[selectedrowindex];
                string cellValue = id;
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_Khach"].Value);
                if (new ChiTietDoanBUS().Delete(cellValue, cellValue2))
                {
                    MessageBox.Show("Xóa chi tiết thành công");
                    list.RemoveAll(x => x.Id_Khach.Equals(cellValue2));
                    BindGrid(list);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(list);
        }

    }
}
