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
        public static List<RefCourseHonorsType> RefCourseHonorsTypeList = new List<RefCourseHonorsType>
        {
            new RefCourseHonorsType { Id=Guid.Parse("f6dcb54b-307f-4e8b-ba22-e1d560241af5"), Code="Honors", Description="Honors", Definition="The course is counted as an honors course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseHonorsType { Id=Guid.Parse("a5062289-b528-4e7f-a496-6bc33c5637ef"), Code="HonorsOption", Description="Honors option", Definition="The course can be counted as an honors course.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefCourseHonorsType Pick List
         /// </summary>
        public static List<RefCourseHonorsType> RefCourseHonorsTypePickList = new List<RefCourseHonorsType>
        {
            new RefCourseHonorsType { Id=Guid.Parse("f6dcb54b-307f-4e8b-ba22-e1d560241af5"), Code="Honors", Description="Honors", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseHonorsType { Id=Guid.Parse("a5062289-b528-4e7f-a496-6bc33c5637ef"), Code="HonorsOption", Description="Honors option", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
