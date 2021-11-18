using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
namespace DAL
{
    public class PhanCongDAO
    {
        public PhanCongDAO() { }

        public List<PhanCongDTO> ListAll(string id)
        {

            DataProvider dataProvider = new DataProvider();

            List<PhanCongDTO> phanCong = new List<PhanCongDTO>();
            string query = "select * from PHANCONG where Id_Doan = @MADOAN";
            object[] para = new object[]
            {
               id
            };
            DataTable data = dataProvider.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maDoan = item["Id_Doan"].ToString();
                string maNhanVien = item["Id_NV"].ToString();
                string nhiemVu = item["Nhiemvu"].ToString();

                PhanCongDTO newPhanCong = new PhanCongDTO(maDoan, maNhanVien, nhiemVu);

                phanCong.Add(newPhanCong);
            }
            return phanCong;
        }
        public PhanCongDTO get(string idDoan, string idNhanVien)
        {

            DataProvider dataProvider = new DataProvider();

            PhanCongDTO newPhanCong = new PhanCongDTO();
            string query = "select * from PHANCONG where Id_Doan = @MADOAN AND Id_NV = @MANHANVIEN ";
            object[] para = new object[]
            {
               idDoan,
               idNhanVien
            };
            DataTable data = dataProvider.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maDoan = item["Id_Doan"].ToString();
                string maNhanVien = item["Id_NV"].ToString();
                string nhiemVu = item["Nhiemvu"].ToString();

                newPhanCong = new PhanCongDTO(maDoan, maNhanVien, nhiemVu);
            }
            return newPhanCong;
        }

        public List<PhanCongDTO> List(string search)
        {
            DataProvider dataProvider = new DataProvider();

            List<PhanCongDTO> phanCong = new List<PhanCongDTO>();
            string query = "select * from PHANCONG where Id_Doan LIKE '%" + search + "%'";
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maDoan = item["Id_Doan"].ToString();
                string maNhanVien = item["Id_NV"].ToString();
                string nhiemVu = item["Nhiemvu"].ToString();

                PhanCongDTO newPhanCong = new PhanCongDTO(maDoan, maNhanVien, nhiemVu);

                phanCong.Add(newPhanCong);
            }
            return phanCong;
        }
        public List<PhanCongDTO> ListSearch(string search)
        {
            DataProvider dataProvider = new DataProvider();

            List<PhanCongDTO> phanCong = new List<PhanCongDTO>();
            string query = "select * from PHANCONG where Id_Doan = " + search;
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maDoan = item["Id_Doan"].ToString();
                string maNhanVien = item["Id_NV"].ToString();
                string nhiemVu = item["Nhiemvu"].ToString();

                PhanCongDTO newPhanCong = new PhanCongDTO(maDoan, maNhanVien, nhiemVu);

                phanCong.Add(newPhanCong);
            }
            return phanCong;
        }

        public bool Insert(PhanCongDTO phanCong)
        {
            string query = "insert into PHANCONG " +
                "values( @MADOAN , @MANHANVIEN , @NHIEMVU )";

            object[] para = new object[]
            {
                phanCong.Id_Doan,
                phanCong.Id_NV,
                phanCong.Nhiemvu
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Update(PhanCongDTO phanCong)
        {
            string query = "update PHANCONG set " +
                "Id_NV = @MANHANVIEN , " +
                "Nhiemvu = @NHIEMVU " +
                "where Id_Doan = @oldMADOAN AND Id_NV = @MANHANVIEN ";

            object[] para = new object[]
            {
                phanCong.Id_NV,
                phanCong.Nhiemvu,
                phanCong.Id_Doan,
                phanCong.Id_NV
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string maDoan, string maNhanVien)
        {
            string query = "delete from PHANCONG where Id_Doan = @MADOAN AND Id_NV = @MANHANVIEN ";

            object[] para = new object[]
            {
                maDoan,
                maNhanVien
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}
