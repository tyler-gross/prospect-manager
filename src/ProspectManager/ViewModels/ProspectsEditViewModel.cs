using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProspectManager.ViewModels
{

    // view model class for the "Edit Prospect" views
    public class ProspectsEditViewModel : ProspectsBaseViewModel
    {

        // This property enables model binding to be able to bind the "id" route parameter value to the "Prospect.Id" model property
        public int Id
        {
            get { return Prospect.Id; }
            set { Prospect.Id = value; }
        }
    }
}