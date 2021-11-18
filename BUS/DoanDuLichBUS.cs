using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;

namespace BUS
{
    public class DoanDuLichBUS
    {
        public List<DoanDuLichDTO> List(string id)
        {
            return new DoanDuLichDAO().ListAll(id);
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

        public bool Delete(string maDoan, string maTour)
        {
            return new DoanDuLichDAO().Delete(maDoan, maTour);
        }
    }
}

