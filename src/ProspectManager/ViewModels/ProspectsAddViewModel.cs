using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProspectManager.Models;

namespace ProspectManager.ViewModels
{

    // view model for the "Add Comic Book" view
    public class ProspectsAddViewModel : ProspectsBaseViewModel
    {
        public ProspectsAddViewModel()
        {
            // Set the comic book default values.
            Prospect.HeightFeet = 6;
            Prospect.HeightInches = 0;
            Prospect.Weight = 250;
            Prospect.DraftYear = DateTime.Today.Year;
        }
    }
}