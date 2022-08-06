//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAEducationalEnvironmentSchoolAgeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIDEAEducationalEnvironmentSchoolAge Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAEducationalEnvironmentSchoolAge"> List
         /// </summary>
        public static List<RefIDEAEducationalEnvironmentSchoolAge> RefIDEAEducationalEnvironmentSchoolAgeList = new List<RefIDEAEducationalEnvironmentSchoolAge>
        {
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("cfabb70a-a922-43cf-8363-79337f67145e"), Code="RC80", Description="Inside regular class 80% or more of the day", Definition="Inside regular class 80% or more of the day is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("40ea573a-e9fa-4511-a909-95b31f24046d"), Code="RC79TO40", Description="Inside regular class 40% through 79% of the day", Definition="Inside regular class 40% through 79% of the day is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("91462551-63eb-4db0-ba68-1c34e41b3bb1"), Code="RC39", Description="Inside regular class less than 40% of the day", Definition="Inside regular class less than 40% of the day is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("1182cdbd-5e3c-41bb-ad97-0a20c3322f8b"), Code="SS", Description="Separate school", Definition="Separate school is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("c1a79d8a-c160-44e4-b200-06e2706a4410"), Code="RF", Description="Residential facility", Definition="Residential facility is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("cfd2a599-4de2-48b0-a87d-4d2c721f015c"), Code="HH", Description="Homebound/hospital", Definition="Homebound/hospital is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("4bcd8c74-84df-4312-a178-907e725e5423"), Code="CF", Description="Correctional facility", Definition="Correctional facility is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("cb71e6c4-138d-434a-aef3-6093819c46bc"), Code="PPPS", Description="Parentally placed in private school", Definition="Parentally placed in private school is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefIDEAEducationalEnvironmentSchoolAge Pick List
         /// </summary>
        public static List<RefIDEAEducationalEnvironmentSchoolAge> RefIDEAEducationalEnvironmentSchoolAgePickList = new List<RefIDEAEducationalEnvironmentSchoolAge>
        {
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("cfabb70a-a922-43cf-8363-79337f67145e"), Code="RC80", Description="Inside regular class 80% or more of the day", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("40ea573a-e9fa-4511-a909-95b31f24046d"), Code="RC79TO40", Description="Inside regular class 40% through 79% of the day", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("91462551-63eb-4db0-ba68-1c34e41b3bb1"), Code="RC39", Description="Inside regular class less than 40% of the day", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("1182cdbd-5e3c-41bb-ad97-0a20c3322f8b"), Code="SS", Description="Separate school", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("c1a79d8a-c160-44e4-b200-06e2706a4410"), Code="RF", Description="Residential facility", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("cfd2a599-4de2-48b0-a87d-4d2c721f015c"), Code="HH", Description="Homebound/hospital", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("4bcd8c74-84df-4312-a178-907e725e5423"), Code="CF", Description="Correctional facility", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("cb71e6c4-138d-434a-aef3-6093819c46bc"), Code="PPPS", Description="Parentally placed in private school", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
