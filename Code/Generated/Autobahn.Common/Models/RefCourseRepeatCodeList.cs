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
        public static List<RefCourseRepeatCode> RefCourseRepeatCodeList = new List<RefCourseRepeatCode>
        {
            new RefCourseRepeatCode { Id=Guid.Parse("73bf1385-3407-445c-a5d9-64c9dd2b6d00"), Code="RepeatCounted", Description="Repeated, counted in grade point average", Definition="The student repeated the course and it has been counted in grade point average. ", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("b9c81dd1-99ab-49ca-80d5-449d7f8fd612"), Code="RepeatNotCounted", Description="Repeated, not counted in grade point average", Definition="The student repeated the course and it has not been counted in grade point average. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("cb995d93-833c-4c3f-abb0-2d379c040ff6"), Code="ReplacementCounted", Description="Replacement counted", Definition="Replacement course counted.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("c7a357a8-9eec-470e-adab-a3bc1811f65a"), Code="ReplacedNotCounted", Description="Replacement not counted", Definition="Replacement course not counted.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("3301bde3-2811-410c-b6d6-57ff8174ebb2"), Code="RepeatOtherInstitution", Description="Repeated, other institution", Definition="The student repeated the course and it has been counted by another institution.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("76b74bc1-aba4-446f-8498-1c8aa735d634"), Code="NotCountedOther", Description="Other, not counted in GPA (e.g., used for academic forgiveness or clemency).", Definition="Other, the course is not counted in GPA (e.g., used for academic forgiveness or clemency).", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefCourseRepeatCode Pick List
         /// </summary>
        public static List<RefCourseRepeatCode> RefCourseRepeatCodePickList = new List<RefCourseRepeatCode>
        {
            new RefCourseRepeatCode { Id=Guid.Parse("73bf1385-3407-445c-a5d9-64c9dd2b6d00"), Code="RepeatCounted", Description="Repeated, counted in grade point average", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("b9c81dd1-99ab-49ca-80d5-449d7f8fd612"), Code="RepeatNotCounted", Description="Repeated, not counted in grade point average", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("cb995d93-833c-4c3f-abb0-2d379c040ff6"), Code="ReplacementCounted", Description="Replacement counted", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("c7a357a8-9eec-470e-adab-a3bc1811f65a"), Code="ReplacedNotCounted", Description="Replacement not counted", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("3301bde3-2811-410c-b6d6-57ff8174ebb2"), Code="RepeatOtherInstitution", Description="Repeated, other institution", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("76b74bc1-aba4-446f-8498-1c8aa735d634"), Code="NotCountedOther", Description="Other, not counted in GPA (e.g., used for academic forgiveness or clemency).", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
