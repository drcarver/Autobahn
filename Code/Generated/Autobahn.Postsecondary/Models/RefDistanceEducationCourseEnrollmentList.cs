//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDistanceEducationCourseEnrollmentList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefDistanceEducationCourseEnrollment Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDistanceEducationCourseEnrollment"> List
         /// </summary>
        public static List<RefDistanceEducationCourseEnrollment> RefDistanceEducationCourseEnrollmentList = new List<RefDistanceEducationCourseEnrollment>
        {
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("097075b0-c714-4584-810d-8f8cffe17c67"), Code="EnrolledExclusively", Description="Enrolled exclusively in distance education courses", Definition="The student is enrolled exclusively in distance education courses.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("dd549b02-c0bf-441e-b1fc-b28e0326d780"), Code="EnrolledInSome", Description="Enrolled in some but not all distance education courses", Definition="The student is enrolled in some but not all distance education courses.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("9ab5647d-a5e8-4c8a-abc7-74da5f60268e"), Code="NotEnrolled", Description="Not enrolled in distance education courses", Definition="The student is not enrolled in distance education courses.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefDistanceEducationCourseEnrollment Pick List
         /// </summary>
        public static List<RefDistanceEducationCourseEnrollment> RefDistanceEducationCourseEnrollmentPickList = new List<RefDistanceEducationCourseEnrollment>
        {
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("097075b0-c714-4584-810d-8f8cffe17c67"), Code="EnrolledExclusively", Description="Enrolled exclusively in distance education courses", SortOrder=Convert.ToDecimal("1.00") },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("dd549b02-c0bf-441e-b1fc-b28e0326d780"), Code="EnrolledInSome", Description="Enrolled in some but not all distance education courses", SortOrder=Convert.ToDecimal("2.00") },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("9ab5647d-a5e8-4c8a-abc7-74da5f60268e"), Code="NotEnrolled", Description="Not enrolled in distance education courses", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
