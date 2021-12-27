using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using Microsoft.AspNetCore.Http;
using BUS;
using DTO;
using Newtonsoft.Json;

namespace WebForm.Pages.Shared
{
    public class QuanLyDiaDiemModel : PageModel
    {
        [BindProperty]
        public DiaDiemDTO diadiem { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(diadiem);
            HttpContext.Session.SetString("editdiadiem", str);
            return RedirectToPage("/Shared/QuanLyDiaDiem_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                if (new DiaDiemBUS().Delete(diadiem.Id_DiaDiem))
                {
                    HttpContext.Session.SetString("xoadiadiem", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoadiadiem", "khongthanhcong");
                return Page();
            }
            return Page();
        }
    }
}
