using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class ChiPhiBUS
    {
        public List<ChiPhiDTO> List()
        {
            return new ChiPhiDAO().ListAll();
        }
        public ChiPhiDTO get(string id, string diadiem)
        {
            return new ChiPhiDAO().get(id, diadiem);
        }
        public bool Update(ChiPhiDTO chitiet,string loai)
        {
            return new ChiPhiDAO().Update(chitiet,loai);
            //
        }

        public bool Insert(ChiPhiDTO chitiet)
        {
            return new ChiPhiDAO().Insert(chitiet);
            //Hung
        }
        public bool Delete(string idtour, string iddiadiem)
        {
            return new ChiPhiDAO().Delete(idtour, iddiadiem);
        }
    }
}
