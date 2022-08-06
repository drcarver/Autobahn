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
        public static List<RefFacilityUtilityProviderType> RefFacilityUtilityProviderTypeList = new List<RefFacilityUtilityProviderType> =
        {
            new RefFacilityUtilityProviderType { Id=Guid.Parse("594bad2c-27d4-42c5-8457-ef1dd42ef7fb"), Code="Purchased is specified as an indication of how utilities are supplied to a site or a building by a company or provider.", Description="02852", Definition="", SortOrder=0 },
            new RefFacilityUtilityProviderType { Id=Guid.Parse("505aa239-5d7c-4969-9637-5ebef4e56f36"), Code="Self-generated is specified as an indication of how utilities are supplied to a site or a building by a company or provider.", Description="02851", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityUtilityProviderType Pick List
         /// </summary>
        public static List<RefFacilityUtilityProviderType> RefFacilityUtilityProviderTypePickList = new List<RefFacilityUtilityProviderType> =
        {
            new RefFacilityUtilityProviderType { Id=Guid.Parse("594bad2c-27d4-42c5-8457-ef1dd42ef7fb"), Code="Purchased is specified as an indication of how utilities are supplied to a site or a building by a company or provider.", SortOrder=0 },
            new RefFacilityUtilityProviderType { Id=Guid.Parse("505aa239-5d7c-4969-9637-5ebef4e56f36"), Code="Self-generated is specified as an indication of how utilities are supplied to a site or a building by a company or provider.", SortOrder=0 },
       };
   }
}
