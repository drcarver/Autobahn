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
        /// The complete <see cref="RefFacilityComplianceAgencyType"> List
         /// </summary>
        public static List<RefFacilityComplianceAgencyType> RefFacilityComplianceAgencyTypeList = new List<RefFacilityComplianceAgencyType>
        {
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("9bee0594-9abf-4aac-ba8e-d9bddb616e92"), Code="00865", Description="Charter board", Definition="The charter agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting school facilities.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("f42c81aa-25a8-45e2-bbaf-9a78642cad9d"), Code="13652", Description="Federal Agency", Definition="The federal agency or agencies with responsibility and authority for evaluating and enforcing compliance with federal requirements affecting public school facilities.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("3169c889-9f36-4454-baf0-74150981f8f1"), Code="00862", Description="Local (e.g., school board, city council, municipal board)", Definition="The local public agency or agencies with responsibility and authority for evaluating and enforcing compliance with local municipal requirements affecting public school facilities.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("69d3af27-8e5a-49ac-98fc-62b403c848b3"), Code="00864", Description="Private/Religious", Definition="The private/religious agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting school facilities.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("ee6ab8d9-2bfa-49d0-a158-e5d9447a512c"), Code="00214", Description="Regional or intermediate educational agency", Definition="The regional or intermediate educational agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting public school facilities.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("e8df3cc0-afac-4dcd-9de9-022b45f3c7a0"), Code="00860", Description="State agency", Definition="The state agency or agencies with responsibility and authority for evaluating and enforcing compliance with state requirements affecting public school facilities.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefFacilityComplianceAgencyType Pick List
         /// </summary>
        public static List<RefFacilityComplianceAgencyType> RefFacilityComplianceAgencyTypePickList = new List<RefFacilityComplianceAgencyType>
        {
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("9bee0594-9abf-4aac-ba8e-d9bddb616e92"), Code="00865", Description="Charter board", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("f42c81aa-25a8-45e2-bbaf-9a78642cad9d"), Code="13652", Description="Federal Agency", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("3169c889-9f36-4454-baf0-74150981f8f1"), Code="00862", Description="Local (e.g., school board, city council, municipal board)", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("69d3af27-8e5a-49ac-98fc-62b403c848b3"), Code="00864", Description="Private/Religious", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("ee6ab8d9-2bfa-49d0-a158-e5d9447a512c"), Code="00214", Description="Regional or intermediate educational agency", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("e8df3cc0-afac-4dcd-9de9-022b45f3c7a0"), Code="00860", Description="State agency", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
