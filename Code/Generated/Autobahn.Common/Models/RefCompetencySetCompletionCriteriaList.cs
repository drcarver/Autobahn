//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCompetencySetCompletionCriteriaList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCompetencySetCompletionCriteria Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCompetencySetCompletionCriteriaModel"> List
         /// </summary>
        public static List<RefCompetencySetCompletionCriteriaModel> RefCompetencySetCompletionCriteriaList = new List<RefCompetencySetCompletionCriteriaModel>
        {
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("ad278d48-4a50-416d-8a1c-f0636d332094"), Code="All", Description="All", Definition="All items in the set must be achieved.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("ea051fc2-bd81-4eaf-85d1-dacaa7eda014"), Code="AtLeast", Description="At Least", Definition="At least the number of items in the set specified by Competency Set Completion Criteria Threshold must be achieved.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefCompetencySetCompletionCriteria Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCompetencySetCompletionCriteriaViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("ad278d48-4a50-416d-8a1c-f0636d332094"), Description="All", SortOrder=Convert.ToDecimal("1.00") },
            new RefCompetencySetCompletionCriteria { Id=Guid.Parse("ea051fc2-bd81-4eaf-85d1-dacaa7eda014"), Description="At Least", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
