//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBRevenueRestrictionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPEDSFASBRevenueRestriction Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPEDSFASBRevenueRestriction"> List
         /// </summary>
        public static List<RefIPEDSFASBRevenueRestriction> RefIPEDSFASBRevenueRestrictionList = new List<RefIPEDSFASBRevenueRestriction>
        {
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("23455a17-1811-4c95-abca-0fda636dc05b"), Code="PermanentlyRestricted", Description="Permanently Restricted", Definition="Used for reporting revenues that must be maintained in perpetuity due to a donor-imposed restriction.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("a523f319-d91e-46cf-827c-57ed8baa7c55"), Code="TemporarilyRestricted", Description="Temporarily Restricted", Definition="Used for reporting revenues that are subject to limitation by donor specification as to use or the time when use may occur (such as a later period of time or after specified events have occurred).", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("a17ccd2d-0ddc-4de8-bdc6-bee812bf3fe1"), Code="Unrestricted", Description="Unrestricted", Definition="Used for reporting revenues that are not subject to limitations by a donor-imposed restriction.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefIPEDSFASBRevenueRestriction Pick List
         /// </summary>
        public static List<RefIPEDSFASBRevenueRestriction> RefIPEDSFASBRevenueRestrictionPickList = new List<RefIPEDSFASBRevenueRestriction>
        {
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("23455a17-1811-4c95-abca-0fda636dc05b"), Code="PermanentlyRestricted", Description="Permanently Restricted", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("a523f319-d91e-46cf-827c-57ed8baa7c55"), Code="TemporarilyRestricted", Description="Temporarily Restricted", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("a17ccd2d-0ddc-4de8-bdc6-bee812bf3fe1"), Code="Unrestricted", Description="Unrestricted", SortOrder=Convert.ToDecimal("") },
       };
   }
}
