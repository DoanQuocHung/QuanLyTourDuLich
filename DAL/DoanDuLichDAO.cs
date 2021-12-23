﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;

namespace DAL
{
    public class DoanDuLichDAO
    {
        DataProvider dataProvider = new DataProvider();
        public DoanDuLichDAO() { }

        public List<DoanDuLichDTO> ListAll()
        {
            List<DoanDuLichDTO> doanDuLich = new List<DoanDuLichDTO>();
            try
            {
                string query = "select * from DOANDULICH";
                DataTable data = dataProvider.ExecuteQuery(query);
                Console.WriteLine(data.Rows);
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll " + e);
            }

            return doanDuLich;
        }
        public List<DoanDuLichDTO> ListBaseTour(string id)
        {
            List<DoanDuLichDTO> doanDuLich = new List<DoanDuLichDTO>();
            try
            {
                string query = "select * from DOANDULICH where Id_Tour = @matour";
                object[] para = new object[]
            {
               id
            };
                DataTable data = dataProvider.ExecuteQuery(query,para);
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll " + e);
            }

            return doanDuLich;
        }
        public List<DoanDuLichDTO> ListSearch(string search)
        {
            DataProvider dataProvider = new DataProvider();

            List<DoanDuLichDTO> doanDuLich = new List<DoanDuLichDTO>();
            string query = "select * from DOANDULICH where Ten_Doan = " + search;
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
                "where Id_Doan = @oldMADOAN ";

            object[] para = new object[]
            {

                doanDuLich.Ten_Doan,
                doanDuLich.Id_Tour,
                doanDuLich.Ngaykhoihanh,
                doanDuLich.Ngayketthuc,
                doanDuLich.Doanhthu,
                doanDuLich.Noidung,
                doanDuLich.Id_Doan
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public bool UpdateDoanhThu(string id, long value)
        {

            string query = "update DOANDULICH set " +
                "Doanhthu = Doanhthu - @value " +
                "where Id_Doan = @oldMADOAN ";

            object[] para = new object[]
            {

               value,
               id
            };
            DataProvider dataProvider = new DataProvider();
            if (dataProvider.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Delete(string maDoan)
        {
            try
            {
                string query = "delete from DOANDULICH where Id_Doan = @MADOAN ";
                string query2 = "delete from CHITIETDOAN where Id_Doan = @MADOAN ";

                object[] para = new object[]
                {
                maDoan
                };
                DataProvider dataProvider = new DataProvider();
                dataProvider.ExecuteNonQuery(query2, para);
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return false;
        }
        public int Count()
        {
            string query = "select count(*) from DOANDULICH";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(string id)
        {
            string query = "select count(*) from DOANDULICH where Id_Doan = '" + id + "'";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public string MakeID()
        {
            string id;
            int count = Count();
            while (true)
            {
                id = "DOAN" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}


