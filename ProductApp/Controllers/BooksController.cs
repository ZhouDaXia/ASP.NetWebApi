using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductApp.Models;
using ProductApp.DTO;
using System.Linq.Expressions;

namespace ProductApp.Controllers
{
    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        private BooksAPIContext db = new BooksAPIContext();

        private static readonly Expression<Func<Book, BookDto>> AsBookDto = x => new BookDto
        {
            Title = x.Title,
            Author = x.Author.Name,
            Genre = x.Genre
        };


    }
}
