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
        /// The complete <see cref="RefFacilityJointDevelopmentType"> List
         /// </summary>
        public static List<RefFacilityJointDevelopmentType> RefFacilityJointDevelopmentTypeList = new List<RefFacilityJointDevelopmentType> =
        {
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("bf03030a-7b84-475d-af70-81b829568632"), Code="When a school space is exclusively available to the outside entity during the school day and after school. For example, an after-school office or storage area.", Description="13690", Definition="", SortOrder=0 },
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("8d0950a9-dfc2-44dc-99c8-6cc4f80e8f9c"), Code="When the space is used by the school during school hours and by a non-school user after school hours. For example, a classroom for instruction during the school day and for after school program activities after school.", Description="13689", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityJointDevelopmentType Pick List
         /// </summary>
        public static List<RefFacilityJointDevelopmentType> RefFacilityJointDevelopmentTypePickList = new List<RefFacilityJointDevelopmentType> =
        {
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("bf03030a-7b84-475d-af70-81b829568632"), Code="When a school space is exclusively available to the outside entity during the school day and after school. For example, an after-school office or storage area.", SortOrder=0 },
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("8d0950a9-dfc2-44dc-99c8-6cc4f80e8f9c"), Code="When the space is used by the school during school hours and by a non-school user after school hours. For example, a classroom for instruction during the school day and for after school program activities after school.", SortOrder=0 },
       };
   }
}
