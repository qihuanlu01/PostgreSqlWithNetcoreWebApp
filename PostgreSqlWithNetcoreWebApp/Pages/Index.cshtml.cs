using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostgreSqlWithNetcoreWebApp.Models;
using PostgreSqlWithNetcoreWebApp.Pages.Movies;

namespace PostgreSqlWithNetcoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }


    }
}
