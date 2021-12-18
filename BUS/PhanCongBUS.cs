using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class PhanCongBUS
    {
        public PhanCongBUS() { }

        public List<PhanCongDTO> List()
        {
            return new PhanCongDAO().ListAll();
        }

        public bool Update(PhanCongDTO phanCong, string oldId_Doan, string oldId_NV)
        {
            return new PhanCongDAO().Update(phanCong, oldId_Doan, oldId_NV);
        }

        public bool Insert(PhanCongDTO phanCong)
        {
            return new PhanCongDAO().Insert(phanCong);
        }

        public bool Delete(string maDoan, string maNhanVien)
        {
            return new PhanCongDAO().Delete(maDoan, maNhanVien);
        }
    }
}
