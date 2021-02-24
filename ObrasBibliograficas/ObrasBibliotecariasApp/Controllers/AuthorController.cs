using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObrasBibliotecariasApp.Interfaces;
using ObrasBibliotecariasApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ObrasBibliotecariasApp.Controllers
{
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly IAuthor objauthor;

        public AuthorController(IAuthor _objauthor)
        {
            objauthor = _objauthor;
        }

        //[HttpGet]
        //[Route("Index")]
        //public IEnumerable<TblAuthor> Index()
        //{
        //    return objauthor.GetAllAuthors();
        //}

        [HttpGet]
        [Route("Index")]
        public IList<string> Index()
        {
            return objauthor.GetAllAuthorsNames();
        }
    }
}
