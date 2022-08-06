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
        public static List<RefFacilityComplianceAgencyType> RefFacilityComplianceAgencyTypeList = new List<RefFacilityComplianceAgencyType> =
        {
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("eb7bb036-4dd6-427c-9fc5-7f1bc9bc966f"), Code="The charter agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting school facilities.", Description="00865", Definition="", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("c8a5ee2e-5a71-4d48-a544-700ab1466633"), Code="The federal agency or agencies with responsibility and authority for evaluating and enforcing compliance with federal requirements affecting public school facilities.", Description="13652", Definition="", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("cf529edf-b7ea-4abd-872f-6bf6e00b3a11"), Code="The local public agency or agencies with responsibility and authority for evaluating and enforcing compliance with local municipal requirements affecting public school facilities.", Description="00862", Definition="", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("b64cb021-dc0f-48dd-9554-b3e51b0e2e90"), Code="The private/religious agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting school facilities.", Description="00864", Definition="", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("0c5f6bc6-5380-4000-a600-38711590762f"), Code="The regional or intermediate educational agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting public school facilities.", Description="00214", Definition="", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("09cf0a4b-5f83-43f4-ab60-0312681070dc"), Code="The state agency or agencies with responsibility and authority for evaluating and enforcing compliance with state requirements affecting public school facilities.", Description="00860", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityComplianceAgencyType Pick List
         /// </summary>
        public static List<RefFacilityComplianceAgencyType> RefFacilityComplianceAgencyTypePickList = new List<RefFacilityComplianceAgencyType> =
        {
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("eb7bb036-4dd6-427c-9fc5-7f1bc9bc966f"), Code="The charter agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting school facilities.", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("c8a5ee2e-5a71-4d48-a544-700ab1466633"), Code="The federal agency or agencies with responsibility and authority for evaluating and enforcing compliance with federal requirements affecting public school facilities.", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("cf529edf-b7ea-4abd-872f-6bf6e00b3a11"), Code="The local public agency or agencies with responsibility and authority for evaluating and enforcing compliance with local municipal requirements affecting public school facilities.", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("b64cb021-dc0f-48dd-9554-b3e51b0e2e90"), Code="The private/religious agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting school facilities.", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("0c5f6bc6-5380-4000-a600-38711590762f"), Code="The regional or intermediate educational agency or agencies with responsibility and authority for evaluating and enforcing compliance with requirements affecting public school facilities.", SortOrder=0 },
            new RefFacilityComplianceAgencyType { Id=Guid.Parse("09cf0a4b-5f83-43f4-ab60-0312681070dc"), Code="The state agency or agencies with responsibility and authority for evaluating and enforcing compliance with state requirements affecting public school facilities.", SortOrder=0 },
       };
   }
}
