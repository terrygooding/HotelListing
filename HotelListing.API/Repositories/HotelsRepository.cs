using HotelListing.API.Contracts;
using HotelListing.API.Models;

namespace HotelListing.API.Repositories
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
