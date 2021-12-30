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
    public class QuanLyDoanModel : PageModel
    {
        [BindProperty]
        public DoanDuLichDTO doan { set; get; }
        public void OnGet()
        {

        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(doan);
            HttpContext.Session.SetString("editdoan", str);
            return RedirectToPage("/Shared/QuanLyDoan_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new DoanDuLichBUS().Delete(doan.Id_Doan))
                {
                    HttpContext.Session.SetString("xoadoan", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e)
            {
                HttpContext.Session.SetString("xoadoan", "khongthanhcong");
                return Page();
            }
            return Page();
        }
        public IActionResult OnPostDetail()
        {
            string gia = new DoanDuLichBUS().getGiaTour(doan.Ngaykhoihanh, doan.Id_Tour);
            HttpContext.Session.SetString("chitietdoan-giatour", gia);
            HttpContext.Session.SetString("chitietdoan", doan.Id_Doan);
            return RedirectToPage("/Shared/QuanLyChiTietDoan");
        }
    }
}
