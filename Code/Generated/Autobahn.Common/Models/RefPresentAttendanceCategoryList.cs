//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPresentAttendanceCategoryList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPresentAttendanceCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPresentAttendanceCategoryModel"> List
         /// </summary>
        public static List<RefPresentAttendanceCategoryModel> RefPresentAttendanceCategoryList = new List<RefPresentAttendanceCategoryModel>
        {
            new RefPresentAttendanceCategory { Id=Guid.Parse("f7bdb703-ad89-4974-ada1-44cc83a642f0"), Code="13290", Description="Present - Disciplinary action, receiving instruction", Definition="The student has been removed from the regular instructional setting for disciplinary reasons and is receiving instruction. In-school suspension typically falls within this category, but it also includes out-of-school suspension if instructional services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("76a18cd7-26b4-4626-8ab3-8bd24177eb66"), Code="13288", Description="Present - In school, regular instructional program", Definition="The student is in class. This includes attendance at sites other than the school of record if the site is part of the student's regular instructional program approved by the school, district, and/or state. Examples of other sites are institutions of higher education, vocational/technical centers, and special education centers.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("965e4725-ad59-4232-9e6a-72b4d19f5212"), Code="13289", Description="Present - Nontraditional school setting, regular instructional program", Definition="The student is engaged in the regular instructional program in a nontraditional school setting. Examples include hospital- or homebound instruction, as well as off-campus distance education.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("afb2af7e-4a35-4303-ac62-871c956e42f0"), Code="13291", Description="Present - Out of school, regular instructional program activity", Definition="The student is involved in an activity outside of school that is part of the regular instructional program, such as a field trip or work-study. The student is under the direct supervision of school personnel or someone who has been designated to act in place of school personnel.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("e7af6c3b-0be1-438b-b9a4-40dab1bac6a0"), Code="13292", Description="Present - Out of school, school-approved extracurricular or cocurricular activity", Definition="The student is outside of school, participating in instruction that is related to, but not part of, the regular curriculum. Examples include school-approved extracurricular or cocurricular activities, such as a debate, an athletic competition, or a conference that has educational value.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefPresentAttendanceCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPresentAttendanceCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPresentAttendanceCategory { Id=Guid.Parse("f7bdb703-ad89-4974-ada1-44cc83a642f0"), Description="Present - Disciplinary action, receiving instruction", SortOrder=Convert.ToDecimal("1.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("76a18cd7-26b4-4626-8ab3-8bd24177eb66"), Description="Present - In school, regular instructional program", SortOrder=Convert.ToDecimal("2.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("965e4725-ad59-4232-9e6a-72b4d19f5212"), Description="Present - Nontraditional school setting, regular instructional program", SortOrder=Convert.ToDecimal("3.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("afb2af7e-4a35-4303-ac62-871c956e42f0"), Description="Present - Out of school, regular instructional program activity", SortOrder=Convert.ToDecimal("4.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("e7af6c3b-0be1-438b-b9a4-40dab1bac6a0"), Description="Present - Out of school, school-approved extracurricular or cocurricular activity", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
