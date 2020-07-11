using SampleEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEFCore.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, SampleEFCoreContext>
    {
        public EfCoreMovieRepository(SampleEFCoreContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
