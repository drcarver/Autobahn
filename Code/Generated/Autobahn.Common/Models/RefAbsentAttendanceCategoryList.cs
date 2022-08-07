//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAbsentAttendanceCategoryList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAbsentAttendanceCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAbsentAttendanceCategoryModel"> List
         /// </summary>
        public static List<RefAbsentAttendanceCategoryModel> RefAbsentAttendanceCategoryList = new List<RefAbsentAttendanceCategoryModel>
        {
            new RefAbsentAttendanceCategoryModel { Id=Guid.Parse("d03f9334-cdf1-4359-9f83-6c2284154678"), Code="13297", Description="Absent - Disciplinary action, not receiving instruction", Definition="The student has been removed from the regular instructional setting for disciplinary reasons and is not receiving instruction. This may include either in-school or out-of-school suspension if instructional services are not provided. It does not include expulsion since expelled students are not enrolled in school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("1bf871c9-4cef-49f6-9e3c-a0c79070043c"), Code="13299", Description="Absent - Family activity", Definition="The student is out of school because of a family vacation or other activity. This also includes family time related to a parent being deployed to, or returning from, military duty.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("11552dbb-39c7-48e9-a48d-e0f8a728ac1a"), Code="13296", Description="Absent - Family emergency or bereavement", Definition="The student is out of school for unexpected family reasons. Examples include lack of child care for a student with child(ren), care for a sick relative, and bereavement for a family member.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("50175096-1d03-426b-b433-40b137d42fcc"), Code="13295", Description="Absent - Illness, injury, health treatment, or examination", Definition="The student is out of school because of personal physical or mental illness or injury, including health-related appointments. This may include more unusual situations, such as quarantine.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("364fb010-cda2-4b5f-8c58-a1cacf7c6b65"), Code="13298", Description="Absent - Legal or judicial requirement", Definition="The student is out of school due to a legal obligation to attend judicial proceedings, required appointments, or trial or hearing dates. Or, the student is serving time in jail or is in the custody of the court and is not receiving instruction.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e47450fc-4179-4a08-bda5-91bc990270fe"), Code="13293", Description="Absent - Noninstructional activity recognized by state, district, or school", Definition="The student is out of school and involved in a noninstructional activity recognized by the school, district, and/or state. Examples include such civic activities as involvement with the National Guard, service as a legislative page, jury duty, or participation on an election board. Note that \u0022recognized activities\u0022 are not necessarily considered \u0022excused\u0022 absences.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("259c62c9-a503-4926-8966-8e16de87a841"), Code="13294", Description="Absent - Religious observation", Definition="The student is out of school observing a religious holiday or participating in religious instruction.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("33170fe3-6c29-4d85-9b41-38624e6ed344"), Code="13303", Description="Absent - Situation unknown", Definition="The student is not present and the reason for the absence is not known. \u0022Situation unknown\u0022 is a default category to be used only until the correct attendance category is determined.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("bbba34a6-d038-4e2f-87a5-160c3db73e0d"), Code="13300", Description="Absent - Student employment", Definition="The student is out of school for employment purposes. This does not include work-study or school-related employment.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e0d59b0c-877e-483e-b961-14b9a220e342"), Code="13302", Description="Absent - Student is skipping school", Definition="The student is willfully not attending school without parent or school approval.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("816b284f-a5dc-4fb3-b845-d604e7b5aadd"), Code="13301", Description="Absent - Transportation not available", Definition="The student is not in school because transportation is not available. For example, roads have been closed due to flooding. This category includes school-provided transportation and the student's personal transportation.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefAbsentAttendanceCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAbsentAttendanceCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new ReferencePickListItemViewModel { Id=Guid.Parse("d03f9334-cdf1-4359-9f83-6c2284154678"), Description="Absent - Disciplinary action, not receiving instruction", SortOrder=Convert.ToDecimal("1.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("1bf871c9-4cef-49f6-9e3c-a0c79070043c"), Description="Absent - Family activity", SortOrder=Convert.ToDecimal("2.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("11552dbb-39c7-48e9-a48d-e0f8a728ac1a"), Description="Absent - Family emergency or bereavement", SortOrder=Convert.ToDecimal("3.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("50175096-1d03-426b-b433-40b137d42fcc"), Description="Absent - Illness, injury, health treatment, or examination", SortOrder=Convert.ToDecimal("4.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("364fb010-cda2-4b5f-8c58-a1cacf7c6b65"), Description="Absent - Legal or judicial requirement", SortOrder=Convert.ToDecimal("5.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e47450fc-4179-4a08-bda5-91bc990270fe"), Description="Absent - Noninstructional activity recognized by state, district, or school", SortOrder=Convert.ToDecimal("6.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("259c62c9-a503-4926-8966-8e16de87a841"), Description="Absent - Religious observation", SortOrder=Convert.ToDecimal("7.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("33170fe3-6c29-4d85-9b41-38624e6ed344"), Description="Absent - Situation unknown", SortOrder=Convert.ToDecimal("8.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("bbba34a6-d038-4e2f-87a5-160c3db73e0d"), Description="Absent - Student employment", SortOrder=Convert.ToDecimal("9.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("e0d59b0c-877e-483e-b961-14b9a220e342"), Description="Absent - Student is skipping school", SortOrder=Convert.ToDecimal("10.00") },
            new RefAbsentAttendanceCategory { Id=Guid.Parse("816b284f-a5dc-4fb3-b845-d604e7b5aadd"), Description="Absent - Transportation not available", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
