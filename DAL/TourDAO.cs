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

            string query = "select * from TOUR";

            DataTable data = DataProvider.instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["MATOUR"].ToString();
                string tentour = item["TENTOUR"].ToString();
                string dacdiem = item["DACDIEM"].ToString();
                string maloai = item["MALOAI"].ToString();

                TourDTO newTour = TourDTO(matour, tentour, dacdiem, maloai);

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
                tour.matour, 
                tour.tentour, 
                tour.dacdiem, 
                tour.maloai, 
                matour 
            };

            if (DataProvider.instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}
