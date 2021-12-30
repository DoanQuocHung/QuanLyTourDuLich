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
    public class QuanLyGia_ThemModel : PageModel
    {
        [BindProperty]
        public GiaDTO gia { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (new GiaBUS().Insert(new GiaDTO(
                gia.Id_Gia,
                gia.Id_Tour, 
                gia.Gia, 
                gia.Thoigianbatdau, 
                gia.Thoigianketthuc)))
            {
                return Redirect("/Shared/QuanLyGia");
            }
            return Page();
        }
    }
}
