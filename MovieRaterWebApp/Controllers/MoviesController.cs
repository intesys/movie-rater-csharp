using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieRaterWebApp.Data;
using MovieRaterWebApp.Models;
using MovieRaterWebApp.Services;

namespace MovieRaterWebApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            ViewBag.MovieCount = await _moviesService.GetMovieCount();

            return View(await _moviesService.Get2RandomMovies());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View(null);
        }

        // POST: Movies/Vote/5
        [HttpPost, ActionName("Vote")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Vote(int id)
        {
            await _moviesService.Vote(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
