//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInstitutionTelephoneTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInstitutionTelephoneType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInstitutionTelephoneType"> List
         /// </summary>
        public static List<RefInstitutionTelephoneType> RefInstitutionTelephoneTypeList = new List<RefInstitutionTelephoneType>
        {
            new RefInstitutionTelephoneType { Id=Guid.Parse("b7196f59-b9cc-4cec-9796-6fb1299b4273"), Code="Main", Description="Main phone number", Definition="Main phone number is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("da750256-957b-4845-973a-a15f9bd61216"), Code="Administrative", Description="Administrative phone number", Definition="Administrative phone number is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("7a7534a1-ca41-48ae-a7b3-3b18770d3590"), Code="HealthClinic", Description="Health clinic phone number", Definition="Health clinic phone number is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("6dcf4799-ecf7-4bbb-8fb9-6356c13a6878"), Code="Attendance", Description="Attendance line", Definition="Attendance line is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("5.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("16a1eef4-5290-4a60-9591-f05e503631f4"), Code="Fax", Description="Fax number", Definition="Fax number is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("6.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("dec026fc-8fa4-4d45-8185-3ec94c1b0a6b"), Code="FoodServices", Description="Cafeteria/Food Services", Definition="Cafeteria/Food Services is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("7.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("5168aef3-c189-4ffd-a29d-49d144e11384"), Code="Other", Description="Other", Definition="Other is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefInstitutionTelephoneType Pick List
         /// </summary>
        public static List<RefInstitutionTelephoneType> RefInstitutionTelephoneTypePickList = new List<RefInstitutionTelephoneType>
        {
            new RefInstitutionTelephoneType { Id=Guid.Parse("b7196f59-b9cc-4cec-9796-6fb1299b4273"), Code="Main", Description="Main phone number", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("da750256-957b-4845-973a-a15f9bd61216"), Code="Administrative", Description="Administrative phone number", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("7a7534a1-ca41-48ae-a7b3-3b18770d3590"), Code="HealthClinic", Description="Health clinic phone number", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("6dcf4799-ecf7-4bbb-8fb9-6356c13a6878"), Code="Attendance", Description="Attendance line", SortOrder=Convert.ToDecimal("5.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("16a1eef4-5290-4a60-9591-f05e503631f4"), Code="Fax", Description="Fax number", SortOrder=Convert.ToDecimal("6.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("dec026fc-8fa4-4d45-8185-3ec94c1b0a6b"), Code="FoodServices", Description="Cafeteria/Food Services", SortOrder=Convert.ToDecimal("7.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("5168aef3-c189-4ffd-a29d-49d144e11384"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
