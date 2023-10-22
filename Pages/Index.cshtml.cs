using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Muresan_Tudor_Lab2.Models;

namespace Muresan_Tudor_Lab2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private object _context;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public object Book { get; private set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
        }

    }
}