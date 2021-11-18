using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;

namespace BUS
{
    public class DoanDuLichBUS
    {
        public List<DoanDuLichDTO> List()
        {
            return new DoanDuLichDAO().ListAll();
        }

        public List<DoanDuLichDTO> ListSearch(string text)
        {
            return new DoanDuLichDAO().List(text);
        }

        public DoanDuLichDTO get(string maDoan, string maTour)
        {
            return new DoanDuLichDAO().get(maDoan, maTour);
        }
        public bool Update(DoanDuLichDTO doanDuLich)
        {
            return new DoanDuLichDAO().Update(doanDuLich);
        }

        public bool Insert(DoanDuLichDTO doanDuLich)
        {
            return new DoanDuLichDAO().Insert(doanDuLich);
        }

        public bool Delete(string maDoan)
        {
            return new DoanDuLichDAO().Delete(maDoan);
        }
        public String MakeID()
        {
            return new DoanDuLichDAO().MakeID();
        }
    }
}

