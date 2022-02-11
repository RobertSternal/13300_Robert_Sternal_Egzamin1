using System.Collections.Generic;
using System.Linq;

namespace _13300_Robert_Sternal.Models
{
    public interface ICrudTravelRepository
    {
        IList<TravelsModel> FindAll();
        IQueryable<TravelsModel> Travels { get; }
    }
}
