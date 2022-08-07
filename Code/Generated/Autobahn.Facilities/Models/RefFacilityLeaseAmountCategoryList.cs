//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityLeaseAmountCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityLeaseAmountCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityLeaseAmountCategoryModel"> List
         /// </summary>
        public static List<RefFacilityLeaseAmountCategoryModel> RefFacilityLeaseAmountCategoryList = new List<RefFacilityLeaseAmountCategoryModel>
        {
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("fe6faf8a-6d5e-40b9-8722-2127cd23e9b3"), Code="13720", Description="Base rent", Definition="Base rent is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("7e021f6b-a048-4ef1-8144-84c42e59b0ba"), Code="13721", Description="Credit", Definition="Credit is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("2794f343-5bfd-4817-a827-b34864413a13"), Code="13722", Description="Escalator", Definition="Escalator is specified as the category of payment that a school must pay to rent the facility that it is in.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefFacilityLeaseAmountCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityLeaseAmountCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("fe6faf8a-6d5e-40b9-8722-2127cd23e9b3"), Description="Base rent", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("7e021f6b-a048-4ef1-8144-84c42e59b0ba"), Description="Credit", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityLeaseAmountCategory { Id=Guid.Parse("2794f343-5bfd-4817-a827-b34864413a13"), Description="Escalator", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
