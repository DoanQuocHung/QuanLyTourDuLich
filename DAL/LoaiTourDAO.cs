using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
namespace DAL
{
    public class LoaiTourDAO
    {
        public LoaiTourDAO() { }
        private static DataProvider dataget = new DataProvider();
        public List<LoaiTourDTO> List()
        {
            List<LoaiTourDTO> loaitours = new List<LoaiTourDTO>();

            string query = "select * from LOAITOUR";


            DataTable data = dataget.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maloai = item["Id_Loai"].ToString();
                string tenloai = item["Ten_Loai"].ToString();

                LoaiTourDTO newloai = new LoaiTourDTO(maloai, tenloai);

                loaitours.Add(newloai);
            }

            return loaitours;
        }
    }
}
