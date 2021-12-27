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
    public class QuanLyDiaDiem_ThemModel : PageModel
    {
        [BindProperty]
        public DiaDiemDTO diadiem { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new DiaDiemBUS().Insert(new DiaDiemDTO(diadiem.Id_DiaDiem, diadiem.Ten_DiaDiem)))
            {
                return Redirect("/Shared/QuanLyDiaDiem");
            }
            return Page();
        }
    }
}
