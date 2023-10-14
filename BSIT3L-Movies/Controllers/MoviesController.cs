using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "10", ReleaseYear = 1997, Genre = "Romance/Drama", Imgg = "/images/titanic.png", Vidd = "https://youtu.be/I7c1etV7D7g?si=cIFyAuraKypWF15b" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "9", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Imgg = "/images/inception.jpg", Vidd = "https://youtu.be/Jvurpf91omw?si=6cue194iYRHzCN1j" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "10", ReleaseYear = 1994, Genre = "Drama", Imgg = "/images/shawshanks.jpg", Vidd = "https://youtu.be/PLl99DlL6b4?si=8-N7AI7z0TsGuwDL" },
            new MovieViewModel { Id = 4, Name = "The Godfather", Rating = "9", ReleaseYear = 1972, Genre = "Drama", Imgg = "/images/thegodfather.jpg", Vidd =  "https://youtu.be/UaVTIH8mujA?si=SL-6O8_GaMTrdfaa" },
            new MovieViewModel { Id = 5, Name = "The Dark Knight", Rating = "8", ReleaseYear = 2008, Genre = "Action/Drama", Imgg = "/images/thedarkknight.jpg", Vidd =  "https://youtu.be/LDG9bisJEaI?si=ITJILYj5Xj4_1FXE" },
            new MovieViewModel { Id = 6, Name = "Pulp Fiction", Rating = "8", ReleaseYear = 1994, Genre = "Drama", Imgg = "/images/pulpfiction.jpg", Vidd =  "https://youtu.be/tGpTpVyI_OQ?si=9ycyG3_MZaXtUZWO/videos/titanic.mp4" },
            new MovieViewModel { Id = 7, Name = "Schindler's List", Rating = "8", ReleaseYear = 1993, Genre = "Drama", Imgg = "/images/schindlerslist.jpg", Vidd =  "https://youtu.be/WhH3WX3_7AM?si=dknM8tA2dptXIzXm" },
            new MovieViewModel { Id = 8, Name = "The Lord of the Rings", Rating = "8", ReleaseYear = 1999, Genre = "Drama", Imgg = "/images/lordofrings.jpg", Vidd =  "https://youtu.be/FaEjOORR6nY?si=95n_-24lFpBjg9tr" },
            new MovieViewModel { Id = 9, Name = "Goodfellas", Rating = "8", ReleaseYear = 1990, Genre = "Drama", Imgg = "/images/godfellas.jpg", Vidd =  "https://youtu.be/2ilzidi_J8Q?si=CoNxea75FXZHBHb3" },
            new MovieViewModel { Id = 10, Name = "Fight Club", Rating = "8", ReleaseYear = 1999, Genre = "Drama",Imgg = "/images/fightclub.jpg", Vidd =  "https://youtu.be/BdJKm16Co6M?si=yhCV7j4O-QKJfEuQ" },
            new MovieViewModel { Id = 11, Name = "Forrest Gump", Rating = "8", ReleaseYear = 1994, Genre = "Drama/Romance", Imgg = "/images/forrestgump.jpg", Vidd =  "https://youtu.be/bLvqoHBptjg?si=1nXXzQVZ3UEOfn0b" },
            new MovieViewModel { Id = 12, Name = "The Matrix", Rating = "8", ReleaseYear = 1999, Genre = "Action", Imgg = "/images/thematrix.jpg", Vidd =  "https://youtu.be/nNpvWBuTfrc?si=foCuhSrP2QcaIQxc" },
            new MovieViewModel { Id = 13, Name = "The Silence of the Lambs", Rating = "8", ReleaseYear = 1991, Genre = "Drama/Thriller", Imgg = "/images/thesilentlambs.jpg", Vidd =  "https://youtu.be/W6Mm8Sbe__o?si=wjghvAioyNxDizVC" },
            new MovieViewModel { Id = 14, Name = "Gladiator", Rating = "8", ReleaseYear = 2000, Genre = "Drama/Fantasy", Imgg = "/images/gladiator.jpg", Vidd =  "https://youtu.be/TcYIqlBihW4?si=QfdkNG9oNVfhjH8u" },
            new MovieViewModel { Id = 15, Name = "The Departed", Rating = "8", ReleaseYear = 2006, Genre = "Drama", Imgg = "/images/thedeparted.jpg", Vidd =  "https://youtu.be/iojhqm0JTW4?si=iUaMeLDk8-GEVG1r" },
            
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

