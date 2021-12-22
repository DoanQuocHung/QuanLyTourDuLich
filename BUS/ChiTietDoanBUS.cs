using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class ChiTietDoanBUS
    {
        public List<ChiTietDoanDTO> List(string id)
        {
            return new ChiTietDoanDAO().ListAll(id);
        }
        public ChiTietDoanDTO get(string id, string idkhach)
        {
            return new ChiTietDoanDAO().get(id, idkhach);
        }
        public bool Insert(ChiTietDoanDTO chitiet, string ngaykhoihanh, string ngayketthuc)
        {
            return new ChiTietDoanDAO().Insert(chitiet, ngaykhoihanh,ngayketthuc);
        }
        public bool Delete(string iddoan, string idkhach, string ngaykhoihanh, string ngayketthuc)
        {
            return new ChiTietDoanDAO().Delete(iddoan, idkhach, ngaykhoihanh, ngayketthuc);
        }
    }
}
