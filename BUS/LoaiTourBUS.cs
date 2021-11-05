using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Windows.Forms;
namespace BUS
{
    public class LoaiTourBUS
    {
        public LoaiTourBUS() { }

        private LoaiTourDAO dao = new LoaiTourDAO();
        public void List(ComboBox data)
        {
            data.DataSource = dao.List();
        }
        public string get(string tenloai)
        {
            return dao.get(tenloai);
        }
    }
}
