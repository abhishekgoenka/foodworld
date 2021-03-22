using FoodWorld.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodWorld.Pages.R2
{
    public class IndexModel : PageModel
    {
        private readonly FoodWorld.Data.FoodWorldDbContext _context;

        public IndexModel(FoodWorld.Data.FoodWorldDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get; set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants.ToListAsync();
        }
    }
}
