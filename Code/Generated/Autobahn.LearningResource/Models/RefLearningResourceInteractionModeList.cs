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
        public static List<RefLearningResourceInteractionMode> RefLearningResourceInteractionModeList = new List<RefLearningResourceInteractionMode>
        {
            new RefLearningResourceInteractionMode { Id=Guid.Parse("eab1de82-3b67-447c-9666-937fe96e4ca7"), Code="Asynchronous", Description="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", Definition="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceInteractionMode { Id=Guid.Parse("a4b399b6-a2ee-4d91-a39e-f6c9eac8d038"), Code="Synchronous", Description="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", Definition="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefLearningResourceInteractionMode Pick List
         /// </summary>
        public static List<RefLearningResourceInteractionMode> RefLearningResourceInteractionModePickList = new List<RefLearningResourceInteractionMode>
        {
            new RefLearningResourceInteractionMode { Id=Guid.Parse("eab1de82-3b67-447c-9666-937fe96e4ca7"), Code="Asynchronous", Description="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceInteractionMode { Id=Guid.Parse("a4b399b6-a2ee-4d91-a39e-f6c9eac8d038"), Code="Synchronous", Description="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
