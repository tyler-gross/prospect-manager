using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectManager.Models
{
    public class Prospect
    {
        public int Id { get; set; }

        [Display(Name = "First Name"), Required, StringLength(35)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), Required, StringLength(35)]
        public string LastName { get; set; }

        [Required, StringLength(5)]
        public string Position { get; set; }

        [Display(Name = "College"), Required]
        public int CollegeId { get; set; }

        [Display(Name = "Height (feet)"), Required]
        public int HeightFeet { get; set; }

        [Display(Name = "Height (inches)"), Required]
        public int HeightInches { get; set; }

        [Display(Name = "Weight (lbs.)"), Required]
        public int Weight { get; set; }

        [Display(Name = "Birth Year"), Required]
        public int BirthYear { get; set; }

        [Display(Name = "Draft Year"), Required]
        public int DraftYear { get; set; }

        public College College { get; set; }
    }
}
