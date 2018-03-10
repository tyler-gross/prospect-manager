using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProspectManager.Data;
using ProspectManager.Models;

namespace ProspectManager.ViewModels
{

    // base view model class for the "Add Prospect" and "Edit Prospect" views
    public abstract class ProspectsBaseViewModel
    {
        public Prospect Prospect { get; set; } = new Prospect();

        public SelectList CollegeSelectListItems { get; set; }

        public virtual void Init(Repository repository, CollegesRepository collegesRepository)
        {
            CollegeSelectListItems = new SelectList(
                collegesRepository.GetList()
            ,   "Id"
            ,   "CollegeName"
            );
        }
    }
}