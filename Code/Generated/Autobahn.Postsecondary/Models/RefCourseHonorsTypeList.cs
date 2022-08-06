//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCourseHonorsTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCourseHonorsType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseHonorsType"> List
         /// </summary>
        public static List<RefCourseHonorsType> RefCourseHonorsTypeList = new List<RefCourseHonorsType> =
        {
            new RefCourseHonorsType { Id=Guid.Parse("9de43f7d-bcc3-40e8-b654-bd833395675a"), Code="The course is counted as an honors course.", Description="Honors", Definition="", SortOrder=0 },
            new RefCourseHonorsType { Id=Guid.Parse("a1459b08-aa5b-4c5f-bfc2-1c384fed314d"), Code="The course can be counted as an honors course.", Description="HonorsOption", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseHonorsType Pick List
         /// </summary>
        public static List<RefCourseHonorsType> RefCourseHonorsTypePickList = new List<RefCourseHonorsType> =
        {
            new RefCourseHonorsType { Id=Guid.Parse("9de43f7d-bcc3-40e8-b654-bd833395675a"), Code="The course is counted as an honors course.", SortOrder=0 },
            new RefCourseHonorsType { Id=Guid.Parse("a1459b08-aa5b-4c5f-bfc2-1c384fed314d"), Code="The course can be counted as an honors course.", SortOrder=0 },
       };
   }
}
