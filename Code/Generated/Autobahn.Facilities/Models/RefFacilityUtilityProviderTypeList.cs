//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityUtilityProviderTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityUtilityProviderType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityUtilityProviderType"> List
         /// </summary>
        public static List<RefFacilityUtilityProviderType> RefFacilityUtilityProviderTypeList = new List<RefFacilityUtilityProviderType>
        {
            new RefFacilityUtilityProviderType { Id=Guid.Parse("3888801c-087f-45d1-bd51-3aabfa32cb99"), Code="02852", Description="Purchased", Definition="Purchased is specified as an indication of how utilities are supplied to a site or a building by a company or provider.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityUtilityProviderType { Id=Guid.Parse("4d58c28d-a095-443c-819c-6608944f456f"), Code="02851", Description="Self-generated", Definition="Self-generated is specified as an indication of how utilities are supplied to a site or a building by a company or provider.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefFacilityUtilityProviderType Pick List
         /// </summary>
        public static List<RefFacilityUtilityProviderType> RefFacilityUtilityProviderTypePickList = new List<RefFacilityUtilityProviderType>
        {
            new RefFacilityUtilityProviderType { Id=Guid.Parse("3888801c-087f-45d1-bd51-3aabfa32cb99"), Code="02852", Description="Purchased", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityUtilityProviderType { Id=Guid.Parse("4d58c28d-a095-443c-819c-6608944f456f"), Code="02851", Description="Self-generated", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
