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
        public static List<RefFacilityJointDevelopmentType> RefFacilityJointDevelopmentTypeList = new List<RefFacilityJointDevelopmentType>
        {
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("f94ca51f-d56f-4c09-a0a6-06e100c1ee4d"), Code="13690", Description="Dedicated", Definition="When a school space is exclusively available to the outside entity during the school day and after school. For example, an after-school office or storage area.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("66e1d3ab-7b5f-4a9c-8a5b-2a2d97ec8e5b"), Code="13689", Description="Shared", Definition="When the space is used by the school during school hours and by a non-school user after school hours. For example, a classroom for instruction during the school day and for after school program activities after school.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefFacilityJointDevelopmentType Pick List
         /// </summary>
        public static List<RefFacilityJointDevelopmentType> RefFacilityJointDevelopmentTypePickList = new List<RefFacilityJointDevelopmentType>
        {
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("f94ca51f-d56f-4c09-a0a6-06e100c1ee4d"), Code="13690", Description="Dedicated", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityJointDevelopmentType { Id=Guid.Parse("66e1d3ab-7b5f-4a9c-8a5b-2a2d97ec8e5b"), Code="13689", Description="Shared", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
