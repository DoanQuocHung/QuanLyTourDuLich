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
    public class QuanLyPhanCong_ThemModel : PageModel
    {
        [BindProperty]
        public PhanCongDTO phancong { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new PhanCongBUS().Insert(new PhanCongDTO(
                phancong.Id_Doan, 
                phancong.Id_NV,
                phancong.Nhiemvu)))
            {
                HttpContext.Session.SetString("themphancong", "true");
                return Redirect("/Shared/QuanLyPhanCong");
            }
            HttpContext.Session.SetString("themphancong", "false");
            return Page();
        }
    }
}
