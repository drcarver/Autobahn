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
        /// The complete <see cref="RefAssessmentPretestOutcome"> List
         /// </summary>
        public static List<RefAssessmentPretestOutcome> RefAssessmentPretestOutcomeList = new List<RefAssessmentPretestOutcome>
        {
            new RefAssessmentPretestOutcome { Id=Guid.Parse("c153b657-0b2a-4343-b5d0-6ee020691b25"), Code="GradeLevel", Description="At or above Grade Level", Definition="At or above Grade Level is specified as the results of a pre-test in academic subjects.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("ac27b3a9-c3e2-4744-8bc3-be5483db0dae"), Code="BelowGradeLevel", Description="Below Grade Level", Definition="Below Grade Level is specified as the results of a pre-test in academic subjects.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("bac40724-eb42-4e6c-9f0b-d2358d14b6d8"), Code="NA", Description="Not applicable", Definition="Not applicable is specified as the results of a pre-test in academic subjects.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefAssessmentPretestOutcome Pick List
         /// </summary>
        public static List<RefAssessmentPretestOutcome> RefAssessmentPretestOutcomePickList = new List<RefAssessmentPretestOutcome>
        {
            new RefAssessmentPretestOutcome { Id=Guid.Parse("c153b657-0b2a-4343-b5d0-6ee020691b25"), Code="GradeLevel", Description="At or above Grade Level", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("ac27b3a9-c3e2-4744-8bc3-be5483db0dae"), Code="BelowGradeLevel", Description="Below Grade Level", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("bac40724-eb42-4e6c-9f0b-d2358d14b6d8"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
