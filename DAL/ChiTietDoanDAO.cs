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

            List<ChiTietDoanDTO> tours = new List<ChiTietDoanDTO>();
            string query = "Select * from CHITIETDOAN where Id_Doan = @id";
            object[] para = new object[]
            {
               id
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["Id_Doan"].ToString();
                string madiadiem = item["Id_Khach"].ToString();


                ChiTietDoanDTO newTour = new ChiTietDoanDTO(matour, madiadiem);

                tours.Add(newTour);
            }
            return tours;
        }
        public ChiTietDoanDTO get(string id, string diadiem)
        {

            DataProvider datapro = new DataProvider();

            ChiTietDoanDTO newTour = new ChiTietDoanDTO();
            string query = "Select * from CHITIETDOAN where Id_Doan = @id " +
                "AND Id_Khach = @diadiem ";
            object[] para = new object[]
            {
               id,
               diadiem
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["Id_Tour"].ToString();
                string madiadiem = item["Id_Khach"].ToString();


                newTour = new ChiTietDoanDTO(matour, madiadiem);
            }
            return newTour;
        }

        public bool Insert(ChiTietDoanDTO tour)
        {
            string query = "insert into CHITIETDOAN " +
                "values( @MATOUR , @MADIADIEM )";

            object[] para = new object[]
            {
                tour.Id_Doan,
                tour.Id_Khach
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string idtour, string iddiadiem)
        {
            string query = "delete from CHITIETDOAN " +
                "where Id_Doan = @MATOUR AND Id_Khach = @MADIADIEM";

            object[] para = new object[]
            {
                idtour,
                iddiadiem,
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}
