using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BUS;
using DTO;
namespace WebForm.Pages.Shared
{
    public class QuanLyTour_ThemModel : PageModel
    {
        [BindProperty]
        public TourDTO tour { get; set; }
        public List<LoaiTourDTO> listloai { get; set; }
        public void OnGet()
        {
            listloai = new LoaiTourBUS().List();
        }

        public IActionResult OnPostAdd()
        {
            tour.Tinh_Trang = 1;
            if (new TourBUS().Insert(tour))
            {
                return Redirect("/Shared/QuanLyTour");
            }
            return Page();
        }
    }
}
