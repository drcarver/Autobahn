//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityConstructionDateTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityConstructionDateType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityConstructionDateTypeModel"> List
         /// </summary>
        public static List<RefFacilityConstructionDateTypeModel> RefFacilityConstructionDateTypeList = new List<RefFacilityConstructionDateTypeModel>
        {
            new RefFacilityConstructionDateType { Id=Guid.Parse("6cc59984-e26f-4511-a36c-c79d4ce53bbf"), Code="02420", Description="Actual", Definition="Construction was completed as judged by the owner putting the building or improvement into use.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityConstructionDateType { Id=Guid.Parse("7b288769-3e16-4d8c-a44a-62bfc481ab79"), Code="02421", Description="Estimated", Definition="The new building, addition, or improvement is expected to be completed so the owner is able to put the building or improvement into use.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefFacilityConstructionDateType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityConstructionDateTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityConstructionDateType { Id=Guid.Parse("6cc59984-e26f-4511-a36c-c79d4ce53bbf"), Description="Actual", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityConstructionDateType { Id=Guid.Parse("7b288769-3e16-4d8c-a44a-62bfc481ab79"), Description="Estimated", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
