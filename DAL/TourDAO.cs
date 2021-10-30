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
        public static TourDAO instance;

        public TourDAO Instance
        {
            get {
                if (instance == null)
                    instance = new TourDAO();
                return instance; 
            }
        }

        private TourDAO() { }

        public List<TourDTO> List()
        {
            List<TourDTO> tours = new List<TourDTO>();
            string query = "Select * from TOUR";

            DataTable data = DataProvider.instance.ExecuteQuery(query);

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

        public bool Update(string matour, TourDTO tour)
        {
            string query = "update TOUR set " +
                "MATOUR = @MATOUR, " +
                "TENTOUR = @TENTOUR, " +
                "DACDIEM = @DACDIEM, " +
                "MALOAI = @MALOAI " +
                "where MATOUR = @oldMATOUR";

            object[] para = new object[]
            {
                tour.Id_Tour,
                tour.Ten_Tour,
                tour.Dacdiem_Tour,
                tour.Id_Loai,
                matour 
            };

            if (DataProvider.instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Insert(TourDTO tour)
        {
            string query = "insert into TOUR " +
                "values (@MATOUR,@TENTOUR,@DACDIEM,@MALOAI)";

            object[] para = new object[]
            {
                tour.Id_Tour,
                tour.Ten_Tour,
                tour.Dacdiem_Tour,
                tour.Id_Loai
            };

            if (DataProvider.instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string id)
        {
            string query = "delete from TOUR where MATOUR = @MATOUR";

            object[] para = new object[]
            {
                id
            };

            if (DataProvider.instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}
