//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefIDEAEnvironmentELList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefIDEAEnvironmentEL Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAEnvironmentELModel"> List
         /// </summary>
        public static List<RefIDEAEnvironmentELModel> RefIDEAEnvironmentELList = new List<RefIDEAEnvironmentELModel>
        {
            new RefIDEAEnvironmentEL { Id=Guid.Parse("fdb9562b-77a3-4687-a9b5-18cbe0ca2a7e"), Code="REC09YOTHLOC", Description="Other location regular early childhood program (less than 10 hours)", Definition="Other location regular early childhood program (less than 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("098f52f1-9331-42d1-bee7-b9a16c2c1d04"), Code="REC10YOTHLOC", Description="Other location regular early childhood program (at least 10 hours)", Definition="Other location regular early childhood program (at least 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("5f4983bc-09a6-493d-ae2b-c66c59532794"), Code="REC09YSVCS", Description="Services regular early childhood program (less than 10 hours)", Definition="Services regular early childhood program (less than 10 hours) is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("d697cb8a-909e-4cb3-8266-6c77b5fdbc89"), Code="REC10YSVCS", Description="Services regular early childhood program (at least10 hours)", Definition="Services regular early childhood program (at least10 hours)  is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("ffc5e12d-84cc-45d9-95af-030508376a6c"), Code="SC", Description="Separate special education class", Definition="Separate special education class is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("a29e13e3-8a57-4243-b65c-5e1e5b4937d7"), Code="SS", Description="Separate school", Definition="Separate school is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("7c8300ef-e588-4b19-b657-d2cec0365879"), Code="RF", Description="Residential Facility", Definition="Residential Facility is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("b47b815e-64b2-4583-b5cb-43d521e3525a"), Code="H", Description="Home", Definition="Home is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("7ebcc969-4423-4f6b-b12c-625877a82e75"), Code="SPL", Description="Service provider or other location not in any other category", Definition="Service provider or other location not in any other category  is the environment in which children ages 3 through 5 attend and in which these children receive special education and related services.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefIDEAEnvironmentEL Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIDEAEnvironmentELViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIDEAEnvironmentEL { Id=Guid.Parse("fdb9562b-77a3-4687-a9b5-18cbe0ca2a7e"), Description="Other location regular early childhood program (less than 10 hours)", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("098f52f1-9331-42d1-bee7-b9a16c2c1d04"), Description="Other location regular early childhood program (at least 10 hours)", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("5f4983bc-09a6-493d-ae2b-c66c59532794"), Description="Services regular early childhood program (less than 10 hours)", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("d697cb8a-909e-4cb3-8266-6c77b5fdbc89"), Description="Services regular early childhood program (at least10 hours)", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("ffc5e12d-84cc-45d9-95af-030508376a6c"), Description="Separate special education class", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("a29e13e3-8a57-4243-b65c-5e1e5b4937d7"), Description="Separate school", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("7c8300ef-e588-4b19-b657-d2cec0365879"), Description="Residential Facility", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("b47b815e-64b2-4583-b5cb-43d521e3525a"), Description="Home", SortOrder=Convert.ToDecimal("8.00") },
            new RefIDEAEnvironmentEL { Id=Guid.Parse("7ebcc969-4423-4f6b-b12c-625877a82e75"), Description="Service provider or other location not in any other category", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
