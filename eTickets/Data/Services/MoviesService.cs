﻿using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class MoviesService:EntityBaseRepository<Movie>, IMoviesService
    {
            private readonly AppDbContext _context;
            public MoviesService(AppDbContext context) : base(context) { }
    }
}
