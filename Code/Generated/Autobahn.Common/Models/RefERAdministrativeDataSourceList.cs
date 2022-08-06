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
        public static List<RefERAdministrativeDataSource> RefERAdministrativeDataSourceList = new List<RefERAdministrativeDataSource> =
        {
            new RefERAdministrativeDataSource { Id=Guid.Parse("36895a43-5c9b-460c-bac4-7b290f2c2b48"), Code="State UI Wage Records is the administrative data source of information used to collect employment and earnings-related data.", Description="01", Definition="", SortOrder=0 },
            new RefERAdministrativeDataSource { Id=Guid.Parse("fa4973a9-ab76-4761-8524-469f3994a22a"), Code="Wage Record Interchange System (WRIS II) is the administrative data source of information used to collect employment and earnings-related data.", Description="02", Definition="", SortOrder=0 },
            new RefERAdministrativeDataSource { Id=Guid.Parse("4fc4346b-cb07-4bdc-9850-fab2c6d8f752"), Code="Federal Employment Data Exchange System (FEDES) is the administrative data source of information used to collect employment and earnings-related data.", Description="03", Definition="", SortOrder=0 },
            new RefERAdministrativeDataSource { Id=Guid.Parse("c180e89e-ef66-4c25-8998-8bf64148aad3"), Code="The administrative data source of information used to collect employment and earnings-related data is in a category not defined in CEDS.", Description="04", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefERAdministrativeDataSource Pick List
         /// </summary>
        public static List<RefERAdministrativeDataSource> RefERAdministrativeDataSourcePickList = new List<RefERAdministrativeDataSource> =
        {
            new RefERAdministrativeDataSource { Id=Guid.Parse("36895a43-5c9b-460c-bac4-7b290f2c2b48"), Code="State UI Wage Records is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=0 },
            new RefERAdministrativeDataSource { Id=Guid.Parse("fa4973a9-ab76-4761-8524-469f3994a22a"), Code="Wage Record Interchange System (WRIS II) is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=0 },
            new RefERAdministrativeDataSource { Id=Guid.Parse("4fc4346b-cb07-4bdc-9850-fab2c6d8f752"), Code="Federal Employment Data Exchange System (FEDES) is the administrative data source of information used to collect employment and earnings-related data.", SortOrder=0 },
            new RefERAdministrativeDataSource { Id=Guid.Parse("c180e89e-ef66-4c25-8998-8bf64148aad3"), Code="The administrative data source of information used to collect employment and earnings-related data is in a category not defined in CEDS.", SortOrder=0 },
       };
   }
}
