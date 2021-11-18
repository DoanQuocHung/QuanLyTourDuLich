﻿using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;

namespace BUS
{
    public class KhachHangBUS
    {
        public KhachHangBUS() { }

        public List<KhachDTO> List()
        {
            return new KhachHangDAO().ListAll();
        }
        public List<KhachDTO> ListSearch(string text)
        {
            return new KhachHangDAO().List(text);
        }
        public KhachDTO getKhachHang(string id)
        {
            return new KhachHangDAO().getKhachHang(id);
        }

        public bool Update(KhachDTO khachHang)
        {
            return new KhachHangDAO().Update(khachHang);
        }

        public bool Insert(KhachDTO khachHang)
        {
            return new KhachHangDAO().Insert(khachHang);
        }
        public bool Delete(string makh)
        {
            return new KhachHangDAO().Delete(makh);
        }
        public String MakeID()
        {
            return new KhachHangDAO().MakeID();
        }
    }
}

