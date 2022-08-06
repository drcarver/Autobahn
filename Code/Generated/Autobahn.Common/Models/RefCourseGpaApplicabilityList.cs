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
        public static List<RefCourseGpaApplicability> RefCourseGpaApplicabilityList = new List<RefCourseGpaApplicability> =
        {
            new RefCourseGpaApplicability { Id=Guid.Parse("4b4fc266-68ca-4b8d-b868-cc877da80bfe"), Code="The course being described is included in the computation of the student's Grade Point Average (GPA).", Description="Applicable", Definition="", SortOrder=0 },
            new RefCourseGpaApplicability { Id=Guid.Parse("c9be79c7-3b81-4201-9fc3-21bba33b99e6"), Code="The course being described is not included in the computation of the student's Grade Point Average (GPA).", Description="NotApplicable", Definition="", SortOrder=0 },
            new RefCourseGpaApplicability { Id=Guid.Parse("bc718123-486c-4acc-a1c7-f80e08da22d5"), Code="The course being described is weighted in the computation of the student's Grade Point Average (GPA)", Description="Weighted", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseGpaApplicability Pick List
         /// </summary>
        public static List<RefCourseGpaApplicability> RefCourseGpaApplicabilityPickList = new List<RefCourseGpaApplicability> =
        {
            new RefCourseGpaApplicability { Id=Guid.Parse("4b4fc266-68ca-4b8d-b868-cc877da80bfe"), Code="The course being described is included in the computation of the student's Grade Point Average (GPA).", SortOrder=0 },
            new RefCourseGpaApplicability { Id=Guid.Parse("c9be79c7-3b81-4201-9fc3-21bba33b99e6"), Code="The course being described is not included in the computation of the student's Grade Point Average (GPA).", SortOrder=0 },
            new RefCourseGpaApplicability { Id=Guid.Parse("bc718123-486c-4acc-a1c7-f80e08da22d5"), Code="The course being described is weighted in the computation of the student's Grade Point Average (GPA)", SortOrder=0 },
       };
   }
}
