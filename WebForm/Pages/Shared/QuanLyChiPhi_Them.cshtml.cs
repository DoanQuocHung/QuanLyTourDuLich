using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BUS;
using DTO;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace WebForm.Pages.Shared
{
    public class QuanLyChiPhi_ThemModel : PageModel
    {
        [BindProperty]
        public ChiPhiDTO chiphi { set; get; }

        [BindProperty]
        public string phi { set; get; }
        public List<LoaiChiPhiDTO> loaichiphi { set; get; }
        public void OnGet()
        {
            loaichiphi = new LoaiChiPhiBUS().List();
        }

        public IActionResult OnPostAdd()
        {
            string iddoan = HttpContext.Session.GetString("chitietdoan");
            chiphi.Id_Doan = iddoan;
            if (new ChiPhiBUS().Insert(chiphi))
            {
                new DoanDuLichBUS().UpdateDoanhThu(chiphi.Id_Doan, chiphi.Gia);
                return Redirect("/Shared/QuanLyChiTietDoan");
            }
            return Page();
        }
    }
}
