using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUS
{
    public class LoaiTourBUS
    {

        public LoaiTourBUS() { }
        private static LoaiTourDAO dao = new LoaiTourDAO();
        public void List(ComboBox data)
        {
            LoaiTourDAO dao = new LoaiTourDAO();

            /*foreach (LoaiTourDTO item in dao.List())
            {
                data.Items.Add(item.Ten_Loai);
            }*/
            data.Items.Add("123456");
        }
       /* public bool Update(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string matour = row.Cells["MATOUR"].Value.ToString();
            string tentour = row.Cells["TENTOUR"].Value.ToString();
            string dacdiem = row.Cells["DACDIEM"].Value.ToString();
            string maloai = row.Cells["MALOAI"].Value.ToString();

            TourDTO tour = new TourDTO(matour, tentour, dacdiem, maloai);

            return dao.Update(matour, tour);
        }

        public bool Insert(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string matour = row.Cells["MATOUR"].Value.ToString();
            string tentour = row.Cells["TENTOUR"].Value.ToString();
            string dacdiem = row.Cells["DACDIEM"].Value.ToString();
            string maloai = row.Cells["MALOAI"].Value.ToString();

            TourDTO tour = new TourDTO(matour, tentour, dacdiem, maloai);

            return dao.Update(matour, tour);
        }
        public bool Delete(string data)
        {
            return dao.Delete(data);
        }*/
    }
}
