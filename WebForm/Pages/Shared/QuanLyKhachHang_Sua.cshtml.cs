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
    public class QuanLyKhachHang_SuaModel : PageModel
    {
        [BindProperty]
        public KhachDTO khachhang { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new KhachHangBUS().Update(khachhang))
            {
                return Redirect("/Shared/QuanLyKhachHang");
            }
            return Page();
        }
    }
}
