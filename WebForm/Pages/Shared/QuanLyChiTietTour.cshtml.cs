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
    public class QuanLyChiTietTourModel : PageModel
    {
        [BindProperty]
        public ChiTietTourDTO chitiet { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPostEdit()
        {
            var str = JsonConvert.SerializeObject(chitiet);
            HttpContext.Session.SetString("editchitiettour",str);
            return RedirectToPage("/Shared/QuanLyChiTietTour_Sua");
        }

        public IActionResult OnPostDelete()
        {
            try
            {
                if (new ChiTietTourBUS().Delete(chitiet.Id_Tour,chitiet.Id_DiaDiem))
                {
                    HttpContext.Session.SetString("xoachitiettour", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoachitiettour", "khongthanhcong");
                return Page();
            }
            return Page();
        }
    }
}
