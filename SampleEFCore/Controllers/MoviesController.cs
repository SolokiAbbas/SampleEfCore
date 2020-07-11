using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using SampleEFCore.Data;
using SampleEFCore.Data.EFCore;
using SampleEFCore.Models;

namespace SampleEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyEFController<Movie, EfCoreMovieRepository>
    {
        private readonly IMemoryCache memCache;
        public MoviesController(EfCoreMovieRepository repository, IMemoryCache memCache) : base(repository, memCache)
        {
            this.memCache = memCache;
        }
        public ActionResult<string> GetCache()
        {
            if(!memCache.TryGetValue("Test", out string results))
            {
                results = "THIS is being Cached inside !!!!!!!!!!!!";
                var cacheExpirationOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddSeconds(10),
                    Priority = CacheItemPriority.Normal,
                    SlidingExpiration = TimeSpan.FromSeconds(5)
                };
                memCache.Set("Test", results, cacheExpirationOptions);
            }
            return results;
        }

    }
}
