using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;

namespace DAL
{
    public class NhanVienDAO
    {
        public NhanVienDAO() { }

        public List<NhanVienDTO> ListAll()
        {

            DataProvider dataProvider = new DataProvider();

            List<NhanVienDTO> nhanVien = new List<NhanVienDTO>();
            string query = "Select * from NHANVIEN";

            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maNhanVien = item["Id_NV"].ToString();
                string hoTenNhanVien = item["Hoten_NV"].ToString();
                string email = item["Email_NV"].ToString();
                string sdt = item["Sdt_NV"].ToString();
                string gioiTinh = item["Gioitinh_NV"].ToString();
                int tinhTrang = (int) item["Tinh_Trang"];

                NhanVienDTO newNhanVien = new NhanVienDTO(maNhanVien, hoTenNhanVien, email, sdt, gioiTinh, tinhTrang);

                nhanVien.Add(newNhanVien);
            }
            return nhanVien;
        }
        public List<NhanVienDTO> List(string search)
        {

            DataProvider dataProvider = new DataProvider();

            List<NhanVienDTO> nhanVien = new List<NhanVienDTO>();
            string query = "Select * from NHANVIEN where Id_NV LIKE '%" + search + "%'";
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maNhanVien = item["Id_NV"].ToString();
                string hoTenNhanVien = item["Hoten_NV"].ToString();
                string email = item["Email_NV"].ToString();
                string sdt = item["Sdt_NV"].ToString();
                string gioiTinh = item["Gioitinh_NV"].ToString();
                int tinhTrang = (int)item["Tinh_Trang"];

                NhanVienDTO newNhanVien = new NhanVienDTO(maNhanVien, hoTenNhanVien, email, sdt, gioiTinh, tinhTrang);

                nhanVien.Add(newNhanVien);
            }
            return nhanVien;
        }
        public List<NhanVienDTO> ListSearch(string search)
        {
            DataProvider dataProvider = new DataProvider();

            List<NhanVienDTO> nhanVien = new List<NhanVienDTO>();
            string query = "Select * from NHANVIEN where Id_NV = " + search;
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maNhanVien = item["Id_NV"].ToString();
                string hoTenNhanVien = item["Hoten_NV"].ToString();
                string email = item["Email_NV"].ToString();
                string sdt = item["Sdt_NV"].ToString();
                string gioiTinh = item["Gioitinh_NV"].ToString();
                int tinhTrang = (int)item["Tinh_Trang"];

                NhanVienDTO newNhanVien = new NhanVienDTO(maNhanVien, hoTenNhanVien, email, sdt, gioiTinh, tinhTrang);

                nhanVien.Add(newNhanVien);
            }
            return nhanVien;
        }
        public NhanVienDTO getNhanVien(string search)
        {

            DataProvider dataProvider = new DataProvider();

            string query = "Select * from NHANVIEN where Id_NV = " + search;
            DataTable data = dataProvider.ExecuteQuery(query);
            NhanVienDTO nhanVien = new NhanVienDTO();
            foreach (DataRow item in data.Rows)
            {
                string maNhanVien = item["Id_NV"].ToString();
                string hoTenNhanVien = item["Hoten_NV"].ToString();
                string email = item["Email_NV"].ToString();
                string sdt = item["Sdt_NV"].ToString();
                string gioiTinh = item["Gioitinh_NV"].ToString();
                int tinhTrang = (int)item["Tinh_Trang"];

                nhanVien = new NhanVienDTO(maNhanVien, hoTenNhanVien, email, sdt, gioiTinh, tinhTrang);

            }
            return nhanVien;
        }
        public NhanVienDTO get(string id)
        {

            DataProvider dataProvider = new DataProvider();

            NhanVienDTO nhanVien = new NhanVienDTO();
            string query = "Select * from NHANVIEN where Id_NV = @id";
            object[] para = new object[]
            {
               id
            };
            DataTable data = dataProvider.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maNhanVien = item["Id_NV"].ToString();
                string hoTenNhanVien = item["Hoten_NV"].ToString();
                string email = item["Email_NV"].ToString();
                string sdt = item["Sdt_NV"].ToString();
                string gioiTinh = item["Gioitinh_NV"].ToString();
                int tinhTrang = (int)item["Tinh_Trang"];

                nhanVien = new NhanVienDTO(maNhanVien, hoTenNhanVien, email, sdt, gioiTinh, tinhTrang);
            }
                return nhanVien;
        }
        public bool Update(NhanVienDTO nhanVien)
        {
            string query = "update NHANVIEN set " +
                "Hoten_NV = @HOTEN , " +
                "Email_NV = @EMAIL , " +
                "Sdt_NV = @SDT ," +
                "Gioitinh_NV = @GIOITINH , " +
                "Tinh_Trang = @TINHTRANG " +
                "where Id_NV = @oldMANV";

            object[] para = new object[]
            {
                nhanVien.Hoten_NV,
                nhanVien.Email_NV,
                nhanVien.Sdt_NV,
                nhanVien.Gioitinh_NV,
                nhanVien.Tinh_Trang,
                nhanVien.Id_NV
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Insert(NhanVienDTO nhanVien)
        {
            string query = "insert into NHANVIEN " +
                "values( @MANV , @HOTEN , @EMAIL , @SDT , @GIOITINH , @TINHTRANG )";

            object[] para = new object[]
            {
                nhanVien.Id_NV,
                nhanVien.Hoten_NV,
                nhanVien.Email_NV,
                nhanVien.Sdt_NV,
                nhanVien.Gioitinh_NV,
                nhanVien.Tinh_Trang             
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string id)
        {
            string query = "update NHANVIEN set " +
                "Tinh_Trang = 0 " +
                "where Id_NV = @MANV";

            object[] para = new object[]
            {
                id
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public int Count()
        {
            string query = "select count(*) from NHANVIEN";
            DataProvider dataProvider = new DataProvider();
            int count = (int)dataProvider.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from NHANVIEN where Id_NV = '" + id + "'";
            DataProvider dataProvider = new DataProvider();
            int count = (int)dataProvider.ExecuteScalar(query);
            return count;
        }
        public String MakeID()
        {
            int count = Count();
            string id;
            while (true)
            {
                id = "N" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
