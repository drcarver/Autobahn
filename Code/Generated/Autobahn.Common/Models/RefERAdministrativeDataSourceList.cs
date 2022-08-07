//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefERAdministrativeDataSourceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefERAdministrativeDataSource Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefERAdministrativeDataSourceModel"> List
         /// </summary>
        public static List<RefERAdministrativeDataSourceModel> RefERAdministrativeDataSourceList = new List<RefERAdministrativeDataSourceModel>
        {
            new RefERAdministrativeDataSource { Id=Guid.Parse("bebc8547-e2e2-4df2-810c-f5331a2fbab6"), Code="01", Description="State UI Wage Records", Definition="State UI Wage Records is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=Convert.ToDecimal("1.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("694b6d0e-982c-4538-830f-cdb84d8db67b"), Code="02", Description="Wage Record Interchange System (WRIS II)", Definition="Wage Record Interchange System (WRIS II) is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=Convert.ToDecimal("2.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("965d0d83-58c9-4901-bc6d-f04527775fd5"), Code="03", Description="Federal Employment Data Exchange System (FEDES)", Definition="Federal Employment Data Exchange System (FEDES) is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=Convert.ToDecimal("3.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("ea1e4c65-8c66-4b41-948c-2029d4e769f3"), Code="04", Description="Other", Definition="The administrative data source of information used to collect employment and earnings-related data is in a category not defined in CEDS.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefERAdministrativeDataSource Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefERAdministrativeDataSourceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefERAdministrativeDataSource { Id=Guid.Parse("bebc8547-e2e2-4df2-810c-f5331a2fbab6"), Description="State UI Wage Records", SortOrder=Convert.ToDecimal("1.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("694b6d0e-982c-4538-830f-cdb84d8db67b"), Description="Wage Record Interchange System (WRIS II)", SortOrder=Convert.ToDecimal("2.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("965d0d83-58c9-4901-bc6d-f04527775fd5"), Description="Federal Employment Data Exchange System (FEDES)", SortOrder=Convert.ToDecimal("3.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("ea1e4c65-8c66-4b41-948c-2029d4e769f3"), Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
