using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using oop_a_2025_movies_74476.Data;
using oop_a_2025_movies_74476.Models;

namespace oop_a_2025_movies_74476.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly oop_a_2025_movies_74476.Data.oop_a_2025_movies_74476Context _context;

        public IndexModel(oop_a_2025_movies_74476.Data.oop_a_2025_movies_74476Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            // <snippet_search_linqQuery>
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;
            // </snippet_search_linqQuery>

            var movies = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s =>
                    s.Title.Contains(SearchString) ||
                    s.Director.Contains(SearchString) ||
                    s.Genre.Contains(SearchString) ||
                    s.ReleaseCountry.Contains(SearchString)
                );
            }


            // <snippet_search_selectList>
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            // </snippet_search_selectList>
            Movie = await movies.ToListAsync();
        }
    }

}

