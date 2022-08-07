//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityComplianceAgencyTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityComplianceAgencyType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityComplianceAgencyTypeModel"> List
         /// </summary>
        public static List<RefFacilityComplianceAgencyTypeModel> RefFacilityComplianceAgencyTypeList = new List<RefFacilityComplianceAgencyTypeModel>
        {
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("d2e42d47-e715-4c55-a1e3-31651c457b04"), Code="00865", Description="Charter board", Definition="The charter agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting school facilities.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("08d0a782-8e85-4ff4-beb5-ad0c536c56f1"), Code="13652", Description="Federal Agency", Definition="The federal agency or agencies with responsibility and authority for evaluating and enforcing compliance with federal requirements affecting public school facilities.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("4f77c49d-590a-4101-8d8c-ebd02e5b363b"), Code="00862", Description="Local (e.g., school board, city council, municipal board)", Definition="The local public agency or agencies with responsibility and authority for evaluating and enforcing compliance with local municipal requirements affecting public school facilities.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("fc117d33-8026-4e3a-a972-db4070f987b8"), Code="00864", Description="Private/Religious", Definition="The private/religious agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting school facilities.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("03f242c0-4016-417e-9941-955a59525e6b"), Code="00214", Description="Regional or intermediate educational agency", Definition="The regional or intermediate educational agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting public school facilities.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("100c9d82-2906-49ab-bd06-cd9f5e94e1e4"), Code="00860", Description="State agency", Definition="The state agency or agencies with responsibility and authority for evaluating and enforcing compliance with state requirements affecting public school facilities.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefFacilityComplianceAgencyType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityComplianceAgencyTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("d2e42d47-e715-4c55-a1e3-31651c457b04"), Description="Charter board", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("08d0a782-8e85-4ff4-beb5-ad0c536c56f1"), Description="Federal Agency", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("4f77c49d-590a-4101-8d8c-ebd02e5b363b"), Description="Local (e.g., school board, city council, municipal board)", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("fc117d33-8026-4e3a-a972-db4070f987b8"), Description="Private/Religious", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("03f242c0-4016-417e-9941-955a59525e6b"), Description="Regional or intermediate educational agency", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("100c9d82-2906-49ab-bd06-cd9f5e94e1e4"), Description="State agency", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
