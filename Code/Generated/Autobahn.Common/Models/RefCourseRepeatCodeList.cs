//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseRepeatCodeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseRepeatCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseRepeatCode"> List
         /// </summary>
        public static List<RefCourseRepeatCode> RefCourseRepeatCodeList = new List<RefCourseRepeatCode> =
        {
            new RefCourseRepeatCode { Id=Guid.Parse("fffc7c7f-8089-4d41-a25d-87dce1422665"), Code="The student repeated the course and it has been counted in grade point average. ", Description="RepeatCounted", Definition="", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("3e1da173-c6a0-4d8c-8aa8-4081a0b673c4"), Code="The student repeated the course and it has not been counted in grade point average. ", Description="RepeatNotCounted", Definition="", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("33afefda-1725-4753-87ad-31b3cf381c13"), Code="Replacement course counted.", Description="ReplacementCounted", Definition="", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("0d5276eb-70f3-4c6f-b226-8051b2cd423b"), Code="Replacement course not counted.", Description="ReplacedNotCounted", Definition="", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("506a123c-daa4-4d02-953b-b7ab39392946"), Code="The student repeated the course and it has been counted by another institution.", Description="RepeatOtherInstitution", Definition="", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("2fcd68e2-e533-4789-8f75-ff0ab77bd212"), Code="Other, the course is not counted in GPA (e.g., used for academic forgiveness or clemency).", Description="NotCountedOther", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseRepeatCode Pick List
         /// </summary>
        public static List<RefCourseRepeatCode> RefCourseRepeatCodePickList = new List<RefCourseRepeatCode> =
        {
            new RefCourseRepeatCode { Id=Guid.Parse("fffc7c7f-8089-4d41-a25d-87dce1422665"), Code="The student repeated the course and it has been counted in grade point average. ", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("3e1da173-c6a0-4d8c-8aa8-4081a0b673c4"), Code="The student repeated the course and it has not been counted in grade point average. ", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("33afefda-1725-4753-87ad-31b3cf381c13"), Code="Replacement course counted.", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("0d5276eb-70f3-4c6f-b226-8051b2cd423b"), Code="Replacement course not counted.", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("506a123c-daa4-4d02-953b-b7ab39392946"), Code="The student repeated the course and it has been counted by another institution.", SortOrder=0 },
            new RefCourseRepeatCode { Id=Guid.Parse("2fcd68e2-e533-4789-8f75-ff0ab77bd212"), Code="Other, the course is not counted in GPA (e.g., used for academic forgiveness or clemency).", SortOrder=0 },
       };
   }
}
