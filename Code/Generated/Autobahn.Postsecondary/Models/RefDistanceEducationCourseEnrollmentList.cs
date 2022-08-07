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
        /// The complete <see cref="RefDistanceEducationCourseEnrollmentModel"> List
         /// </summary>
        public static List<RefDistanceEducationCourseEnrollmentModel> RefDistanceEducationCourseEnrollmentList = new List<RefDistanceEducationCourseEnrollmentModel>
        {
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("f51253eb-8c05-49af-bf8e-c6217c3c0108"), Code="EnrolledExclusively", Description="Enrolled exclusively in distance education courses", Definition="The student is enrolled exclusively in distance education courses.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("15c8f022-342f-43ec-8027-c1147fa78277"), Code="EnrolledInSome", Description="Enrolled in some but not all distance education courses", Definition="The student is enrolled in some but not all distance education courses.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("2d2f3ca3-d947-49a8-8d34-56930b71f774"), Code="NotEnrolled", Description="Not enrolled in distance education courses", Definition="The student is not enrolled in distance education courses.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefDistanceEducationCourseEnrollment Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDistanceEducationCourseEnrollmentViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("f51253eb-8c05-49af-bf8e-c6217c3c0108"), Description="Enrolled exclusively in distance education courses", SortOrder=Convert.ToDecimal("1.00") },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("15c8f022-342f-43ec-8027-c1147fa78277"), Description="Enrolled in some but not all distance education courses", SortOrder=Convert.ToDecimal("2.00") },
            new RefDistanceEducationCourseEnrollment { Id=Guid.Parse("2d2f3ca3-d947-49a8-8d34-56930b71f774"), Description="Not enrolled in distance education courses", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
