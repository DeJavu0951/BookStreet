using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BaseRepository
    {
        protected readonly BookStreetContext _context;
        public BaseRepository(BookStreetContext context)
        {
            _context = context;
        }
    }
}
