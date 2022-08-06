//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCompetencySetCompletionCriteriaList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCompetencySetCompletionCriteria Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCompetencySetCompletionCriteria"> List
         /// </summary>
        public static List<RefCompetencySetCompletionCriteria> RefCompetencySetCompletionCriteriaList = new List<RefCompetencySetCompletionCriteria> =
        {
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("a933eae1-8bff-4c2c-bc2d-f2cf4641ef5c"), Code="All items in the set must be achieved.", Description="All", Definition="", SortOrder=0 },
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("e204b090-4323-4810-8364-935308d5d59d"), Code="At least the number of items in the set specified by Competency Set Completion Criteria Threshold must be achieved.", Description="AtLeast", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCompetencySetCompletionCriteria Pick List
         /// </summary>
        public static List<RefCompetencySetCompletionCriteria> RefCompetencySetCompletionCriteriaPickList = new List<RefCompetencySetCompletionCriteria> =
        {
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("a933eae1-8bff-4c2c-bc2d-f2cf4641ef5c"), Code="All items in the set must be achieved.", SortOrder=0 },
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("e204b090-4323-4810-8364-935308d5d59d"), Code="At least the number of items in the set specified by Competency Set Completion Criteria Threshold must be achieved.", SortOrder=0 },
       };
   }
}
