//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingJointUseSchedulingTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingJointUseSchedulingType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingJointUseSchedulingType"> List
         /// </summary>
        public static List<RefBuildingJointUseSchedulingType> RefBuildingJointUseSchedulingTypeList = new List<RefBuildingJointUseSchedulingType>
        {
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("db9e6831-9758-4cbd-9f82-2f517c7d99bc"), Code="13694", Description="Drop-in use", Definition="When the space is made available for informal, drop-in activities. In this case, the user does not reserve the space in advance. Usually, spaces are made available for drop-in use during specified hours and often the spaces available for drop-in use are outside the school building on the school grounds.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("f0d2b8f1-f4d2-4283-aaea-5e5c00df43b4"), Code="13697", Description="Long term lease", Definition="When a school space is shared or dedicated in a contractual lease to provide exclusive access to an outside entity for a period of time of at least five years and if associated with joint development may be over 20 years.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("ba5af5b4-0ba6-4f59-b9c7-8c25228b7466"), Code="13695", Description="One-time event use", Definition="When a non-district entity utilizes a school space through a one time written use agreement.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("51a14022-8e72-4bef-a552-8d4234b618c4"), Code="13696", Description="Short-term lease", Definition="When a non-district entity enters into a written agreement for the use of school space for a specified number of hours over a period of time of less than 5 years.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefBuildingJointUseSchedulingType Pick List
         /// </summary>
        public static List<RefBuildingJointUseSchedulingType> RefBuildingJointUseSchedulingTypePickList = new List<RefBuildingJointUseSchedulingType>
        {
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("db9e6831-9758-4cbd-9f82-2f517c7d99bc"), Code="13694", Description="Drop-in use", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("f0d2b8f1-f4d2-4283-aaea-5e5c00df43b4"), Code="13697", Description="Long term lease", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("ba5af5b4-0ba6-4f59-b9c7-8c25228b7466"), Code="13695", Description="One-time event use", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("51a14022-8e72-4bef-a552-8d4234b618c4"), Code="13696", Description="Short-term lease", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
