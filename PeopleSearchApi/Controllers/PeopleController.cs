using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleSearchApi.Models;
using PeopleSearchApi.Repositories;
using Microsoft.AspNetCore.Hosting;
using System;

namespace PeopleSearchApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepository _repo;
        private readonly IHostingEnvironment _env;
        private Random random = new Random();
        public PeopleController(IPeopleRepository repository, IHostingEnvironment env)
        {
            _repo = repository;
            _env = env;
        }

        /// <summary>
        /// GET: api/People
        /// A people getter that uses a criteria query string parameter to do a
        /// text search of the first and last names.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns>A list of people that match</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPersons(string criteria)
        {
            return await _repo.FindPersonsByName(criteria);
        }

        
        /// <summary>
        /// GET: api/People/slow
        /// This is the artificially slow version of the people getter.
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns> A list of people that match the criteria or all of them</returns>
        [HttpGet("slow")]
        public async Task<ActionResult<IEnumerable<Person>>> GetSlowPersons(string criteria)
        {
            // lets wait a random amount of time between 1 and 3 secs
            var delayAmount = random.Next(1000,3000);
            await Task.Delay(delayAmount);
            return await this.GetPersons(criteria);
        }

 
        /// <summary>
        /// Get the image for this person based on their id. Currently storing the images on the filesystem
        /// for simplicity, but because this is abastracted behind the API we could easily move it to the db
        /// if needed. Images are from unsplash.com
        /// </summary>
        /// <param name="id">The person id for whom the image belongs.</param>
        /// <returns></returns>
        [HttpGet("pic/{id}")]
        public IActionResult GetImage(string id)
        {
            var imagePath = $@"{_env.ContentRootPath}\Images\{id}.jpg";
            return PhysicalFile(imagePath, "image/jpeg");
        }


        
    }
}
