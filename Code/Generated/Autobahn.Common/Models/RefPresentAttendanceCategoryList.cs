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
        public static List<RefPresentAttendanceCategory> RefPresentAttendanceCategoryList = new List<RefPresentAttendanceCategory> =
        {
            new RefPresentAttendanceCategory { Id=Guid.Parse("1970ec36-db1c-4b77-8ba0-e684a43d642f"), Code="The student has been removed from the regular instructional setting for disciplinary reasons and is receiving instruction. In-school suspension typically falls within this category, but it also includes out-of-school suspension if instructional services are provided.", Description="13290", Definition="", SortOrder=0 },
            new RefPresentAttendanceCategory { Id=Guid.Parse("bf84ac81-2290-41d7-a668-c88b802c4778"), Code="The student is in class. This includes attendance at sites other than the school of record if the site is part of the student's regular instructional program approved by the school, district, and/or state. Examples of other sites are institutions of higher education, vocational/technical centers, and special education centers.", Description="13288", Definition="", SortOrder=0 },
            new RefPresentAttendanceCategory { Id=Guid.Parse("9671bd55-27eb-4faf-8a6b-494d7c4a97e1"), Code="The student is engaged in the regular instructional program in a nontraditional school setting. Examples include hospital- or homebound instruction, as well as off-campus distance education.", Description="13289", Definition="", SortOrder=0 },
            new RefPresentAttendanceCategory { Id=Guid.Parse("8c2a75f2-2484-4abf-92c4-c1de4deeb7aa"), Code="The student is involved in an activity outside of school that is part of the regular instructional program, such as a field trip or work-study. The student is under the direct supervision of school personnel or someone who has been designated to act in place of school personnel.", Description="13291", Definition="", SortOrder=0 },
            new RefPresentAttendanceCategory { Id=Guid.Parse("968e2f84-cc66-4a0f-8989-fb78e345eb3e"), Code="The student is outside of school, participating in instruction that is related to, but not part of, the regular curriculum. Examples include school-approved extracurricular or cocurricular activities, such as a debate, an athletic competition, or a conference that has educational value.", Description="13292", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPresentAttendanceCategory Pick List
         /// </summary>
        public static List<RefPresentAttendanceCategory> RefPresentAttendanceCategoryPickList = new List<RefPresentAttendanceCategory> =
        {
            new RefPresentAttendanceCategory { Id=Guid.Parse("1970ec36-db1c-4b77-8ba0-e684a43d642f"), Code="The student has been removed from the regular instructional setting for disciplinary reasons and is receiving instruction. In-school suspension typically falls within this category, but it also includes out-of-school suspension if instructional services are provided.", SortOrder=0 },
            new RefPresentAttendanceCategory { Id=Guid.Parse("bf84ac81-2290-41d7-a668-c88b802c4778"), Code="The student is in class. This includes attendance at sites other than the school of record if the site is part of the student's regular instructional program approved by the school, district, and/or state. Examples of other sites are institutions of higher education, vocational/technical centers, and special education centers.", SortOrder=0 },
            new RefPresentAttendanceCategory { Id=Guid.Parse("9671bd55-27eb-4faf-8a6b-494d7c4a97e1"), Code="The student is engaged in the regular instructional program in a nontraditional school setting. Examples include hospital- or homebound instruction, as well as off-campus distance education.", SortOrder=0 },
            new RefPresentAttendanceCategory { Id=Guid.Parse("8c2a75f2-2484-4abf-92c4-c1de4deeb7aa"), Code="The student is involved in an activity outside of school that is part of the regular instructional program, such as a field trip or work-study. The student is under the direct supervision of school personnel or someone who has been designated to act in place of school personnel.", SortOrder=0 },
            new RefPresentAttendanceCategory { Id=Guid.Parse("968e2f84-cc66-4a0f-8989-fb78e345eb3e"), Code="The student is outside of school, participating in instruction that is related to, but not part of, the regular curriculum. Examples include school-approved extracurricular or cocurricular activities, such as a debate, an athletic competition, or a conference that has educational value.", SortOrder=0 },
       };
   }
}
