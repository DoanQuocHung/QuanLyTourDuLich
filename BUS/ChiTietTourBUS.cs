﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Windows.Forms;
namespace BUS
{
    public class ChiTietTourBUS
    {
        public List<ChiTietTourDTO> List(string id)
        {
            return new ChiTietTourDAO().ListAll(id);
        }
        public ChiTietTourDTO get(string id)
        {
            return new ChiTietTourDAO().get(id);
        }
        public bool Update(ChiTietTourDTO chitiet)
        {
            return new ChiTietTourDAO().Update(chitiet);
            //
        }

        public bool Insert(ChiTietTourDTO chitiet)
        {
            return new ChiTietTourDAO().Insert(chitiet);
            //Hung
        }
        public bool Delete(string idtour,string iddiadiem)
        {
            return new ChiTietTourDAO().Delete(idtour,iddiadiem);
        }
    }
}
