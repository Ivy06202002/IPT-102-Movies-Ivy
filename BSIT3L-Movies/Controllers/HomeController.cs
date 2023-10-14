using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "10", ReleaseYear = 1997, Genre = "Romance/Drama" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "9", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "10", ReleaseYear = 1994, Genre = "Drama" },
            new MovieViewModel { Id = 4, Name = "The Godfather", Rating = "9", ReleaseYear = 1972, Genre = "Drama" },
            new MovieViewModel { Id = 5, Name = "The Dark Knight", Rating = "8", ReleaseYear = 2008, Genre = "Action/Drama" },
            new MovieViewModel { Id = 6, Name = "Pulp Fiction", Rating = "8", ReleaseYear = 1994, Genre = "Drama" },
            new MovieViewModel { Id = 7, Name = "Schindler's List", Rating = "8", ReleaseYear = 1993, Genre = "Drama" },
            new MovieViewModel { Id = 8, Name = "The Lord of the Rings", Rating = "8", ReleaseYear = 1999, Genre = "Drama" },
            new MovieViewModel { Id = 9, Name = "Goodfellas", Rating = "8", ReleaseYear = 1990, Genre = "Drama" },
            new MovieViewModel { Id = 10, Name = "Fight Club", Rating = "8", ReleaseYear = 1999, Genre = "Drama" },
            new MovieViewModel { Id = 11, Name = "Forrest Gump", Rating = "8", ReleaseYear = 1994, Genre = "Drama/Romance" },
            new MovieViewModel { Id = 12, Name = "The Matrix", Rating = "8", ReleaseYear = 1999, Genre = "Action" },
            new MovieViewModel { Id = 13, Name = "The Silence of the Lambs", Rating = "8", ReleaseYear = 1991, Genre = "Drama/Thriller" },
            new MovieViewModel { Id = 14, Name = "Gladiator", Rating = "8", ReleaseYear = 2000, Genre = "Drama/Fantasy" },
            new MovieViewModel { Id = 15, Name = "The Departed", Rating = "8", ReleaseYear = 2006, Genre = "Drama" },

        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

