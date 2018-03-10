using System;
using System.Data.Entity;
using ProspectManager.Models;

namespace ProspectManager.Data
{

    // custom database initializer class to populate the database with seed data.
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var collegeARK = new College()
            {
                CollegeName = "Arkansas"
            };

            var collegeUGA = new College()
            {
                CollegeName = "Georgia"
            };

            var collegeND = new College()
            {
                CollegeName = "Notre Dame"
            };

            var collegeOSU = new College()
            {
                CollegeName = "Ohio State"
            };

            var collegeOK = new College()
            {
                CollegeName = "Oklahoma"
            };

            var collegeTX = new College()
            {
                CollegeName = "Texas"
            };

            var collegeUTEP = new College()
            {
                CollegeName = "UTEP"
            };

            var prospect1 = new Prospect()
            {
                FirstName = "Orlando"
            ,   LastName = "Brown"
            ,   Position = "OT"
            ,   College = collegeOK
            ,   HeightFeet = 6
            ,   HeightInches = 8
            ,   Weight = 345
            ,   BirthYear = 1996
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect1);

            var prospect2 = new Prospect()
            {
                FirstName = "Will"
            ,   LastName = "Hernandez"
            ,   Position = "G"
            ,   College = collegeUTEP
            ,   HeightFeet = 6
            ,   HeightInches = 3
            ,   Weight = 304
            ,   BirthYear = 1995
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect2);

            var prospect3 = new Prospect()
            {
                FirstName = "Jamarco"
            ,   LastName = "Jones"
            ,   Position = "OT"
            ,   College = collegeOSU
            ,   HeightFeet = 6
            ,   HeightInches = 5
            ,   Weight = 310
            ,   BirthYear = 1996
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect3);

            var prospect4 = new Prospect()
            {
                FirstName = "Mike"
            ,   LastName = "McGlinchey"
            ,   Position = "OT"
            ,   College = collegeND
            ,   HeightFeet = 6
            ,   HeightInches = 7
            ,   Weight = 291
            ,   BirthYear = 1994
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect4);

            var prospect5 = new Prospect()
            {
                FirstName = "Quenton"
            ,   LastName = "Nelson"
            ,   Position = "G"
            ,   College = collegeND
            ,   HeightFeet = 6
            ,   HeightInches = 5
            ,   Weight = 330
            ,   BirthYear = 1996
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect5);

            var prospect6 = new Prospect()
            {
                FirstName = "Billy"
            ,   LastName = "Price"
            ,   Position = "C"
            ,   College = collegeOSU
            ,   HeightFeet = 6
            ,   HeightInches = 4
            ,   Weight = 312
            ,   BirthYear = 1995
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect6);

            var prospect7 = new Prospect()
            {
                FirstName = "Frank"
            ,   LastName = "Ragnow"
            ,   Position = "C"
            ,   College = collegeARK
            ,   HeightFeet = 6
            ,   HeightInches = 5
            ,   Weight = 317
            ,   BirthYear = 1996
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect7);

            var prospect8 = new Prospect()
            {
                FirstName = "Connor"
            ,   LastName = "Williams"
            ,   Position = "OT"
            ,   College = collegeTX
            ,   HeightFeet = 6
            ,   HeightInches = 6
            ,   Weight = 288
            ,   BirthYear = 1997
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect8);

            var prospect9 = new Prospect()
            {
                FirstName = "Isaiah"
            ,   LastName = "Wynn"
            ,   Position = "G"
            ,   College = collegeUGA
            ,   HeightFeet = 6
            ,   HeightInches = 2
            ,   Weight = 302
            ,   BirthYear = 1995
            ,   DraftYear = 2018
            };
            context.Prospects.Add(prospect9);

            context.SaveChanges();
        }
    }
}
