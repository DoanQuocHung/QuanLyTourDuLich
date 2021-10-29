using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiTourDTO
    {
        public LoaiTourDTO(string id, string ten)
        {
            this.Id_Loai = id;
            this.Ten_Loai = ten;
        }
        public string Id_Loai { get; set; }
        public string Ten_Loai { get; set; }
    }
}
