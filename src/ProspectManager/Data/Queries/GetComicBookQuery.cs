using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProspectManager.Models;

namespace ProspectManager.Data.Queries
{
    public class GetProspectQuery
    {
        private Context _context = null;

        public GetProspectQuery(Context context)
        {
            _context = context;
        }

        public Prospect Execute(int id)
        {
            return _context.Prospects
                .Include(p => p.College)
                .Where(p => p.Id == id)
                .SingleOrDefault();
        }
    }
}
