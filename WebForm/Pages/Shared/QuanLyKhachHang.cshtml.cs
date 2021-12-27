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
    public class QuanLyKhachHangModel : PageModel
    {
        [BindProperty]
        public KhachDTO khachhang { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(khachhang);
            HttpContext.Session.SetString("editkhachhang", str);
            return RedirectToPage("/Shared/QuanLyKhachHang_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new DiaDiemBUS().Delete(khachhang.Id_Khach))
                {
                    HttpContext.Session.SetString("xoakhachhang", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoakhachhang", "khongthanhcong");
                return Page();
            }
            return Page();
        }
    }
}
