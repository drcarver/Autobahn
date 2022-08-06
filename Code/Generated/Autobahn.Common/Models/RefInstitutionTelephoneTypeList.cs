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
        public static List<RefInstitutionTelephoneType> RefInstitutionTelephoneTypeList = new List<RefInstitutionTelephoneType> =
        {
            new RefInstitutionTelephoneType { Id=Guid.Parse("ac760bcc-834f-4428-874c-c8d5bdce5d1d"), Code="Main phone number is the type of communication number listed for an organization.", Description="Main", Definition="", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("f0dc4c8f-3153-4871-9e9a-1854ab459e3e"), Code="Administrative phone number is the type of communication number listed for an organization.", Description="Administrative", Definition="", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("c00b6528-a2ae-475e-9ed6-1ce16058aca8"), Code="Health clinic phone number is the type of communication number listed for an organization.", Description="HealthClinic", Definition="", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("9d244fb0-0452-4107-a167-d9bf29b9795d"), Code="Attendance line is the type of communication number listed for an organization.", Description="Attendance", Definition="", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("cfc8ab32-3404-4de4-b9c2-698b63c5e70d"), Code="Fax number is the type of communication number listed for an organization.", Description="Fax", Definition="", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("67c58352-0962-441c-84ed-7ed67ae56ed5"), Code="Cafeteria/Food Services is the type of communication number listed for an organization.", Description="FoodServices", Definition="", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("934ed356-445f-4a92-93ce-a24e92720073"), Code="Other is the type of communication number listed for an organization.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefInstitutionTelephoneType Pick List
         /// </summary>
        public static List<RefInstitutionTelephoneType> RefInstitutionTelephoneTypePickList = new List<RefInstitutionTelephoneType> =
        {
            new RefInstitutionTelephoneType { Id=Guid.Parse("ac760bcc-834f-4428-874c-c8d5bdce5d1d"), Code="Main phone number is the type of communication number listed for an organization.", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("f0dc4c8f-3153-4871-9e9a-1854ab459e3e"), Code="Administrative phone number is the type of communication number listed for an organization.", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("c00b6528-a2ae-475e-9ed6-1ce16058aca8"), Code="Health clinic phone number is the type of communication number listed for an organization.", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("9d244fb0-0452-4107-a167-d9bf29b9795d"), Code="Attendance line is the type of communication number listed for an organization.", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("cfc8ab32-3404-4de4-b9c2-698b63c5e70d"), Code="Fax number is the type of communication number listed for an organization.", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("67c58352-0962-441c-84ed-7ed67ae56ed5"), Code="Cafeteria/Food Services is the type of communication number listed for an organization.", SortOrder=0 },
            new RefInstitutionTelephoneType { Id=Guid.Parse("934ed356-445f-4a92-93ce-a24e92720073"), Code="Other is the type of communication number listed for an organization.", SortOrder=0 },
       };
   }
}
