using System.Collections.Generic;
using System.Linq;

namespace _13300_Robert_Sternal.Models
{
    public class CrudTravelRepository : ICrudTravelRepository
    {
        private ApplicationDbContext _context;

        public CrudTravelRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<TravelsModel> FindAll()
        {
            return _context.Travels.ToList();
        }

        public IQueryable<TravelsModel> Travels => _context.Travels;
    }
}
