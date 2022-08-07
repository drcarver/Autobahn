//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityMortgageTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityMortgageType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityMortgageTypeModel"> List
         /// </summary>
        public static List<RefFacilityMortgageTypeModel> RefFacilityMortgageTypeList = new List<RefFacilityMortgageTypeModel>
        {
            new RefFacilityMortgageType { Id=Guid.Parse("44372595-8ad1-4a46-b50b-591ecabc5779"), Code="13741", Description="Junior Mortgage", Definition="Any mortgage on a property that is subordinate to a senior mortgage in priority. Also called subordinated mortgage.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMortgageType { Id=Guid.Parse("31d97bf2-9029-4c0c-be7b-2fd4b493b20a"), Code="13742", Description="Multiple", Definition="A property may have multiple mortgages on it. Second mortgages are subordinate, meaning that in the event of default, the primary, or first mortgage would get paid off first, and then any funds remaining would be used to pay off any second mortgages.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMortgageType { Id=Guid.Parse("91e6b056-557e-408a-9084-42db09b9342d"), Code="13743", Description="Senior or first mortgage", Definition="The mortgage that has first claim in the event of a default. The first or senior mortgage typically has to be satisfied before the second or junior mortgage can enforce any claims against the property.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefFacilityMortgageType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityMortgageTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityMortgageType { Id=Guid.Parse("44372595-8ad1-4a46-b50b-591ecabc5779"), Description="Junior Mortgage", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMortgageType { Id=Guid.Parse("31d97bf2-9029-4c0c-be7b-2fd4b493b20a"), Description="Multiple", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMortgageType { Id=Guid.Parse("91e6b056-557e-408a-9084-42db09b9342d"), Description="Senior or first mortgage", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
