//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceInteractionModeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceInteractionMode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceInteractionMode"> List
         /// </summary>
        public static List<RefLearningResourceInteractionMode> RefLearningResourceInteractionModeList = new List<RefLearningResourceInteractionMode> =
        {
            new RefLearningResourceInteractionMode { Id=Guid.Parse("5bd8d488-ff9c-4e05-941c-472e73df19fb"), Code="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", Description="Asynchronous", Definition="", SortOrder=0 },
            new RefLearningResourceInteractionMode { Id=Guid.Parse("3758fe60-af48-4b5a-bb4b-cb19088e4d0e"), Code="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", Description="Synchronous", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceInteractionMode Pick List
         /// </summary>
        public static List<RefLearningResourceInteractionMode> RefLearningResourceInteractionModePickList = new List<RefLearningResourceInteractionMode> =
        {
            new RefLearningResourceInteractionMode { Id=Guid.Parse("5bd8d488-ff9c-4e05-941c-472e73df19fb"), Code="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=0 },
            new RefLearningResourceInteractionMode { Id=Guid.Parse("3758fe60-af48-4b5a-bb4b-cb19088e4d0e"), Code="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=0 },
       };
   }
}
