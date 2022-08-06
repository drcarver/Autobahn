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
        public static List<RefCompetencySetCompletionCriteria> RefCompetencySetCompletionCriteriaList = new List<RefCompetencySetCompletionCriteria>
        {
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("864f9d05-18c3-46eb-a7e0-f96a922587df"), Code="All", Description="All", Definition="All items in the set must be achieved.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("de79fbba-e43e-4741-ab0f-7781b734fa08"), Code="AtLeast", Description="At Least", Definition="At least the number of items in the set specified by Competency Set Completion Criteria Threshold must be achieved.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefCompetencySetCompletionCriteria Pick List
         /// </summary>
        public static List<RefCompetencySetCompletionCriteria> RefCompetencySetCompletionCriteriaPickList = new List<RefCompetencySetCompletionCriteria>
        {
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("864f9d05-18c3-46eb-a7e0-f96a922587df"), Code="All", Description="All", SortOrder=Convert.ToDecimal("1.00") },
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("de79fbba-e43e-4741-ab0f-7781b734fa08"), Code="AtLeast", Description="At Least", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
