//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepEnrollmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepEnrollmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepEnrollmentType"> List
         /// </summary>
        public static List<RefMepEnrollmentType> RefMepEnrollmentTypeList = new List<RefMepEnrollmentType>
        {
            new RefMepEnrollmentType { Id=Guid.Parse("c2428717-ef67-4e56-9029-85680b76e1d9"), Code="01", Description="Basic School Program", Definition="Basic School Program is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("75ddce63-4d8d-40ac-84e9-513d950f86d3"), Code="02", Description="Regular Term MEP-Funded Project", Definition="Regular Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("03ff1966-3635-4d89-b5b2-e5104afa8b7e"), Code="03", Description="Summer/Intersession MEP-Funded Project", Definition="Summer/Intersession MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("1d0a18d0-b8c8-4f10-86b1-15ed882f7919"), Code="04", Description="Year Round MEP-Funded Project", Definition="Year Round MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("3a39ad80-8939-436d-9984-2f1e3f659a3e"), Code="05", Description="Basic School Program and Regular-Term MEP-Funded Project", Definition="Basic School Program and Regular-Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("09286bad-caaa-404b-aef6-d71cf63140ed"), Code="06", Description="Residency Only (none of the above)", Definition="Residency Only (none of the above)", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefMepEnrollmentType Pick List
         /// </summary>
        public static List<RefMepEnrollmentType> RefMepEnrollmentTypePickList = new List<RefMepEnrollmentType>
        {
            new RefMepEnrollmentType { Id=Guid.Parse("c2428717-ef67-4e56-9029-85680b76e1d9"), Code="01", Description="Basic School Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("75ddce63-4d8d-40ac-84e9-513d950f86d3"), Code="02", Description="Regular Term MEP-Funded Project", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("03ff1966-3635-4d89-b5b2-e5104afa8b7e"), Code="03", Description="Summer/Intersession MEP-Funded Project", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("1d0a18d0-b8c8-4f10-86b1-15ed882f7919"), Code="04", Description="Year Round MEP-Funded Project", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("3a39ad80-8939-436d-9984-2f1e3f659a3e"), Code="05", Description="Basic School Program and Regular-Term MEP-Funded Project", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("09286bad-caaa-404b-aef6-d71cf63140ed"), Code="06", Description="Residency Only (none of the above)", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
