﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCHW9.Models;

namespace MVCHW9.Controllers
{
    public class MoviesController : Controller
    {
        private DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = db.Movies.Include(m => m.Director).OrderBy(m => m.gross);

            return View(movies.ToList());
        }

        public ActionResult Top()
        {
            var movies = db.Movies.Include(m => m.Director);
            return View(movies.ToList().OrderBy(m => m.gross));
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
     
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
