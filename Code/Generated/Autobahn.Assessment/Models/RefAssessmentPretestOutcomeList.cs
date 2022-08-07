//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentPretestOutcomeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentPretestOutcome Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentPretestOutcomeModel"> List
         /// </summary>
        public static List<RefAssessmentPretestOutcomeModel> RefAssessmentPretestOutcomeList = new List<RefAssessmentPretestOutcomeModel>
        {
            new RefAssessmentPretestOutcome { Id=Guid.Parse("d428167f-784c-47a0-aebf-3ea7db39aa5e"), Code="GradeLevel", Description="At or above Grade Level", Definition="At or above Grade Level is specified as the results of a pre-test in academic subjects.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("a51b5694-9fc7-4336-b27e-d50418643b6e"), Code="BelowGradeLevel", Description="Below Grade Level", Definition="Below Grade Level is specified as the results of a pre-test in academic subjects.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("ea3a7a30-6b5e-4e71-8fb1-e0dd319fe50c"), Code="NA", Description="Not applicable", Definition="Not applicable is specified as the results of a pre-test in academic subjects.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentPretestOutcome Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentPretestOutcomeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentPretestOutcome { Id=Guid.Parse("d428167f-784c-47a0-aebf-3ea7db39aa5e"), Description="At or above Grade Level", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("a51b5694-9fc7-4336-b27e-d50418643b6e"), Description="Below Grade Level", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("ea3a7a30-6b5e-4e71-8fb1-e0dd319fe50c"), Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
