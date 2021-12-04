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
        DataProvider datapro = new DataProvider();
        public TourDAO() { }

        public List<TourDTO> ListAll()
        {
            List<TourDTO> tours = new List<TourDTO>();
            try
            {
                string query = "Select * from TOUR";

                DataTable data = datapro.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string matour = item["Id_Tour"].ToString();
                    string tentour = item["Ten_Tour"].ToString();
                    string dacdiem = item["Dacdiem_Tour"].ToString();
                    string maloai = item["Id_Loai"].ToString();
                    int trangthai = Int32.Parse(item["TrangThaiTour"].ToString());

                    TourDTO newTour = new TourDTO(matour, tentour, dacdiem, maloai, trangthai);

                    tours.Add(newTour);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll "+e);
            }
            return tours;
        }
        public bool Update(TourDTO tour)
        {
            string query = "update TOUR set " +
                "Ten_Tour = @TENTOUR , " +
                "Dacdiem_Tour = @DACDIEM , " +
                "Id_Loai = @MALOAI ," +
                 " TrangThaiTour = @trangthai " +
                "where Id_Tour = @oldMATOUR";

            object[] para = new object[]
            {
                tour.Ten_Tour,
                tour.Dacdiem_Tour,
                tour.Id_Loai,
                tour.TrangThai,
                tour.Id_Tour
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Insert(TourDTO tour)
        {
            string query = "insert into TOUR " +
                "values( @MATOUR , @TENTOUR , @DACDIEM , @MALOAI , @TRANGTHAI)";

            object[] para = new object[]
            {
                tour.Id_Tour,
                tour.Ten_Tour,
                tour.Dacdiem_Tour,
                tour.Id_Loai,
                tour.TrangThai
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string id)
        {
            string query = "delete from TOUR where Id_Tour = @MATOUR";
            string query2 = "delete from CHITIETTOUR where Id_Tour = @MATOUR";
            object[] para = new object[]
            {
                id
            };
            DataProvider datapro = new DataProvider();
            datapro.ExecuteNonQuery(query2, para);
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            return false;
        }
        public int Count()
        {
            string query = "select count(*) from TOUR";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from TOUR where Id_Tour = '"+id+"'";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public String MakeID()
        {
            String id = "";
            int count = Count();
            while (true)
            {
                id = "T" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
