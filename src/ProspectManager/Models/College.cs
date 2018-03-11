using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectManager.Models
{
    public class College
    {
        public College()
        {
            Prospects = new List<Prospect>();
        }

        public int Id { get; set; }

        [Display(Name = "College Name"), Required, StringLength(50)]
        public string CollegeName { get; set; }

        public ICollection<Prospect> Prospects { get; set; }
    }
}
