using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using BUS;
using DTO;

namespace WebForm.Pages.Shared
{
    public class QuanLyNhanVienModel : PageModel
    {
        [BindProperty]
        public NhanVienDTO nhanvien { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(nhanvien);
            HttpContext.Session.SetString("editnhanvien", str);
            return RedirectToPage("/Shared/QuanLyNhanVien_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new NhanVienBUS().Delete(nhanvien.Id_NV))
                {
                    HttpContext.Session.SetString("xoanhanvien", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoanhanvien", "khongthanhcong");
                return Page();
            }
            return Page();
        }
    }
}
