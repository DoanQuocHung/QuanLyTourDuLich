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
    public class QuanLyGiaModel : PageModel
    {
        [BindProperty]
        public GiaDTO gia { set; get; }
        public void OnGet()
        {

        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(gia);
            HttpContext.Session.SetString("editgia", str);
            return RedirectToPage("/Shared/QuanLyGia_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new DiaDiemBUS().Delete(gia.Id_Gia))
                {
                    HttpContext.Session.SetString("xoagia", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoagia", "khongthanhcong");
                return Page();
            }
            return Page();
        }
    }
}
