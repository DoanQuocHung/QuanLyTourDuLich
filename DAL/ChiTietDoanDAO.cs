using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAL
{
    public class ChiTietDoanDAO
    {
        public ChiTietDoanDAO() { }

        public List<ChiTietDoanDTO> ListAll(string id)
        {

            DataProvider datapro = new DataProvider();

            List<ChiTietDoanDTO> chitietdoans = new List<ChiTietDoanDTO>();
            string query = "Select * from CHITIETDOAN where Id_Doan = @id ";
            object[] para = new object[]
            {
               id
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string madoan = item["Id_Doan"].ToString();
                string makhach = item["Id_Khach"].ToString();

                ChiTietDoanDTO newChitietdoan = new ChiTietDoanDTO(madoan, makhach);

                chitietdoans.Add(newChitietdoan);
            }
            return chitietdoans;
        }
        public ChiTietDoanDTO get(string iddoan, string idkhach)
        {

            DataProvider datapro = new DataProvider();

            ChiTietDoanDTO newChitietdoan = new ChiTietDoanDTO();
            string query = "Select * from CHITIETDOAN where Id_Doan = @iddoan " +
                " AND Id_Khach = @idkhach ";
            object[] para = new object[]
            {
               iddoan,
               idkhach
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string madoan = item["Id_Doan"].ToString();
                string makhach = item["Id_Khach"].ToString();

                newChitietdoan = new ChiTietDoanDTO(madoan, makhach);

            }
            return newChitietdoan;
        }

        public bool Insert(ChiTietDoanDTO doan)
        {
            string query = "insert into CHITIETDOAN " +
                "values( @MADOAN , @MAKHACH )";

            object[] para = new object[]
            {
                doan.Id_Doan,
                doan.Id_Khach
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string iddoan, string idkhach)
        {
            string query = "delete from CHITIETDOAN " +
                "where Id_Doan = @MADOAN AND Id_Khach = @MAKHACH ";

            object[] para = new object[]
            {
                iddoan,
                idkhach,
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}
