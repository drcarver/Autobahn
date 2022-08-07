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
        /// The complete <see cref="RefBuildingJointUseSchedulingTypeModel"> List
         /// </summary>
        public static List<RefBuildingJointUseSchedulingTypeModel> RefBuildingJointUseSchedulingTypeList = new List<RefBuildingJointUseSchedulingTypeModel>
        {
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("75eff48a-dd09-46ca-b938-f77505a72c76"), Code="13694", Description="Drop-in use", Definition="When the space is made available for informal, drop-in activities. In this case, the user does not reserve the space in advance. Usually, spaces are made available for drop-in use during specified hours and often the spaces available for drop-in use are outside the school building on the school grounds.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("e7128e9b-71e2-4ae6-9b67-f20d0120a28b"), Code="13697", Description="Long term lease", Definition="When a school space is shared or dedicated in a contractual lease to provide exclusive access to an outside entity for a period of time of at least five years and if associated with joint development may be over 20 years.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("ee17e0af-fd6e-4e91-bda0-53ade696c740"), Code="13695", Description="One-time event use", Definition="When a non-district entity utilizes a school space through a one time written use agreement.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("154f7fc3-913d-4d1c-b1ec-82b667e6b4b0"), Code="13696", Description="Short-term lease", Definition="When a non-district entity enters into a written agreement for the use of school space for a specified number of hours over a period of time of less than 5 years.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefBuildingJointUseSchedulingType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingJointUseSchedulingTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("75eff48a-dd09-46ca-b938-f77505a72c76"), Description="Drop-in use", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("e7128e9b-71e2-4ae6-9b67-f20d0120a28b"), Description="Long term lease", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("ee17e0af-fd6e-4e91-bda0-53ade696c740"), Description="One-time event use", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUseSchedulingType { Id=Guid.Parse("154f7fc3-913d-4d1c-b1ec-82b667e6b4b0"), Description="Short-term lease", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
