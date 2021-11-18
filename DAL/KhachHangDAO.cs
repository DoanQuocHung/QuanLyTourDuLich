using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;

namespace DAL
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        public List<KhachDTO> ListAll()
        {
            DataProvider dataProvider = new DataProvider();

            List<KhachDTO> khachHang = new List<KhachDTO>();
            string query = "Select * from KHACH";

            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maKH = item["Id_Khach"].ToString();
                string hoTenKH = item["Hoten_Khach"].ToString();
                string cmndKH = item["Cmnd_Khach"].ToString();
                string diachiKH = item["Diachi_Khach"].ToString();
                string gioitinhKH = item["Gioitinh_Khach"].ToString();
                string sdtKH = item["Sdt_Khach"].ToString();
                string quoctichKH = item["Quoctich"].ToString();
                
                int tinhtrang = 0;

                KhachDTO newKhachHang = new KhachDTO(maKH, hoTenKH, cmndKH, diachiKH, gioitinhKH, sdtKH, quoctichKH, tinhtrang);

                khachHang.Add(newKhachHang);
            }
            return khachHang;
        }
        public List<KhachDTO> List(string search)
        {
            DataProvider dataProvider = new DataProvider();

            List<KhachDTO> khachHang = new List<KhachDTO>();
            string query = "Select * from KHACH where Id_Khach LIKE '%" + search + "%'";
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maKH = item["Id_Khach"].ToString();
                string hoTenKH = item["Hoten_Khach"].ToString();
                string cmndKH = item["Cmnd_Khach"].ToString();
                string diachiKH = item["Diachi_Khach"].ToString();
                string gioitinhKH = item["Gioitinh_Khach"].ToString();
                string sdtKH = item["Sdt_Khach"].ToString();
                string quoctichKH = item["Quoctich"].ToString();
                int tinhtrang = (int)item["Tinh_Trang"];

                KhachDTO newKhachHang = new KhachDTO(maKH, hoTenKH, cmndKH, diachiKH, gioitinhKH, sdtKH, quoctichKH, tinhtrang);

                khachHang.Add(newKhachHang);
            }
            return khachHang;
        }
        public List<KhachDTO> ListSearch(string search)
        {
            DataProvider dataProvider = new DataProvider();

            List<KhachDTO> khachHang = new List<KhachDTO>();
            string query = "Select * from KHACH where Id_Khach = " + search;
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maKH = item["Id_Khach"].ToString();
                string hoTenKH = item["Hoten_Khach"].ToString();
                string cmndKH = item["Cmnd_Khach"].ToString();
                string diachiKH = item["Diachi_Khach"].ToString();
                string gioitinhKH = item["Gioitinh_Khach"].ToString();
                string sdtKH = item["Sdt_Khach"].ToString();
                string quoctichKH = item["Quoctich"].ToString();
                int tinhtrang = (int)item["Tinh_Trang"];

                KhachDTO newKhachHang = new KhachDTO(maKH, hoTenKH, cmndKH, diachiKH, gioitinhKH, sdtKH, quoctichKH, tinhtrang);

                khachHang.Add(newKhachHang);
            }
            return khachHang;
        }

        public KhachDTO getKhachHang(string search)
        {
            DataProvider dataProvider = new DataProvider();

            string query = "Select * from KHACH where Id_Khach = " + search;
            DataTable data = dataProvider.ExecuteQuery(query);
            KhachDTO khachHang = new KhachDTO();
            foreach (DataRow item in data.Rows)
            {
                string maKH = item["Id_Khach"].ToString();
                string hoTenKH = item["Hoten_Khach"].ToString();
                string cmndKH = item["Cmnd_Khach"].ToString();
                string diachiKH = item["Diachi_Khach"].ToString();
                string gioitinhKH = item["Gioitinh_Khach"].ToString();
                string sdtKH = item["Sdt_Khach"].ToString();
                string quoctichKH = item["Quoctich"].ToString();
                int tinhtrang = (int)item["Tinh_Trang"];

                khachHang = new KhachDTO(maKH, hoTenKH, cmndKH, diachiKH, gioitinhKH, sdtKH, quoctichKH, tinhtrang);

            }
            return khachHang;
        }
        public KhachDTO get(string id)
        {
            DataProvider dataProvider = new DataProvider();

            KhachDTO khachHang = new KhachDTO();
            string query = "Select * from Khach where Id_Khach = @id";
            object[] para = new object[]
            {
               id
            };
            DataTable data = dataProvider.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maKH = item["Id_Khach"].ToString();
                string hoTenKH = item["Hoten_Khach"].ToString();
                string cmndKH = item["Cmnd_Khach"].ToString();
                string diachiKH = item["Diachi_Khach"].ToString();
                string gioitinhKH = item["Gioitinh_Khach"].ToString();
                string sdtKH = item["Sdt_Khach"].ToString();
                string quoctichKH = item["Quoctich"].ToString();
                int tinhtrang = (int)item["Tinh_Trang"];

                khachHang = new KhachDTO(maKH, hoTenKH, cmndKH, diachiKH, gioitinhKH, sdtKH, quoctichKH, tinhtrang);
            }
            return khachHang;
        }
        public bool Update(KhachDTO khachHang)
        {
            string query = "update KHACH set " +
                "Hoten_Khach = @HOTEN , " +
                "Cmnd_Khach = @CMND , " +
                "Diachi_Khach = @DIACHI ," +
                "Gioitinh_Khach = @GIOITINH , " +
                "Sdt_Khach = @SDT , " +
                "Quoctich = @QUOCTICH , " +
                "Tinh_Trang = @TINHTRANG " +
                "where Id_Khach = @oldMAKH";

            object[] para = new object[]
            {
                khachHang.Hoten_Khach,
                khachHang.Cmnd_Khach,
                khachHang.Diachi_Khach,
                khachHang.Gioitinh_Khach,
                khachHang.Sdt_Khach,
                khachHang.Quoctich,
                khachHang.Tinh_Trang,
                khachHang.Id_Khach
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Insert(KhachDTO khachHang)
        {
            string query = "insert into KHACH " +
                "values( @MAKH , @HOTEN , @CMND , @DIACHI , @GIOITINH , @SDT , @QUOCTICH , @TINHTRANG )";

            object[] para = new object[]
            {
                khachHang.Id_Khach,
                khachHang.Hoten_Khach,
                khachHang.Cmnd_Khach,
                khachHang.Diachi_Khach,
                khachHang.Gioitinh_Khach,
                khachHang.Sdt_Khach,
                khachHang.Quoctich,
                khachHang.Tinh_Trang
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string id)
        {
            string query = "delete from KHACH " +
                "where Id_Khach = @MAKH";

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
            string query = "select count(*) from KHACH";
            DataProvider dataProvider = new DataProvider();
            int count = (int)dataProvider.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from KHACH where Id_Khach = '" + id + "'";
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
                id = "K" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
