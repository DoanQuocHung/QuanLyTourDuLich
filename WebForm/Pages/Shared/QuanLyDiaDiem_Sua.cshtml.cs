using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using BUS;
namespace WebForm.Pages.Shared
{
    public class QuanLyDiaDiem_SuaModel : PageModel
    {
        [BindProperty]
        public DiaDiemDTO diadiem { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new DiaDiemBUS().Update(diadiem))
            {
                return Redirect("/Shared/QuanLyDiaDiem");
            }
            return Page();
        }
    }
}
