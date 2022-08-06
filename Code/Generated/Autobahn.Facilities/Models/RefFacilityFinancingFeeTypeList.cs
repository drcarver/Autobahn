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
        public static List<RefFacilityFinancingFeeType> RefFacilityFinancingFeeTypeList = new List<RefFacilityFinancingFeeType>
        {
            new RefFacilityFinancingFeeType { Id=Guid.Parse("eda8b6de-2b8b-43a6-a109-f8a7840cd379"), Code="13717", Description="Application fee", Definition="Some lenders may require a small fee as part of the application process. It may be nonrefundable.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("badf7f70-35b9-46ae-995b-300281c05516"), Code="13718", Description="Legal fee", Definition="A fee paid to a lender for legal fees.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("ce0a3f51-b3f4-4db5-b788-f4307c145073"), Code="13719", Description="Origination fee", Definition="A fee paid to a lender for processing a loan application; it is often stated as a percentage of the mortgage amount, or basis points, and paid at closing.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefFacilityFinancingFeeType Pick List
         /// </summary>
        public static List<RefFacilityFinancingFeeType> RefFacilityFinancingFeeTypePickList = new List<RefFacilityFinancingFeeType>
        {
            new RefFacilityFinancingFeeType { Id=Guid.Parse("eda8b6de-2b8b-43a6-a109-f8a7840cd379"), Code="13717", Description="Application fee", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("badf7f70-35b9-46ae-995b-300281c05516"), Code="13718", Description="Legal fee", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("ce0a3f51-b3f4-4db5-b788-f4307c145073"), Code="13719", Description="Origination fee", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
