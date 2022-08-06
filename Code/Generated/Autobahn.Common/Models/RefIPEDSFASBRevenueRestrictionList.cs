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
        public static List<RefIPEDSFASBRevenueRestriction> RefIPEDSFASBRevenueRestrictionList = new List<RefIPEDSFASBRevenueRestriction> =
        {
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("12017ab1-833e-4237-8c8a-c86ae7656430"), Code="Used for reporting revenues that must be maintained in perpetuity due to a donor-imposed restriction.", Description="PermanentlyRestricted", Definition="", SortOrder=0 },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("0a6cf37e-92ab-40be-81a2-8c399a915d6b"), Code="Used for reporting revenues that are subject to limitation by donor specification as to use or the time when use may occur (such as a later period of time or after specified events have occurred).", Description="TemporarilyRestricted", Definition="", SortOrder=0 },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("ee85fdc0-a517-4c00-b860-6cc334b6df1f"), Code="Used for reporting revenues that are not subject to limitations by a donor-imposed restriction.", Description="Unrestricted", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIPEDSFASBRevenueRestriction Pick List
         /// </summary>
        public static List<RefIPEDSFASBRevenueRestriction> RefIPEDSFASBRevenueRestrictionPickList = new List<RefIPEDSFASBRevenueRestriction> =
        {
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("12017ab1-833e-4237-8c8a-c86ae7656430"), Code="Used for reporting revenues that must be maintained in perpetuity due to a donor-imposed restriction.", SortOrder=0 },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("0a6cf37e-92ab-40be-81a2-8c399a915d6b"), Code="Used for reporting revenues that are subject to limitation by donor specification as to use or the time when use may occur (such as a later period of time or after specified events have occurred).", SortOrder=0 },
            new RefIPEDSFASBRevenueRestriction { Id=Guid.Parse("ee85fdc0-a517-4c00-b860-6cc334b6df1f"), Code="Used for reporting revenues that are not subject to limitations by a donor-imposed restriction.", SortOrder=0 },
       };
   }
}
