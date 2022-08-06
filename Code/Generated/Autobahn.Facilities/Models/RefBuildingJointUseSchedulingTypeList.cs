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
        public static List<RefBuildingJointUseSchedulingType> RefBuildingJointUseSchedulingTypeList = new List<RefBuildingJointUseSchedulingType> =
        {
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("7feac619-3f66-4c11-a516-a3e156f46b56"), Code="When the space is made available for informal, drop-in activities. In this case, the user does not reserve the space in advance. Usually, spaces are made available for drop-in use during specified hours and often the spaces available for drop-in use are outside the school building on the school grounds.", Description="13694", Definition="", SortOrder=0 },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("9c4a51cf-a956-4705-b555-b795b3890066"), Code="When a school space is shared or dedicated in a contractual lease to provide exclusive access to an outside entity for a period of time of at least five years and if associated with joint development may be over 20 years.", Description="13697", Definition="", SortOrder=0 },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("35b8e1c4-bcd6-4403-a931-0cda265204ea"), Code="When a non-district entity utilizes a school space through a one time written use agreement.", Description="13695", Definition="", SortOrder=0 },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("7bc531fc-ac67-4d3a-9c0c-3da43f63a2c2"), Code="When a non-district entity enters into a written agreement for the use of school space for a specified number of hours over a period of time of less than 5 years.", Description="13696", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingJointUseSchedulingType Pick List
         /// </summary>
        public static List<RefBuildingJointUseSchedulingType> RefBuildingJointUseSchedulingTypePickList = new List<RefBuildingJointUseSchedulingType> =
        {
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("7feac619-3f66-4c11-a516-a3e156f46b56"), Code="When the space is made available for informal, drop-in activities. In this case, the user does not reserve the space in advance. Usually, spaces are made available for drop-in use during specified hours and often the spaces available for drop-in use are outside the school building on the school grounds.", SortOrder=0 },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("9c4a51cf-a956-4705-b555-b795b3890066"), Code="When a school space is shared or dedicated in a contractual lease to provide exclusive access to an outside entity for a period of time of at least five years and if associated with joint development may be over 20 years.", SortOrder=0 },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("35b8e1c4-bcd6-4403-a931-0cda265204ea"), Code="When a non-district entity utilizes a school space through a one time written use agreement.", SortOrder=0 },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("7bc531fc-ac67-4d3a-9c0c-3da43f63a2c2"), Code="When a non-district entity enters into a written agreement for the use of school space for a specified number of hours over a period of time of less than 5 years.", SortOrder=0 },
       };
   }
}
