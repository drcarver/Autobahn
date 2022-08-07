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
        /// The complete <see cref="RefCourseInteractionModeModel"> List
         /// </summary>
        public static List<RefCourseInteractionModeModel> RefCourseInteractionModeList = new List<RefCourseInteractionModeModel>
        {
            new RefCourseInteractionMode { Id=Guid.Parse("0d992fa5-d98e-4382-ba9b-fce0920afa04"), Code="Asynchronous", Description="Asynchronous", Definition="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInteractionMode { Id=Guid.Parse("4b6b3ea0-51fc-4c9f-b56e-fb235997d706"), Code="Synchronous", Description="Synchronous", Definition="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefCourseInteractionMode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseInteractionModeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseInteractionMode { Id=Guid.Parse("0d992fa5-d98e-4382-ba9b-fce0920afa04"), Description="Asynchronous", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseInteractionMode { Id=Guid.Parse("4b6b3ea0-51fc-4c9f-b56e-fb235997d706"), Description="Synchronous", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
