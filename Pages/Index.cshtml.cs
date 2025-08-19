using Microsoft.AspNetCore.Mvc.RazorPages;
using JobBoard.Models;
using JobBoard.Data;
using System.Collections.Generic;
using System.Linq;

namespace JobBoard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<Job> Jobs { get; set; }

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Jobs = _context.Jobs.ToList();
        }
    }
}
