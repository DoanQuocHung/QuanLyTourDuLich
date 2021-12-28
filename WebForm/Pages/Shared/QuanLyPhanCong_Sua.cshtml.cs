using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using BUS;

namespace WebForm.Pages.Shared
{
    public class QuanLyPhanCong_SuaModel : PageModel
    {
        [BindProperty]
        public PhanCongDTO phancong { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            //if (new PhanCongBUS().Update(phancong))
            //{
            //    return Redirect("/Shared/QuanLyPhanCong");
            //}
            return Page();
        }
    }
}
