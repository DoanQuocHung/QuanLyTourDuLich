using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using BUS;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace WebForm.Pages.Pages
{
    public class QuanLyTourModel : PageModel
    {
        [BindProperty]
        public TourDTO tour { set; get; }
        public void OnGet()
        {

        }
        public IActionResult OnPostEdit()
        {
            string str = JsonConvert.SerializeObject(tour);
            HttpContext.Session.SetString("edittour", str);
            return RedirectToPage("/Shared/QuanLyTour_Sua");
        }
        public IActionResult OnPostDelete()
        {
            try
            {
                tour.Tinh_Trang = 0;
                if (new TourBUS().Update(tour))
                {
                    HttpContext.Session.SetString("xoatour", "thanhcong");
                    return Page();
                }
            }
            catch (Exception e1)
            {
                HttpContext.Session.SetString("xoatour", "khongthanhcong");
                return Page();
            }
            return Page();
        }
        public IActionResult OnPostDetail()
        {
            HttpContext.Session.SetString("chitiettour", tour.Id_Tour);
            return RedirectToPage("/Shared/QuanLyChiTietTour");
        }
    }
}
