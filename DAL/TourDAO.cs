using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
using System.Windows.Forms;
namespace DAL
{
    public class TourDAO
    {
        public TourDAO() { }

        public List<TourDTO> List()
        {

            DataProvider datapro = new DataProvider();
            
            List<TourDTO> tours = new List<TourDTO>();
            string query = "Select * from TOUR";

            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["Id_Tour"].ToString();
                string tentour = item["Ten_Tour"].ToString();
                string dacdiem = item["Dacdiem_Tour"].ToString();
                string maloai = item["Id_Loai"].ToString();

                TourDTO newTour = new TourDTO(matour, tentour, dacdiem, maloai);

                tours.Add(newTour);
            }
            return tours;
        }
        public TourDTO get(string id)
        {

            DataProvider datapro = new DataProvider();

            TourDTO newTour = new TourDTO();
            string query = "Select * from TOUR where Id_Tour = @id";
            object[] para = new object[]
            {
               id
            };
            DataTable data = datapro.ExecuteQuery(query,para);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["Id_Tour"].ToString();
                string tentour = item["Ten_Tour"].ToString();
                string dacdiem = item["Dacdiem_Tour"].ToString();
                string maloai = item["Id_Loai"].ToString();

                newTour = new TourDTO(matour, tentour, dacdiem, maloai);
            }
            return newTour;
        }
        public bool Update(string matour, TourDTO tour)
        {
            string query = "update TOUR set " +
                "Ten_Tour = @TENTOUR , " +
                "Dacdiem_Tour = @DACDIEM , " +
                "Id_Loai = @MALOAI " +
                "where Id_Tour = @oldMATOUR";

            object[] para = new object[]
            {
                tour.Ten_Tour,
                tour.Dacdiem_Tour,
                tour.Id_Loai,
                matour 
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Insert(TourDTO tour)
        {
            string query = "insert into TOUR " +
                "values( @MATOUR , @TENTOUR , @DACDIEM , @MALOAI )";

            object[] para = new object[]
            {
                tour.Id_Tour,
                tour.Ten_Tour,
                tour.Dacdiem_Tour,
                tour.Id_Loai
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string id)
        {
            string query = "delete from TOUR where Id_Tour = @MATOUR";

            object[] para = new object[]
            {
                id
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}
