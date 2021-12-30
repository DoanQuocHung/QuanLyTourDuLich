using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using DTO;
using BUS;
namespace WebForm.Pages.Shared
{
    public class QuanLyDoan_SuaModel : PageModel
    {
        [BindProperty]
        public DoanDuLichDTO doan { set; get; }
        [BindProperty]
        public string tour { get; set; }
        [BindProperty]
        public string noidung { get; set; }

        public long doanhthu { get; set; }
        public List<TourDTO> listtour { set; get; }
        public void OnGet()
        {
            listtour = new TourBUS().List();
            var str = HttpContext.Session.GetString("editdoan");
            var obj = JsonConvert.DeserializeObject<DoanDuLichDTO>(str);
            tour = obj.Id_Tour;
            noidung = obj.Noidung;
            doanhthu = obj.Doanhthu;
        }

        public IActionResult OnPostAdd()
        {
            var parsedDate1 = DateTime.ParseExact(doan.Ngaykhoihanh, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            doan.Ngaykhoihanh = parsedDate1.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var parsedDate2 = DateTime.ParseExact(doan.Ngayketthuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            doan.Ngayketthuc = parsedDate2.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            doan.Id_Tour = tour;
            doan.Noidung = noidung;
            doan.Doanhthu = doanhthu;
            if (new DoanDuLichBUS().Update(doan))
            {
                return Redirect("/Shared/QuanLyDoan");
            }
            return Page();
        }
    }
}
