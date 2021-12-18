using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using DTO;

namespace DAL
{
    public class PhanCongDAO
    {
        public PhanCongDAO() { }

        public List<PhanCongDTO> ListAll()
        {

            DataProvider dataProvider = new DataProvider();

            List<PhanCongDTO> phanCong = new List<PhanCongDTO>();
            string query = "select * from PHANCONG";

            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string maDoan = item["Id_Doan"].ToString();
                    string maNhanVien = item["Id_NV"].ToString();
                    string nhiemVu = item["Nhiemvu"].ToString();

                    PhanCongDTO newPhanCong = new PhanCongDTO(maDoan, maNhanVien, nhiemVu);

                    phanCong.Add(newPhanCong);
                }
            }
            catch (Exception ex)
            {
                //Hiển thị lỗi trong Immediate Window
                Debug.WriteLine(ex.Message);
            }
            return phanCong;
        }
        public bool Update(PhanCongDTO phanCong, string oldId_Doan, string oldId_NV)
        {
            string query = "update PHANCONG set " +
                "Id_Doan = @MADOAN , " +
                "Id_NV = @MANHANVIEN , " +
                "Nhiemvu = @NHIEMVU " +
                "where Id_Doan = @oldMADOAN AND Id_NV = @oldMANHANVIEN ";

            object[] para = new object[]
            {
                phanCong.Id_Doan,
                phanCong.Id_NV,
                phanCong.Nhiemvu,
                oldId_Doan,
                oldId_NV
            };
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
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
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
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
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
