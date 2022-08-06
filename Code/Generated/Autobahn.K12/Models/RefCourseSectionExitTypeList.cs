//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCourseSectionExitTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefCourseSectionExitType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseSectionExitType"> List
         /// </summary>
        public static List<RefCourseSectionExitType> RefCourseSectionExitTypeList = new List<RefCourseSectionExitType> =
        {
            new RefCourseSectionExitType { Id=Guid.Parse("eeaf4d36-b957-4983-92ba-d8dec0ff6fed"), Code="The student exited the course section and transferred to another course section of the same course in the same educational institution.", Description="Transfer", Definition="", SortOrder=0 },
            new RefCourseSectionExitType { Id=Guid.Parse("67b92ecc-e5e1-4215-a7a4-b1532f10c18a"), Code="The course section completed and the student received credit for the course.", Description="CompletedForCredit", Definition="", SortOrder=0 },
            new RefCourseSectionExitType { Id=Guid.Parse("51310816-503b-4921-8d53-9da5c323b8b6"), Code="The course section completed and the student did not receive credit for the course.", Description="CompletedNoCredit", Definition="", SortOrder=0 },
            new RefCourseSectionExitType { Id=Guid.Parse("855c0638-817e-43ec-89d3-cd24b112ee08"), Code="The course section ended and the student did not complete the work required to complete the course.", Description="Incomplete", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseSectionExitType Pick List
         /// </summary>
        public static List<RefCourseSectionExitType> RefCourseSectionExitTypePickList = new List<RefCourseSectionExitType> =
        {
            new RefCourseSectionExitType { Id=Guid.Parse("eeaf4d36-b957-4983-92ba-d8dec0ff6fed"), Code="The student exited the course section and transferred to another course section of the same course in the same educational institution.", SortOrder=0 },
            new RefCourseSectionExitType { Id=Guid.Parse("67b92ecc-e5e1-4215-a7a4-b1532f10c18a"), Code="The course section completed and the student received credit for the course.", SortOrder=0 },
            new RefCourseSectionExitType { Id=Guid.Parse("51310816-503b-4921-8d53-9da5c323b8b6"), Code="The course section completed and the student did not receive credit for the course.", SortOrder=0 },
            new RefCourseSectionExitType { Id=Guid.Parse("855c0638-817e-43ec-89d3-cd24b112ee08"), Code="The course section ended and the student did not complete the work required to complete the course.", SortOrder=0 },
       };
   }
}
