//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefStaffPerformanceLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefStaffPerformanceLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStaffPerformanceLevel"> List
         /// </summary>
        public static List<RefStaffPerformanceLevel> RefStaffPerformanceLevelList = new List<RefStaffPerformanceLevel> =
        {
            new RefStaffPerformanceLevel { Id=Guid.Parse("f045dafb-eb45-47be-867b-b415e70c86c5"), Code="Level 1 (lowest level) is the level used in the district evaluation system for the teacher or principal performance rating.", Description="FAL1", Definition="", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("16c44242-f73b-48cc-a19a-ae5c27118c17"), Code="Level 2 is the level used in the district evaluation system for the teacher or principal performance rating.", Description="FAL2", Definition="", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("68ec76c6-d4d0-45dd-ad1a-974ea0cb9fc4"), Code="Level 3 is the level used in the district evaluation system for the teacher or principal performance rating.", Description="FAL3", Definition="", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("d98fcd9a-e0f1-4349-b4d0-96eff2596386"), Code="Level 4 is the level used in the district evaluation system for the teacher or principal performance rating.", Description="FAL4", Definition="", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("17025e17-a4ac-4696-a0f9-890d34c3147c"), Code="Level 5 is the level used in the district evaluation system for the teacher or principal performance rating.", Description="FAL5", Definition="", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("515f6bcc-c7cb-46aa-8915-0631052bf511"), Code="Level 6 (highest level) is the level used in the district evaluation system for the teacher or principal performance rating.", Description="FAL6", Definition="", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("c767011a-42ea-41bb-9a8f-8392a4939461"), Code="Evaluated, not ranked is the level used in the district evaluation system for the teacher or principal performance rating.", Description="EVALNR", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefStaffPerformanceLevel Pick List
         /// </summary>
        public static List<RefStaffPerformanceLevel> RefStaffPerformanceLevelPickList = new List<RefStaffPerformanceLevel> =
        {
            new RefStaffPerformanceLevel { Id=Guid.Parse("f045dafb-eb45-47be-867b-b415e70c86c5"), Code="Level 1 (lowest level) is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("16c44242-f73b-48cc-a19a-ae5c27118c17"), Code="Level 2 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("68ec76c6-d4d0-45dd-ad1a-974ea0cb9fc4"), Code="Level 3 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("d98fcd9a-e0f1-4349-b4d0-96eff2596386"), Code="Level 4 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("17025e17-a4ac-4696-a0f9-890d34c3147c"), Code="Level 5 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("515f6bcc-c7cb-46aa-8915-0631052bf511"), Code="Level 6 (highest level) is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=0 },
            new RefStaffPerformanceLevel { Id=Guid.Parse("c767011a-42ea-41bb-9a8f-8392a4939461"), Code="Evaluated, not ranked is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=0 },
       };
   }
}
