//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseGpaApplicabilityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseGpaApplicability Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseGpaApplicability"> List
         /// </summary>
        public static List<RefCourseGpaApplicability> RefCourseGpaApplicabilityList = new List<RefCourseGpaApplicability>
        {
            new RefCourseGpaApplicability { Id=Guid.Parse("1569075d-d651-48f7-abc7-d4e9d1740210"), Code="Applicable", Description="Applicable in GPA", Definition="The course being described is included in the computation of the student's Grade Point Average (GPA).", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseGpaApplicability { Id=Guid.Parse("b0c8e41d-ea96-4ce1-a096-a43e0195b590"), Code="NotApplicable", Description="Not Applicable in GPA", Definition="The course being described is not included in the computation of the student's Grade Point Average (GPA).", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseGpaApplicability { Id=Guid.Parse("2e3596a8-10bd-4035-9cf2-ad82b4559438"), Code="Weighted", Description="Weighted in GPA", Definition="The course being described is weighted in the computation of the student's Grade Point Average (GPA)", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefCourseGpaApplicability Pick List
         /// </summary>
        public static List<RefCourseGpaApplicability> RefCourseGpaApplicabilityPickList = new List<RefCourseGpaApplicability>
        {
            new RefCourseGpaApplicability { Id=Guid.Parse("1569075d-d651-48f7-abc7-d4e9d1740210"), Code="Applicable", Description="Applicable in GPA", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseGpaApplicability { Id=Guid.Parse("b0c8e41d-ea96-4ce1-a096-a43e0195b590"), Code="NotApplicable", Description="Not Applicable in GPA", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseGpaApplicability { Id=Guid.Parse("2e3596a8-10bd-4035-9cf2-ad82b4559438"), Code="Weighted", Description="Weighted in GPA", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
