using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;

namespace BUS
{
    public class NhanVienBUS
    {
        public NhanVienBUS() { }

        public List<NhanVienDTO> List()
        {
            return new NhanVienDAO().ListAll();
        }
        public List<NhanVienDTO> ListSearch(string text)
        {
            return new NhanVienDAO().List(text);
        }
        public NhanVienDTO getNhanVien(string id)
        {
            return new NhanVienDAO().getNhanVien(id);
        }
        
        public bool Update(NhanVienDTO nhanVien)
        {
            return new NhanVienDAO().Update(nhanVien);
        }

        public bool Insert(NhanVienDTO nhanVien)
        {
            return new NhanVienDAO().Insert(nhanVien);
        }
        public bool Delete(string manv)
        {
            return new NhanVienDAO().Delete(manv);
        }
        public String MakeID()
        {
            return new NhanVienDAO().MakeID();
        }
    }
}

