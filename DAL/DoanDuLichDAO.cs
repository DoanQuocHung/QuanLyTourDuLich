using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;

namespace DAL
{
    public class DoanDuLichDAO
    {
        public DoanDuLichDAO() { }

        public List<DoanDuLichDTO> ListAll()
        {
            DataProvider dataProvider = new DataProvider();

            List<DoanDuLichDTO> doanDuLich = new List<DoanDuLichDTO>();
            string query = "select * from DOANDULICH";
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maDoan = item["Id_Doan"].ToString();
                string tenDoan = item["Ten_Doan"].ToString();
                string maTour = item["Id_Tour"].ToString();
                string ngayKhoiHanh = item["Ngaykhoihanh"].ToString();
                string ngayKetThuc = item["Ngayketthuc"].ToString();
                long doanhThu = (long)item["Doanhthu"];
                string noiDung = item["Noidung"].ToString();

                DoanDuLichDTO newdoanDuLich = new DoanDuLichDTO(maDoan, tenDoan, maTour, ngayKhoiHanh, ngayKetThuc, doanhThu, noiDung);

                doanDuLich.Add(newdoanDuLich);
            }
            return doanDuLich;
        }
        public DoanDuLichDTO get(string idDoan, string idTour)
        {

            DataProvider dataProvider = new DataProvider();

            DoanDuLichDTO newdoanDuLich = new DoanDuLichDTO();
            string query = "select * from DOANDULICH where Id_Doan = @MADOAN AND Id_Tour = @MATOUR ";
            object[] para = new object[]
            {
               idDoan,
               idTour
            };
            DataTable data = dataProvider.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maDoan = item["Id_Doan"].ToString();
                string tenDoan = item["Ten_Doan"].ToString();
                string maTour = item["Id_Tour"].ToString();
                string ngayKhoiHanh = item["Ngaykhoihanh"].ToString();
                string ngayKetThuc = item["Ngayketthuc"].ToString();
                long doanhThu = (long)item["Doanhthu"];
                string noiDung = item["Noidung"].ToString();

                newdoanDuLich = new DoanDuLichDTO(maDoan, tenDoan, maTour, ngayKhoiHanh, ngayKetThuc, doanhThu, noiDung);

            }
            return newdoanDuLich;
        }

        public List<DoanDuLichDTO> List(string search)
        {
            DataProvider dataProvider = new DataProvider();

            List<DoanDuLichDTO> doanDuLich = new List<DoanDuLichDTO>();
            string query = "select * from DOANDULICH where Id_Doan LIKE '%" + search + "%'";
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maDoan = item["Id_Doan"].ToString();
                string tenDoan = item["Ten_Doan"].ToString();
                string maTour = item["Id_Tour"].ToString();
                string ngayKhoiHanh = item["Ngaykhoihanh"].ToString();
                string ngayKetThuc = item["Ngayketthuc"].ToString();
                long doanhThu = (long)item["Doanhthu"];
                string noiDung = item["Noidung"].ToString();

                DoanDuLichDTO newdoanDuLich = new DoanDuLichDTO(maDoan, tenDoan, maTour, ngayKhoiHanh, ngayKetThuc, doanhThu, noiDung);
                doanDuLich.Add(newdoanDuLich);
            }
            return doanDuLich;
        }
        public List<DoanDuLichDTO> ListSearch(string search)
        {
            DataProvider dataProvider = new DataProvider();

            List<DoanDuLichDTO> doanDuLich = new List<DoanDuLichDTO>();
            string query = "select * from DOANDULICH where Id_Doan = " + search;
            DataTable data = dataProvider.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maDoan = item["Id_Doan"].ToString();
                string tenDoan = item["Ten_Doan"].ToString();
                string maTour = item["Id_Tour"].ToString();
                string ngayKhoiHanh = item["Ngaykhoihanh"].ToString();
                string ngayKetThuc = item["Ngayketthuc"].ToString();
                long doanhThu = (long)item["Doanhthu"];
                string noiDung = item["Noidung"].ToString();

                DoanDuLichDTO newdoanDuLich = new DoanDuLichDTO(maDoan, tenDoan, maTour, ngayKhoiHanh, ngayKetThuc, doanhThu, noiDung);
                doanDuLich.Add(newdoanDuLich);
            }
            return doanDuLich;
        }

        public bool Insert(DoanDuLichDTO doanDuLich)
        {
            string query = "insert into DOANDULICH " +
                "values( @MADOAN , @TENDOAN , @MATOUR , @NGAYKHOIHANH , @NGAYKETTHUC , @DOANHTHU , @NOIDUNG )";

            object[] para = new object[]
            {
                doanDuLich.Id_Doan,
                doanDuLich.Ten_Doan,
                doanDuLich.Id_Tour,
                doanDuLich.Ngaykhoihanh,
                doanDuLich.Ngayketthuc,
                doanDuLich.Doanhthu,
                doanDuLich.Noidung
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Update(DoanDuLichDTO doanDuLich)
        {

            string query = "update DOANDULICH set " +
                "Ten_Doan = @TENDOAN , " +
                "Id_Tour = @MATOUR , " +
                "Ngaykhoihanh = @NGAYKHOIHANH , " +
                "Ngayketthuc = @NGAYKETTHUC , " +
                "Doanhthu = @DOANHTHU , " +
                "Noidung  = @NOIDUNG " +
                "where Id_Doan = @oldMADOAN AND Id_Tour = @idtour ";

            object[] para = new object[]
            {

                doanDuLich.Ten_Doan,
                doanDuLich.Id_Tour,
                doanDuLich.Ngaykhoihanh,
                doanDuLich.Ngayketthuc,
                doanDuLich.Doanhthu,
                doanDuLich.Noidung,
                doanDuLich.Id_Doan,
                doanDuLich.Id_Tour
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string maDoan)
        {
            string query = "delete from DOANDULICH where Id_Doan = @MADOAN ";

            object[] para = new object[]
            {
                maDoan
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public int Count()
        {
            string query = "select count(*) from DOANDULICH";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from DOANDULICH where Id_Doan = '" + id + "'";
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
                id = "DO" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}


