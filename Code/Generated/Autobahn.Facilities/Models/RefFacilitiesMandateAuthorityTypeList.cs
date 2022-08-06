//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitiesMandateAuthorityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilitiesMandateAuthorityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilitiesMandateAuthorityType"> List
         /// </summary>
        public static List<RefFacilitiesMandateAuthorityType> RefFacilitiesMandateAuthorityTypeList = new List<RefFacilitiesMandateAuthorityType>
        {
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("8cd2571c-b285-4272-98da-6f2858ac8eb9"), Code="13390", Description="District/Local", Definition="District/Local is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("bfe40b9d-bca8-4833-aa2f-fcb638d704c2"), Code="00859", Description="Federal", Definition="Federal is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("49518e40-d4b6-49d5-a6a8-e0d1294ef12d"), Code="00391", Description="State", Definition="State is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefFacilitiesMandateAuthorityType Pick List
         /// </summary>
        public static List<RefFacilitiesMandateAuthorityType> RefFacilitiesMandateAuthorityTypePickList = new List<RefFacilitiesMandateAuthorityType>
        {
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("8cd2571c-b285-4272-98da-6f2858ac8eb9"), Code="13390", Description="District/Local", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("bfe40b9d-bca8-4833-aa2f-fcb638d704c2"), Code="00859", Description="Federal", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("49518e40-d4b6-49d5-a6a8-e0d1294ef12d"), Code="00391", Description="State", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
