using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ionut_Sebastian_Lab8.Data;
using Ionut_Sebastian_Lab8.Models;

namespace Ionut_Sebastian_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Ionut_Sebastian_Lab8.Data.Ionut_Sebastian_Lab8Context _context;

        public IndexModel(Ionut_Sebastian_Lab8.Data.Ionut_Sebastian_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();


        }
    }
}
