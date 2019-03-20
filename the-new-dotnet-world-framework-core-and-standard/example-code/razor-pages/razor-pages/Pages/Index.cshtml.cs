using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages.Pages
{
    public class IndexModel : PageModel
    {
        public string ConferenceName { get; private set; }

        public void OnGet()
        {
            ConferenceName = "MomentumDevCon";
        }
    }
}
