//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAbsentAttendanceCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAbsentAttendanceCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAbsentAttendanceCategory"> List
         /// </summary>
        public static List<RefAbsentAttendanceCategory> RefAbsentAttendanceCategoryList = new List<RefAbsentAttendanceCategory>
        {
            new RefAbsentAttendanceCategory { Id=Guid.Parse("2af167ee-10d8-434e-ac60-08bec7186dc9"), Code="13297", Description="Absent - Disciplinary action, not receiving instruction", Definition="The student has been removed from the regular instructional setting for disciplinary reasons and is not receiving instruction. This may include either in-school or out-of-school suspension if instructional services are not provided. It does not include expulsion since expelled students are not enrolled in school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e7b663ec-b72f-4b3c-86da-42bf7343d21b"), Code="13299", Description="Absent - Family activity", Definition="The student is out of school because of a family vacation or other activity. This also includes family time related to a parent being deployed to, or returning from, military duty.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("2d6f98bd-d8ff-431f-96e2-70a73ebad969"), Code="13296", Description="Absent - Family emergency or bereavement", Definition="The student is out of school for unexpected family reasons. Examples include lack of child care for a student with child(ren), care for a sick relative, and bereavement for a family member.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("7fdaaf42-b3f5-4ddd-8fd8-7c171c1cc0f6"), Code="13295", Description="Absent - Illness, injury, health treatment, or examination", Definition="The student is out of school because of personal physical or mental illness or injury, including health-related appointments. This may include more unusual situations, such as quarantine.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("4c4d7ba8-f900-48bc-984f-73b069491205"), Code="13298", Description="Absent - Legal or judicial requirement", Definition="The student is out of school due to a legal obligation to attend judicial proceedings, required appointments, or trial or hearing dates. Or, the student is serving time in jail or is in the custody of the court and is not receiving instruction.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("524c0edd-559a-42ac-82a8-4ebd72abd73b"), Code="13293", Description="Absent - Noninstructional activity recognized by state, district, or school", Definition="The student is out of school and involved in a noninstructional activity recognized by the school, district, and/or state. Examples include such civic activities as involvement with the National Guard, service as a legislative page, jury duty, or participation on an election board. Note that \u0022recognized activities\u0022 are not necessarily considered \u0022excused\u0022 absences.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("0a6a5325-8bb1-4b61-9e9b-7a254784e045"), Code="13294", Description="Absent - Religious observation", Definition="The student is out of school observing a religious holiday or participating in religious instruction.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("62f56879-a40c-495c-ae56-a050cc23ffc4"), Code="13303", Description="Absent - Situation unknown", Definition="The student is not present and the reason for the absence is not known. \u0022Situation unknown\u0022 is a default category to be used only until the correct attendance category is determined.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("b3f84023-805a-4372-beb5-33f519ac9a41"), Code="13300", Description="Absent - Student employment", Definition="The student is out of school for employment purposes. This does not include work-study or school-related employment.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("cbed3015-7e77-417d-b086-60667d990972"), Code="13302", Description="Absent - Student is skipping school", Definition="The student is willfully not attending school without parent or school approval.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("b5ab625b-788e-439a-ad10-10ba5fe709b9"), Code="13301", Description="Absent - Transportation not available", Definition="The student is not in school because transportation is not available. For example, roads have been closed due to flooding. This category includes school-provided transportation and the student's personal transportation.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The RefAbsentAttendanceCategory Pick List
         /// </summary>
        public static List<RefAbsentAttendanceCategory> RefAbsentAttendanceCategoryPickList = new List<RefAbsentAttendanceCategory>
        {
            new RefAbsentAttendanceCategory { Id=Guid.Parse("2af167ee-10d8-434e-ac60-08bec7186dc9"), Code="13297", Description="Absent - Disciplinary action, not receiving instruction", SortOrder=Convert.ToDecimal("1.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e7b663ec-b72f-4b3c-86da-42bf7343d21b"), Code="13299", Description="Absent - Family activity", SortOrder=Convert.ToDecimal("2.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("2d6f98bd-d8ff-431f-96e2-70a73ebad969"), Code="13296", Description="Absent - Family emergency or bereavement", SortOrder=Convert.ToDecimal("3.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("7fdaaf42-b3f5-4ddd-8fd8-7c171c1cc0f6"), Code="13295", Description="Absent - Illness, injury, health treatment, or examination", SortOrder=Convert.ToDecimal("4.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("4c4d7ba8-f900-48bc-984f-73b069491205"), Code="13298", Description="Absent - Legal or judicial requirement", SortOrder=Convert.ToDecimal("5.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("524c0edd-559a-42ac-82a8-4ebd72abd73b"), Code="13293", Description="Absent - Noninstructional activity recognized by state, district, or school", SortOrder=Convert.ToDecimal("6.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("0a6a5325-8bb1-4b61-9e9b-7a254784e045"), Code="13294", Description="Absent - Religious observation", SortOrder=Convert.ToDecimal("7.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("62f56879-a40c-495c-ae56-a050cc23ffc4"), Code="13303", Description="Absent - Situation unknown", SortOrder=Convert.ToDecimal("8.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("b3f84023-805a-4372-beb5-33f519ac9a41"), Code="13300", Description="Absent - Student employment", SortOrder=Convert.ToDecimal("9.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("cbed3015-7e77-417d-b086-60667d990972"), Code="13302", Description="Absent - Student is skipping school", SortOrder=Convert.ToDecimal("10.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("b5ab625b-788e-439a-ad10-10ba5fe709b9"), Code="13301", Description="Absent - Transportation not available", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
