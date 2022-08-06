//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityFinancingFeeTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityFinancingFeeType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityFinancingFeeType"> List
         /// </summary>
        public static List<RefFacilityFinancingFeeType> RefFacilityFinancingFeeTypeList = new List<RefFacilityFinancingFeeType> =
        {
            new RefFacilityFinancingFeeType { Id=Guid.Parse("ccea1b19-4b5f-4c5c-ad71-1ce003260f86"), Code="Some lenders may require a small fee as part of the application process. It may be nonrefundable.", Description="13717", Definition="", SortOrder=0 },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("890bc422-6db0-4e9c-bd6c-153ed41ee9c3"), Code="A fee paid to a lender for legal fees.", Description="13718", Definition="", SortOrder=0 },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("a792722b-bf70-4882-bcc4-0663c9049036"), Code="A fee paid to a lender for processing a loan application; it is often stated as a percentage of the mortgage amount, or basis points, and paid at closing.", Description="13719", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityFinancingFeeType Pick List
         /// </summary>
        public static List<RefFacilityFinancingFeeType> RefFacilityFinancingFeeTypePickList = new List<RefFacilityFinancingFeeType> =
        {
            new RefFacilityFinancingFeeType { Id=Guid.Parse("ccea1b19-4b5f-4c5c-ad71-1ce003260f86"), Code="Some lenders may require a small fee as part of the application process. It may be nonrefundable.", SortOrder=0 },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("890bc422-6db0-4e9c-bd6c-153ed41ee9c3"), Code="A fee paid to a lender for legal fees.", SortOrder=0 },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("a792722b-bf70-4882-bcc4-0663c9049036"), Code="A fee paid to a lender for processing a loan application; it is often stated as a percentage of the mortgage amount, or basis points, and paid at closing.", SortOrder=0 },
       };
   }
}
