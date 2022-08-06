//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefERAdministrativeDataSourceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefERAdministrativeDataSource Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefERAdministrativeDataSource"> List
         /// </summary>
        public static List<RefERAdministrativeDataSource> RefERAdministrativeDataSourceList = new List<RefERAdministrativeDataSource>
        {
            new RefERAdministrativeDataSource { Id=Guid.Parse("645d39af-8dc1-4e1e-96a6-9eff70cfd667"), Code="01", Description="State UI Wage Records", Definition="State UI Wage Records is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=Convert.ToDecimal("1.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("2d815938-5814-452f-84b0-7775c505a3ea"), Code="02", Description="Wage Record Interchange System (WRIS II)", Definition="Wage Record Interchange System (WRIS II) is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=Convert.ToDecimal("2.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("01b333ae-a0c6-4a7e-bb48-808aead016e3"), Code="03", Description="Federal Employment Data Exchange System (FEDES)", Definition="Federal Employment Data Exchange System (FEDES) is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=Convert.ToDecimal("3.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("6e6ed856-c207-46f5-9cc3-7aba504a2612"), Code="04", Description="Other", Definition="The administrative data source of information used to collect employment and earnings-related data is in a category not defined in CEDS.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefERAdministrativeDataSource Pick List
         /// </summary>
        public static List<RefERAdministrativeDataSource> RefERAdministrativeDataSourcePickList = new List<RefERAdministrativeDataSource>
        {
            new RefERAdministrativeDataSource { Id=Guid.Parse("645d39af-8dc1-4e1e-96a6-9eff70cfd667"), Code="01", Description="State UI Wage Records", SortOrder=Convert.ToDecimal("1.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("2d815938-5814-452f-84b0-7775c505a3ea"), Code="02", Description="Wage Record Interchange System (WRIS II)", SortOrder=Convert.ToDecimal("2.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("01b333ae-a0c6-4a7e-bb48-808aead016e3"), Code="03", Description="Federal Employment Data Exchange System (FEDES)", SortOrder=Convert.ToDecimal("3.00") },
            new RefERAdministrativeDataSource { Id=Guid.Parse("6e6ed856-c207-46f5-9cc3-7aba504a2612"), Code="04", Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
