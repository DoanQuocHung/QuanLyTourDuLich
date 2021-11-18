using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class PhanCongBUS
    {
        public List<PhanCongDTO> List(string id)
        {
            return new PhanCongDAO().ListAll(id);
        }

        public List<PhanCongDTO> ListSearch(string text)
        {
            return new PhanCongDAO().List(text);
        }

        public PhanCongDTO get(string maDoan, string maNhanVien)
        {
            return new PhanCongDAO().get(maDoan, maNhanVien);
        }
        public bool Update(PhanCongDTO phanCong)
        {
            return new PhanCongDAO().Update(phanCong);
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
