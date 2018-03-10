using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProspectManager.Data;
using ProspectManager.Models;

namespace ProspectManager.Data
{
    public class CollegesRepository : BaseRepository<College>
    {
        public CollegesRepository(Context context)
            : base(context)
        {
        }

        public override College Get(int id, bool includeRelatedEntities = true)
        {
            var colleges = Context.Colleges.AsQueryable();

            if (includeRelatedEntities)
            {
                colleges = colleges
                    .Include(c => c.Prospects);
            }

            return colleges
                .Where(c => c.Id == id)
                .SingleOrDefault();
        }

        public override IList<College> GetList()
        {
            return Context.Colleges
                .OrderBy(c => c.CollegeName)
                .ToList();
        }

        public bool CollegeHasName(int collegeId, string collegeName)
        {
            return Context.Colleges.Any(c => c.Id != collegeId && c.CollegeName == collegeName);
        }
    }
}