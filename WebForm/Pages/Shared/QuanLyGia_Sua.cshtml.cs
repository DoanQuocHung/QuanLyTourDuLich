using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DTO;
using BUS;
using Microsoft.AspNetCore.Http;
namespace WebForm.Pages.Shared
{
    public class QuanLyGia_SuaModel : PageModel
    {
        [BindProperty]
        public GiaDTO gia { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new GiaBUS().Update(gia))
            {
                return Redirect("/Shared/QuanLyGia");
                HttpContext.Session.SetString("suagiatour", "true");
            }
            HttpContext.Session.SetString("suagiatour", "false");
            return Page();
        }
    }
}
