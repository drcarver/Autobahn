//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityJointDevelopmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityJointDevelopmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityJointDevelopmentTypeModel"> List
         /// </summary>
        public static List<RefFacilityJointDevelopmentTypeModel> RefFacilityJointDevelopmentTypeList = new List<RefFacilityJointDevelopmentTypeModel>
        {
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("59af2bfe-d90d-4bf0-a6e1-82140027d357"), Code="13690", Description="Dedicated", Definition="When a school space is exclusively available to the outside entity during the school day and after school. For example, an after-school office or storage area.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("106ce731-3611-4d68-ab1a-6dee8afbc68e"), Code="13689", Description="Shared", Definition="When the space is used by the school during school hours and by a non-school user after school hours. For example, a classroom for instruction during the school day and for after school program activities after school.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefFacilityJointDevelopmentType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityJointDevelopmentTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("59af2bfe-d90d-4bf0-a6e1-82140027d357"), Description="Dedicated", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("106ce731-3611-4d68-ab1a-6dee8afbc68e"), Description="Shared", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
