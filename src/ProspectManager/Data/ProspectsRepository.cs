using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProspectManager.Models;

namespace ProspectManager.Data
{
    public class ProspectsRepository : BaseRepository<Prospect>
    {
        public ProspectsRepository(Context context)
            : base(context)
        {
        }

        public override Prospect Get(int id, bool includeRelatedEntities = true)
        {
            var prospects = Context.Prospects.AsQueryable();

            if (includeRelatedEntities)
            {
                prospects = prospects.Include(p => p.College);
            }

            return prospects
                .Where(p => p.Id == id)
                .SingleOrDefault();
        }

        public override IList<Prospect> GetList()
        {
            return Context.Prospects
                .Include(p => p.College)
                .OrderBy(p => p.College.CollegeName)
                .ToList();
        }
    }
}
