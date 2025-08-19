using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobBoard.Models;
using JobBoard.Data;

namespace JobBoard.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public Job Job { get; set; }

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Jobs.Add(Job);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
