using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BUS;
using DTO;
namespace WebForm.Pages.Shared
{
    public class QuanLyChiTietTour_ThemModel : PageModel
    {
        [BindProperty]
        public ChiTietTourDTO tour { get; set; }
        public List<DiaDiemDTO> listdiadiem { get; set; }
        public void OnGet()
        {
            listdiadiem = new DiaDiemBUS().List();
        }

        public IActionResult OnPostAdd()
        {
            if (new ChiTietTourBUS().Insert(tour))
            {
                return Redirect("/Shared/QuanLyChiTietTour");
            }
            return Page();
        }
    }
}