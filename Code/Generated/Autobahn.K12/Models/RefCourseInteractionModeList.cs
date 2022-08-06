//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCourseInteractionModeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefCourseInteractionMode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseInteractionMode"> List
         /// </summary>
        public static List<RefCourseInteractionMode> RefCourseInteractionModeList = new List<RefCourseInteractionMode> =
        {
            new RefCourseInteractionMode { Id=Guid.Parse("23545a71-f3f9-4dbb-bf9b-0745e8ef289b"), Code="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", Description="Asynchronous", Definition="", SortOrder=0 },
            new RefCourseInteractionMode { Id=Guid.Parse("ac3701b5-3468-4b81-8b5f-18603e772422"), Code="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", Description="Synchronous", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseInteractionMode Pick List
         /// </summary>
        public static List<RefCourseInteractionMode> RefCourseInteractionModePickList = new List<RefCourseInteractionMode> =
        {
            new RefCourseInteractionMode { Id=Guid.Parse("23545a71-f3f9-4dbb-bf9b-0745e8ef289b"), Code="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=0 },
            new RefCourseInteractionMode { Id=Guid.Parse("ac3701b5-3468-4b81-8b5f-18603e772422"), Code="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=0 },
       };
   }
}
