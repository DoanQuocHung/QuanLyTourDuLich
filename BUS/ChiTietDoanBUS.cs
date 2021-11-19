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
        public ChiTietDoanDTO get(string id, string diadiem)
        {
            return new ChiTietDoanDAO().get(id, diadiem);
        }
        public bool Insert(ChiTietDoanDTO chitiet)
        {
            return new ChiTietDoanDAO().Insert(chitiet);
            //Hung
        }
        public bool Delete(string idtour, string iddiadiem)
        {
            return new ChiTietDoanDAO().Delete(idtour, iddiadiem);
        }
    }
}
