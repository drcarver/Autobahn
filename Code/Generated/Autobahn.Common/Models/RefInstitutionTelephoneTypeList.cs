//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInstitutionTelephoneTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInstitutionTelephoneType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInstitutionTelephoneTypeModel"> List
         /// </summary>
        public static List<RefInstitutionTelephoneTypeModel> RefInstitutionTelephoneTypeList = new List<RefInstitutionTelephoneTypeModel>
        {
            new RefInstitutionTelephoneType { Id=Guid.Parse("5c0e39ae-eb2b-406b-a862-d9dbcfeeaa08"), Code="Main", Description="Main phone number", Definition="Main phone number is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("57584981-0023-40a2-b441-d6472067942d"), Code="Administrative", Description="Administrative phone number", Definition="Administrative phone number is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("d2c929c0-05ef-4285-a8b4-b287fa280386"), Code="HealthClinic", Description="Health clinic phone number", Definition="Health clinic phone number is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("ebebca7e-cf01-429c-bdc6-7207202238df"), Code="Attendance", Description="Attendance line", Definition="Attendance line is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("5.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("e3bdf7ca-3ffd-4f1f-b24f-9b045c1f3697"), Code="Fax", Description="Fax number", Definition="Fax number is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("6.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("69ba8171-04fe-47bc-a552-d56b27eb100c"), Code="FoodServices", Description="Cafeteria/Food Services", Definition="Cafeteria/Food Services is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("7.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("5a9e45ad-0fc1-48cf-ac64-4e3bf59ec1ce"), Code="Other", Description="Other", Definition="Other is the type of communication number listed for an organization.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefInstitutionTelephoneType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefInstitutionTelephoneTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefInstitutionTelephoneType { Id=Guid.Parse("5c0e39ae-eb2b-406b-a862-d9dbcfeeaa08"), Description="Main phone number", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("57584981-0023-40a2-b441-d6472067942d"), Description="Administrative phone number", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("d2c929c0-05ef-4285-a8b4-b287fa280386"), Description="Health clinic phone number", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("ebebca7e-cf01-429c-bdc6-7207202238df"), Description="Attendance line", SortOrder=Convert.ToDecimal("5.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("e3bdf7ca-3ffd-4f1f-b24f-9b045c1f3697"), Description="Fax number", SortOrder=Convert.ToDecimal("6.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("69ba8171-04fe-47bc-a552-d56b27eb100c"), Description="Cafeteria/Food Services", SortOrder=Convert.ToDecimal("7.00") },
            new RefInstitutionTelephoneType { Id=Guid.Parse("5a9e45ad-0fc1-48cf-ac64-4e3bf59ec1ce"), Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
