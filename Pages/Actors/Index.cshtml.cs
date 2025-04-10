using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using oop_a_2025_movies_74476.Data;
using oop_a_2025_movies_74476.Models;

namespace oop_a_2025_movies_74476.Pages_Actors
{
    public class IndexModel : PageModel
    {
        private readonly oop_a_2025_movies_74476.Data.oop_a_2025_movies_74476Context _context;

        public IndexModel(oop_a_2025_movies_74476.Data.oop_a_2025_movies_74476Context context)
        {
            _context = context;
        }

        public IList<Actor> Actor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Actor = await _context.Actor.ToListAsync();
        }
    }
}
