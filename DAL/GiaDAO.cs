using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
namespace DAL
{
    public class GiaDAO
    {
        public GiaDAO() { }

        public List<GiaDTO> List()
        {
            List<GiaDTO> list = new List<GiaDTO>();
            try 
            {
                DataProvider data = new DataProvider();
                string query = "SELECT * from GIA";

                DataTable table = data.ExecuteQuery(query);
                foreach(DataRow item in table.Rows)
                {
                    string id = item["Id_Gia"].ToString();
                    string idtour = item["Id_Tour"].ToString();
                    string gia = item["Gia"].ToString();
                    string thoigianbatdau = item["Thoigianbatdau"].ToString();
                    string thoigianketthuc = item["Thoigianketthuc"].ToString();

                    GiaDTO itemgia = new GiaDTO(id,idtour,gia,thoigianbatdau,thoigianketthuc);
                    list.Add(itemgia);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi xảy ra ở List GiaDAO: \n"+ e.Message);
            }
            return list;
        }
        public bool Update(GiaDTO gia)
        {
            string query = "update GIA set " +
               "Id_Gia = @idgia , " +
               "Id_Tour = @idtour , " +
               "Gia = @gia " +
               "Thoigianbatdau = @begin " +
               "Thoigianketthuc = @end " +
               "where Id_Gia = @idgia";

            object[] para = new object[]
            {
                gia.Id_Gia,
                gia.Id_Tour,
                gia.Gia,
                gia.Thoigianbatdau,
                gia.Thoigianketthuc,
                gia.Id_Gia
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        /*public bool Delete(string idgia)
        {
            bool result = false;
            string query = "update GIA set " +
              "Id_Gia = @idgia , " +
              "Id_Tour = @idtour , " +
              "Gia = @gia " +
              "Thoigianbatdau = @begin " +
              "Thoigianketthuc = @end " +
              "where Id_Gia = @idgia";

            object[] para = new object[]
            {
                gia.Id_Gia,
                gia.Id_Tour,
                gia.Gia,
                gia.Thoigianbatdau,
                gia.Thoigianketthuc,
                gia.Id_Gia
            };
            DataProvider datapro = new DataProvider();
            if (datapro.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
            return result;
        }*/
        public bool Insert()
        {
            bool result = false;

            return result;
        }
    }
}
