using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using BUS;
using Microsoft.AspNetCore.Http;

namespace WebForm.Pages.Shared
{
    public class QuanLyNhanVien_SuaModel : PageModel
    {
        [BindProperty]
        public NhanVienDTO nhanvien { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            nhanvien.Tinh_Trang = 1;
            if (new NhanVienBUS().Update(nhanvien))
            {
                HttpContext.Session.SetString("suanhanvien", "true");
                return Redirect("/Shared/QuanLyNhanVien");
            }
            HttpContext.Session.SetString("suanhanvien", "false");
            return Page();
        }
    }
}
