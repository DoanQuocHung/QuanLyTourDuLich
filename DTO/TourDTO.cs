﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TourDTO
    {
        public TourDTO()
        {
        }
            public TourDTO(string Id_Tour, string Ten_Tour, string Dacdiem_Tour, string Id_Loai)
        {
            this.Id_Tour = Id_Tour;
            this.Ten_Tour = Ten_Tour;
            this.Dacdiem_Tour = Dacdiem_Tour;
            this.Id_Loai = Id_Loai;
        }

        public string Id_Tour { get; set; }
        public string Ten_Tour { get; set; }
        public string Dacdiem_Tour { get; set; }
        public string Id_Loai { get; set; }
    }
}
