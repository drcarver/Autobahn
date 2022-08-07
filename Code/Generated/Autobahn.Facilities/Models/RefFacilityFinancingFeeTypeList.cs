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
        /// The complete <see cref="RefFacilityFinancingFeeTypeModel"> List
         /// </summary>
        public static List<RefFacilityFinancingFeeTypeModel> RefFacilityFinancingFeeTypeList = new List<RefFacilityFinancingFeeTypeModel>
        {
            new RefFacilityFinancingFeeType { Id=Guid.Parse("f28562e9-b2cc-49b9-8b95-cbe06f252ff1"), Code="13717", Description="Application fee", Definition="Some lenders may require a small fee as part of the application process. It may be nonrefundable.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("f24fe0e6-5928-4450-ba92-15467d5df3fe"), Code="13718", Description="Legal fee", Definition="A fee paid to a lender for legal fees.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("be3d027a-15e5-4c62-bd2b-f4df9cf905df"), Code="13719", Description="Origination fee", Definition="A fee paid to a lender for processing a loan application; it is often stated as a percentage of the mortgage amount, or basis points, and paid at closing.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefFacilityFinancingFeeType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityFinancingFeeTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityFinancingFeeType { Id=Guid.Parse("f28562e9-b2cc-49b9-8b95-cbe06f252ff1"), Description="Application fee", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("f24fe0e6-5928-4450-ba92-15467d5df3fe"), Description="Legal fee", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityFinancingFeeType { Id=Guid.Parse("be3d027a-15e5-4c62-bd2b-f4df9cf905df"), Description="Origination fee", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
