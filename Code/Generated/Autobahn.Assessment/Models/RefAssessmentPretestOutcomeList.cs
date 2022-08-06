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
        public static List<RefAssessmentPretestOutcome> RefAssessmentPretestOutcomeList = new List<RefAssessmentPretestOutcome> =
        {
            new RefAssessmentPretestOutcome { Id=Guid.Parse("50cf574b-bf84-4de3-b8de-6c1c81127ca1"), Code="At or above Grade Level is specified as the results of a pre-test in academic subjects.", Description="GradeLevel", Definition="", SortOrder=0 },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("9aa4a8da-4b92-4aae-9e44-5d99e9866a47"), Code="Below Grade Level is specified as the results of a pre-test in academic subjects.", Description="BelowGradeLevel", Definition="", SortOrder=0 },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("1b13c422-9d38-44eb-a20f-be26c2fc5b9d"), Code="Not applicable is specified as the results of a pre-test in academic subjects.", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentPretestOutcome Pick List
         /// </summary>
        public static List<RefAssessmentPretestOutcome> RefAssessmentPretestOutcomePickList = new List<RefAssessmentPretestOutcome> =
        {
            new RefAssessmentPretestOutcome { Id=Guid.Parse("50cf574b-bf84-4de3-b8de-6c1c81127ca1"), Code="At or above Grade Level is specified as the results of a pre-test in academic subjects.", SortOrder=0 },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("9aa4a8da-4b92-4aae-9e44-5d99e9866a47"), Code="Below Grade Level is specified as the results of a pre-test in academic subjects.", SortOrder=0 },
            new RefAssessmentPretestOutcome { Id=Guid.Parse("1b13c422-9d38-44eb-a20f-be26c2fc5b9d"), Code="Not applicable is specified as the results of a pre-test in academic subjects.", SortOrder=0 },
       };
   }
}
