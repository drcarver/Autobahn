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
        public static List<RefCourseInteractionMode> RefCourseInteractionModeList = new List<RefCourseInteractionMode>
        {
            new RefCourseInteractionMode { Id=Guid.Parse("ebf74313-1085-4971-a945-45a068363072"), Code="Asynchronous", Description="Asynchronous", Definition="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInteractionMode { Id=Guid.Parse("fbe70516-8914-434c-a7b0-b7390bba7703"), Code="Synchronous", Description="Synchronous", Definition="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefCourseInteractionMode Pick List
         /// </summary>
        public static List<RefCourseInteractionMode> RefCourseInteractionModePickList = new List<RefCourseInteractionMode>
        {
            new RefCourseInteractionMode { Id=Guid.Parse("ebf74313-1085-4971-a945-45a068363072"), Code="Asynchronous", Description="Asynchronous", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInteractionMode { Id=Guid.Parse("fbe70516-8914-434c-a7b0-b7390bba7703"), Code="Synchronous", Description="Synchronous", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
