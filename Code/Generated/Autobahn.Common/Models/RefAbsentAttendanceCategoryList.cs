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
            new RefAbsentAttendanceCategory { Id=Guid.Parse("63b409be-e260-42cb-aa21-d6ae896d4e2d"), Code="The student has been removed from the regular instructional setting for disciplinary reasons and is not receiving instruction. This may include either in-school or out-of-school suspension if instructional services are not provided. It does not include expulsion since expelled students are not enrolled in school.", Description="13297", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e56487e1-706c-440d-93f2-8ed5e927db60"), Code="The student is out of school because of a family vacation or other activity. This also includes family time related to a parent being deployed to, or returning from, military duty.", Description="13299", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("25603c00-8c41-4dd0-92c9-564ed41c495a"), Code="The student is out of school for unexpected family reasons. Examples include lack of child care for a student with child(ren), care for a sick relative, and bereavement for a family member.", Description="13296", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("6e770957-c893-4090-8f30-5d46b3f6ac02"), Code="The student is out of school because of personal physical or mental illness or injury, including health-related appointments. This may include more unusual situations, such as quarantine.", Description="13295", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("a6cb1cce-01b8-43d1-bae4-fe1cfd3f6ecd"), Code="The student is out of school due to a legal obligation to attend judicial proceedings, required appointments, or trial or hearing dates. Or, the student is serving time in jail or is in the custody of the court and is not receiving instruction.", Description="13298", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("a113090d-5a55-41b6-9420-db2e827c8e6d"), Code="The student is out of school and involved in a noninstructional activity recognized by the school, district, and/or state. Examples include such civic activities as involvement with the National Guard, service as a legislative page, jury duty, or participation on an election board. Note that "recognized activities" are not necessarily considered "excused" absences.", Description="13293", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("a803d015-0809-41c2-a9e6-7227f48fe712"), Code="The student is out of school observing a religious holiday or participating in religious instruction.", Description="13294", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("5f26da13-6685-4c66-9fbd-1b542639ee30"), Code="The student is not present and the reason for the absence is not known. "Situation unknown" is a default category to be used only until the correct attendance category is determined.", Description="13303", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e6d849c2-4923-4b76-addf-84d790d621aa"), Code="The student is out of school for employment purposes. This does not include work-study or school-related employment.", Description="13300", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("dae26271-ea87-4b25-bc88-4ed69f959b0c"), Code="The student is willfully not attending school without parent or school approval.", Description="13302", Definition="", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("0ef7d78a-c0d5-4e0f-aa95-e9c778d1e94a"), Code="The student is not in school because transportation is not available. For example, roads have been closed due to flooding. This category includes school-provided transportation and the student's personal transportation.", Description="13301", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAbsentAttendanceCategory Pick List
         /// </summary>
        public static List<RefAbsentAttendanceCategory> RefAbsentAttendanceCategoryPickList = new List<RefAbsentAttendanceCategory>
        {
            new RefAbsentAttendanceCategory { Id=Guid.Parse("63b409be-e260-42cb-aa21-d6ae896d4e2d"), Code="The student has been removed from the regular instructional setting for disciplinary reasons and is not receiving instruction. This may include either in-school or out-of-school suspension if instructional services are not provided. It does not include expulsion since expelled students are not enrolled in school.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e56487e1-706c-440d-93f2-8ed5e927db60"), Code="The student is out of school because of a family vacation or other activity. This also includes family time related to a parent being deployed to, or returning from, military duty.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("25603c00-8c41-4dd0-92c9-564ed41c495a"), Code="The student is out of school for unexpected family reasons. Examples include lack of child care for a student with child(ren), care for a sick relative, and bereavement for a family member.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("6e770957-c893-4090-8f30-5d46b3f6ac02"), Code="The student is out of school because of personal physical or mental illness or injury, including health-related appointments. This may include more unusual situations, such as quarantine.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("a6cb1cce-01b8-43d1-bae4-fe1cfd3f6ecd"), Code="The student is out of school due to a legal obligation to attend judicial proceedings, required appointments, or trial or hearing dates. Or, the student is serving time in jail or is in the custody of the court and is not receiving instruction.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("a113090d-5a55-41b6-9420-db2e827c8e6d"), Code="The student is out of school and involved in a noninstructional activity recognized by the school, district, and/or state. Examples include such civic activities as involvement with the National Guard, service as a legislative page, jury duty, or participation on an election board. Note that "recognized activities" are not necessarily considered "excused" absences.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("a803d015-0809-41c2-a9e6-7227f48fe712"), Code="The student is out of school observing a religious holiday or participating in religious instruction.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("5f26da13-6685-4c66-9fbd-1b542639ee30"), Code="The student is not present and the reason for the absence is not known. "Situation unknown" is a default category to be used only until the correct attendance category is determined.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e6d849c2-4923-4b76-addf-84d790d621aa"), Code="The student is out of school for employment purposes. This does not include work-study or school-related employment.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("dae26271-ea87-4b25-bc88-4ed69f959b0c"), Code="The student is willfully not attending school without parent or school approval.", SortOrder=0 },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("0ef7d78a-c0d5-4e0f-aa95-e9c778d1e94a"), Code="The student is not in school because transportation is not available. For example, roads have been closed due to flooding. This category includes school-provided transportation and the student's personal transportation.", SortOrder=0 },
       };
   }
}
