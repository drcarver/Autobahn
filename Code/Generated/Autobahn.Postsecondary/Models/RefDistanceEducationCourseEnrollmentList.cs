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
        public static List<RefDistanceEducationCourseEnrollment> RefDistanceEducationCourseEnrollmentList = new List<RefDistanceEducationCourseEnrollment> =
        {
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("12c43399-7c8e-4487-b10f-bd91ca76a8f2"), Code="The student is enrolled exclusively in distance education courses.", Description="EnrolledExclusively", Definition="", SortOrder=0 },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("72c1d2bf-7332-4220-962f-0c277faeaf28"), Code="The student is enrolled in some but not all distance education courses.", Description="EnrolledInSome", Definition="", SortOrder=0 },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("1395ad75-3b24-4ef4-a837-34caccc6af95"), Code="The student is not enrolled in distance education courses.", Description="NotEnrolled", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefDistanceEducationCourseEnrollment Pick List
         /// </summary>
        public static List<RefDistanceEducationCourseEnrollment> RefDistanceEducationCourseEnrollmentPickList = new List<RefDistanceEducationCourseEnrollment> =
        {
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("12c43399-7c8e-4487-b10f-bd91ca76a8f2"), Code="The student is enrolled exclusively in distance education courses.", SortOrder=0 },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("72c1d2bf-7332-4220-962f-0c277faeaf28"), Code="The student is enrolled in some but not all distance education courses.", SortOrder=0 },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("1395ad75-3b24-4ef4-a837-34caccc6af95"), Code="The student is not enrolled in distance education courses.", SortOrder=0 },
       };
   }
}
