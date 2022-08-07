//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAEducationalEnvironmentECList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIDEAEducationalEnvironmentEC Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAEducationalEnvironmentECModel"> List
         /// </summary>
        public static List<RefIDEAEducationalEnvironmentECModel> RefIDEAEducationalEnvironmentECList = new List<RefIDEAEducationalEnvironmentECModel>
        {
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("28e182dd-922d-41e5-871a-447984905474"), Code="REC09YOTHLOC", Description="Other location regular early childhood program (less than 10 hours)", Definition="Other location regular early childhood program (less than 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("f614b952-091b-44a8-abb5-5805ac35b81e"), Code="REC10YOTHLOC", Description="Other location regular early childhood program (at least 10 hours)", Definition="Other location regular early childhood program (at least 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("836253d0-849b-404b-8bff-2af61c0159c8"), Code="REC09YSVCS", Description="Services regular early childhood program (less than 10 hours)", Definition="Services regular early childhood program (less than 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("92d372aa-6d73-4af2-9e51-830b8a1694a8"), Code="REC10YSVCS", Description="Services regular early childhood program (at least10 hours)", Definition="Services regular early childhood program (at least10 hours)  is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("acc77e7b-d56b-415d-a08e-067fa0dd6983"), Code="SC", Description="Separate special education class", Definition="Separate special education class is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("b1fc40f4-e035-43cc-a358-7eac385a5c70"), Code="SS", Description="Separate school", Definition="Separate school is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("9ba32596-5ce9-4a01-acc2-11591bc16f01"), Code="RF", Description="Residential Facility", Definition="Residential Facility is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("9f4fa9e9-21ed-4ed7-a1f3-3999811184bf"), Code="H", Description="Home", Definition="Home is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("48767c1b-f39e-4353-b688-d0c1563ca974"), Code="SPL", Description="Service provider or other location not in any other category", Definition="Service provider or other location not in any other category  is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefIDEAEducationalEnvironmentEC Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIDEAEducationalEnvironmentECViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("28e182dd-922d-41e5-871a-447984905474"), Description="Other location regular early childhood program (less than 10 hours)", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("f614b952-091b-44a8-abb5-5805ac35b81e"), Description="Other location regular early childhood program (at least 10 hours)", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("836253d0-849b-404b-8bff-2af61c0159c8"), Description="Services regular early childhood program (less than 10 hours)", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("92d372aa-6d73-4af2-9e51-830b8a1694a8"), Description="Services regular early childhood program (at least10 hours)", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("acc77e7b-d56b-415d-a08e-067fa0dd6983"), Description="Separate special education class", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("b1fc40f4-e035-43cc-a358-7eac385a5c70"), Description="Separate school", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("9ba32596-5ce9-4a01-acc2-11591bc16f01"), Description="Residential Facility", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("9f4fa9e9-21ed-4ed7-a1f3-3999811184bf"), Description="Home", SortOrder=Convert.ToDecimal("8.00") },
            new RefIDEAEducationalEnvironmentEC { Id=Guid.Parse("48767c1b-f39e-4353-b688-d0c1563ca974"), Description="Service provider or other location not in any other category", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
