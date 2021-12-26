using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebForm.Pages.Shared
{
    public class QuanLyDiaDiemModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("/Shared/QuanLyDiaDiem_Them");
        }
    }
}
