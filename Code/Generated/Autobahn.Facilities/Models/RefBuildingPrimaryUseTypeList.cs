//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingPrimaryUseTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingPrimaryUseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingPrimaryUseTypeModel"> List
         /// </summary>
        public static List<RefBuildingPrimaryUseTypeModel> RefBuildingPrimaryUseTypeList = new List<RefBuildingPrimaryUseTypeModel>
        {
            new RefBuildingPrimaryUseType { Id=Guid.Parse("93a004ed-910d-4fc0-b059-55d88591d830"), Code="13561", Description="Church", Definition="Church is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("62c83e9e-cfd2-4353-9818-2bf79da76232"), Code="13562", Description="Commercial office building", Definition="Commercial office building is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("03f7ce47-f269-4e56-9343-c0afe805b921"), Code="13563", Description="Commercial warehouse", Definition="Commercial warehouse is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("3f213953-cd50-4663-85ae-705117eb137e"), Code="13564", Description="Community center", Definition="Community center is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("92124f42-ac70-4e9e-8639-18a3dd4d6b0c"), Code="13565", Description="Public school building", Definition="Public school building is specified as the primary use type of the building in which a school is located.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefBuildingPrimaryUseType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingPrimaryUseTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingPrimaryUseType { Id=Guid.Parse("93a004ed-910d-4fc0-b059-55d88591d830"), Description="Church", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("62c83e9e-cfd2-4353-9818-2bf79da76232"), Description="Commercial office building", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("03f7ce47-f269-4e56-9343-c0afe805b921"), Description="Commercial warehouse", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("3f213953-cd50-4663-85ae-705117eb137e"), Description="Community center", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("92124f42-ac70-4e9e-8639-18a3dd4d6b0c"), Description="Public school building", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
