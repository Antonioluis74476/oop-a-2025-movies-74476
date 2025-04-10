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
    public class DetailsModel : PageModel
    {
        private readonly oop_a_2025_movies_74476.Data.oop_a_2025_movies_74476Context _context;

        public DetailsModel(oop_a_2025_movies_74476.Data.oop_a_2025_movies_74476Context context)
        {
            _context = context;
        }

        public Actor Actor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.Actor.FirstOrDefaultAsync(m => m.ID == id);
            if (actor == null)
            {
                return NotFound();
            }
            else
            {
                Actor = actor;
            }
            return Page();
        }
    }
}
