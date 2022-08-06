//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPresentAttendanceCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPresentAttendanceCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPresentAttendanceCategory"> List
         /// </summary>
        public static List<RefPresentAttendanceCategory> RefPresentAttendanceCategoryList = new List<RefPresentAttendanceCategory>
        {
            new RefPresentAttendanceCategory { Id=Guid.Parse("1b7ee76f-926e-4c91-bc9b-135be3cebbf2"), Code="13290", Description="Present - Disciplinary action, receiving instruction", Definition="The student has been removed from the regular instructional setting for disciplinary reasons and is receiving instruction. In-school suspension typically falls within this category, but it also includes out-of-school suspension if instructional services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("9de49a9b-4420-448c-a1e2-9978aa0a5ffc"), Code="13288", Description="Present - In school, regular instructional program", Definition="The student is in class. This includes attendance at sites other than the school of record if the site is part of the student's regular instructional program approved by the school, district, and/or state. Examples of other sites are institutions of higher education, vocational/technical centers, and special education centers.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("a4b5af16-ec08-4989-9f26-ea156d730a17"), Code="13289", Description="Present - Nontraditional school setting, regular instructional program", Definition="The student is engaged in the regular instructional program in a nontraditional school setting. Examples include hospital- or homebound instruction, as well as off-campus distance education.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("e2c3b793-758c-44e8-8a6e-0aa256b1b28e"), Code="13291", Description="Present - Out of school, regular instructional program activity", Definition="The student is involved in an activity outside of school that is part of the regular instructional program, such as a field trip or work-study. The student is under the direct supervision of school personnel or someone who has been designated to act in place of school personnel.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("dacdcf63-e64d-437f-8f48-1700fbb1a4f1"), Code="13292", Description="Present - Out of school, school-approved extracurricular or cocurricular activity", Definition="The student is outside of school, participating in instruction that is related to, but not part of, the regular curriculum. Examples include school-approved extracurricular or cocurricular activities, such as a debate, an athletic competition, or a conference that has educational value.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefPresentAttendanceCategory Pick List
         /// </summary>
        public static List<RefPresentAttendanceCategory> RefPresentAttendanceCategoryPickList = new List<RefPresentAttendanceCategory>
        {
            new RefPresentAttendanceCategory { Id=Guid.Parse("1b7ee76f-926e-4c91-bc9b-135be3cebbf2"), Code="13290", Description="Present - Disciplinary action, receiving instruction", SortOrder=Convert.ToDecimal("1.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("9de49a9b-4420-448c-a1e2-9978aa0a5ffc"), Code="13288", Description="Present - In school, regular instructional program", SortOrder=Convert.ToDecimal("2.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("a4b5af16-ec08-4989-9f26-ea156d730a17"), Code="13289", Description="Present - Nontraditional school setting, regular instructional program", SortOrder=Convert.ToDecimal("3.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("e2c3b793-758c-44e8-8a6e-0aa256b1b28e"), Code="13291", Description="Present - Out of school, regular instructional program activity", SortOrder=Convert.ToDecimal("4.00") },
            new RefPresentAttendanceCategory { Id=Guid.Parse("dacdcf63-e64d-437f-8f48-1700fbb1a4f1"), Code="13292", Description="Present - Out of school, school-approved extracurricular or cocurricular activity", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
