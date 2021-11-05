using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Windows.Forms;
namespace DAL
{
    public class LoaiTourDAO
    {
        public LoaiTourDAO() { }

        public List<string> List()
        {

            DataProvider datapro = new DataProvider();

            List<string> tours = new List<string>();
            string query = "Select * from LOAITOUR";

            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maloai = item["Id_Loai"].ToString();
                string tenloai = item["Ten_Loai"].ToString();

                LoaiTourDTO newTour = new LoaiTourDTO(maloai, tenloai);

                tours.Add(tenloai);
            }
            return tours;
        }
        public string  get(string tenloai)
        {

            DataProvider datapro = new DataProvider();
            string query = "Select Id_Loai from LOAITOUR where Ten_Loai = @tenloai";
            object[] para = new object[]
            {
                tenloai
            };
            string maloai = " ";
            var firstColumn = datapro.ExecuteScalar(query,para);
            if (firstColumn != null)
            {
                maloai = firstColumn.ToString();
            }
            return maloai;
        }
    }
}
