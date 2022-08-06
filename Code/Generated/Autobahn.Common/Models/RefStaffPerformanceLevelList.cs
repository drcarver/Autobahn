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
        public static List<RefStaffPerformanceLevel> RefStaffPerformanceLevelList = new List<RefStaffPerformanceLevel>
        {
            new RefStaffPerformanceLevel { Id=Guid.Parse("bf40d48c-07dc-4c8f-882d-3afc255bb3e3"), Code="FAL1", Description="Level 1 (lowest level)", Definition="Level 1 (lowest level) is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("9ef570d9-ae9c-4fac-a15f-93f184d7c439"), Code="FAL2", Description="Level 2", Definition="Level 2 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("7bca9111-a4ae-4889-89a0-44678f4da455"), Code="FAL3", Description="Level 3", Definition="Level 3 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("3.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("14ce16a8-5192-4196-b5bc-8291c83f813c"), Code="FAL4", Description="Level 4", Definition="Level 4 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("4.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("8ce5bacf-42d7-4639-9159-e7fa2f509f6d"), Code="FAL5", Description="Level 5", Definition="Level 5 is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("5.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("8af10bfd-9f46-4a69-9fd2-9a15ea5e896f"), Code="FAL6", Description="Level 6 (highest level)", Definition="Level 6 (highest level) is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("6.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("7f5dc499-e2f3-4acb-8d73-2b4d0357ac7c"), Code="EVALNR", Description="Evaluated, not ranked", Definition="Evaluated, not ranked is the level used in the district evaluation system for the teacher or principal performance rating.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefStaffPerformanceLevel Pick List
         /// </summary>
        public static List<RefStaffPerformanceLevel> RefStaffPerformanceLevelPickList = new List<RefStaffPerformanceLevel>
        {
            new RefStaffPerformanceLevel { Id=Guid.Parse("bf40d48c-07dc-4c8f-882d-3afc255bb3e3"), Code="FAL1", Description="Level 1 (lowest level)", SortOrder=Convert.ToDecimal("1.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("9ef570d9-ae9c-4fac-a15f-93f184d7c439"), Code="FAL2", Description="Level 2", SortOrder=Convert.ToDecimal("2.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("7bca9111-a4ae-4889-89a0-44678f4da455"), Code="FAL3", Description="Level 3", SortOrder=Convert.ToDecimal("3.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("14ce16a8-5192-4196-b5bc-8291c83f813c"), Code="FAL4", Description="Level 4", SortOrder=Convert.ToDecimal("4.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("8ce5bacf-42d7-4639-9159-e7fa2f509f6d"), Code="FAL5", Description="Level 5", SortOrder=Convert.ToDecimal("5.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("8af10bfd-9f46-4a69-9fd2-9a15ea5e896f"), Code="FAL6", Description="Level 6 (highest level)", SortOrder=Convert.ToDecimal("6.00") },
            new RefStaffPerformanceLevel { Id=Guid.Parse("7f5dc499-e2f3-4acb-8d73-2b4d0357ac7c"), Code="EVALNR", Description="Evaluated, not ranked", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
