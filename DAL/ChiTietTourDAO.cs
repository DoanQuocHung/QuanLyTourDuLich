using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
namespace DAL
{
    public class ChiTietTourDAO
    {
        public ChiTietTourDAO() { }

        public List<ChiTietTourDTO> ListAll(string id)
        {

            DataProvider datapro = new DataProvider();

            List<ChiTietTourDTO> tours = new List<ChiTietTourDTO>();
            string query = "Select * from CHITIETTOUR";

            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["Id_Tour"].ToString();
                string madiadiem = item["Id_DiaDiem"].ToString();
                int thutu = Int32.Parse(item["Thutu"].ToString());
                

                ChiTietTourDTO newTour = new ChiTietTourDTO(matour, madiadiem, thutu);

                tours.Add(newTour);
            }
            return tours;
        }
        public ChiTietTourDTO get(string id)
        {

            DataProvider datapro = new DataProvider();

            ChiTietTourDTO newTour = new ChiTietTourDTO();
            string query = "Select * from CHITIETTOUR where Id_Tour = @id";
            object[] para = new object[]
            {
               id
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["Id_Tour"].ToString();
                string madiadiem = item["Id_DiaDiem"].ToString();
                int thutu = Int32.Parse(item["Thutu"].ToString());


                newTour = new ChiTietTourDTO(matour, madiadiem, thutu);
            }
            return newTour;
        }
        public bool Update(string matour, ChiTietTourDTO tour)
        {
            string query = "update CHITIETTOUR set " +
                "Id_Tour = @id , " +
                "Id_DiaDiem = @DIADIEM , " +
                "Thutu = @thutu " +
                "where Id_Tour = @oldMATOUR";

            object[] para = new object[]
            {
                tour.Id_Tour,
                tour.Id_DiaDiem,
                tour.Thutu,
                matour
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Insert(ChiTietTourDTO tour)
        {
            string query = "insert into CHITIETTOUR " +
                "values( @MATOUR , @MADIADIEM , @THUTU )";

            object[] para = new object[]
            {
                tour.Id_Tour,
                tour.Id_DiaDiem,
                tour.Thutu
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string idtour,string iddiadiem)
        {
            string query = "delete from CHITIETTOUR where Id_Tour = @MATOUR AND Id_Diadiem = @MADIADIEM";

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
