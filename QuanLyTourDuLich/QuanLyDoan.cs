﻿using System;
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
    public partial class QuanLyDoan : Form
    {
        List<DoanDuLichDTO> list;
        List<TourDTO> listTenTour;
        public QuanLyDoan()
        {
            InitializeComponent();
            list = new DoanDuLichBUS().List();
            listTenTour = new TourBUS().List();
            Grid_Danhsachdoan.AutoGenerateColumns = false;
            BindGrid(list);
        }
        public void BindGrid(List<DoanDuLichDTO> list)
        {
            Grid_Danhsachdoan.Rows.Clear();
            Grid_Danhsachdoan.Refresh();
            foreach (DoanDuLichDTO item in list)
            {
                string tentour = listTenTour.Find(x => x.Id_Tour.Equals(item.Id_Tour)).Ten_Tour;
                Grid_Danhsachdoan.Rows.Add(item.Id_Doan, item.Ten_Doan, tentour, item.Ngaykhoihanh, item.Ngayketthuc, item.Doanhthu, item.Noidung);
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyDoan_Them(list, listTenTour))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachdoan.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                using (var form = new QuanLyDoan_Sua(list, listTenTour, cellValue))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.list = form.list;
                        BindGrid(list);
                    }
                }
            }
        }

        //Button Xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);

            if (new DoanDuLichBUS().Delete(cellValue))
            {
                MessageBox.Show("Xóa thành công");
                list.RemoveAll(x => x.Id_Doan.Equals(cellValue));
                BindGrid(list);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindGrid(list);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text;
            List<DoanDuLichDTO> listsearch = new List<DoanDuLichDTO>();
            listsearch = list.FindAll(x => x.Ten_Doan.Contains(search));
            BindGrid(listsearch);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachdoan.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                QuanLyChiTietDoan ql_ctt = new QuanLyChiTietDoan(cellValue);
                ql_ctt.ShowDialog();
            }
        }
    }
}
