using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Muresan_Alexandru_Vasile_Lab2.Data;
using Muresan_Alexandru_Vasile_Lab2.Models;

namespace Muresan_Alexandru_Vasile_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Muresan_Alexandru_Vasile_Lab2.Data.Muresan_Alexandru_Vasile_Lab2Context _context;

        public CreateModel(Muresan_Alexandru_Vasile_Lab2.Data.Muresan_Alexandru_Vasile_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            return Page();
            ViewData["AuthorID"] = new SelectList(_context.Set<Author>(), "ID", "AuthorFirstName");
            return Page();

        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
