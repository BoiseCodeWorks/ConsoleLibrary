using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Providers;
using Microsoft.AspNetCore.Mvc;

namespace WebLibrary.Controllers
{
    [Route("api/[controller]")]
    public class LibraryController : Controller
    {
        private readonly LibraryProvider _lp;
        // GET api/library
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _lp.GetLibraries();
        }


        public LibraryController()
        {
            _lp = new LibraryProvider();
        }


    }
}
