//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentReasonNotCompletingList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentReasonNotCompleting Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentReasonNotCompleting"> List
         /// </summary>
        public static List<RefAssessmentReasonNotCompleting> RefAssessmentReasonNotCompletingList = new List<RefAssessmentReasonNotCompleting> =
        {
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("6e02826a-d0da-43fd-aadd-fc67398d4d7e"), Code="Parents opt out is specified as the primary reason a participant did not complete an assessment.", Description="ParentsOptOut", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("6132cff1-8e36-4d0b-bcc7-8bca8834f691"), Code="Absent during is specified as the primary reason a participant did not complete an assessment.", Description="Absent", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("8c31f274-5c72-40b7-939e-eb3a64df05c2"), Code="Did not participate for other reason is specified as the primary reason a participant did not complete an assessment.", Description="Other", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("4b0b7016-8d38-4a06-bedc-cd249216059b"), Code="Student participated in an out of level test is specified as the primary reason a participant did not complete an assessment.  (may not be in accordance with accountability measures for summative assessments)", Description="OutOfLevelTest", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("87b4d52a-741b-49fa-bf52-556392dc6aa5"), Code="No valid score is specified as the primary reason a participant did not complete an assessment.", Description="NoValidScore", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("1c50dbfc-01cb-4e0e-97a9-dcec963e4a21"), Code="Medical emergency is specified as the primary reason a participant did not complete an assessment.", Description="Medical", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("e119b454-8934-4d00-a08e-876e962afb2b"), Code="Moved is specified as the primary reason a participant did not complete an assessment.", Description="Moved", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("7cca47f8-13b0-47aa-bc75-7b25cb84cf7f"), Code="Person left program - unable to locate is specified as the primary reason a participant did not complete an assessment.", Description="LeftProgram", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentReasonNotCompleting Pick List
         /// </summary>
        public static List<RefAssessmentReasonNotCompleting> RefAssessmentReasonNotCompletingPickList = new List<RefAssessmentReasonNotCompleting> =
        {
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("6e02826a-d0da-43fd-aadd-fc67398d4d7e"), Code="Parents opt out is specified as the primary reason a participant did not complete an assessment.", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("6132cff1-8e36-4d0b-bcc7-8bca8834f691"), Code="Absent during is specified as the primary reason a participant did not complete an assessment.", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("8c31f274-5c72-40b7-939e-eb3a64df05c2"), Code="Did not participate for other reason is specified as the primary reason a participant did not complete an assessment.", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("4b0b7016-8d38-4a06-bedc-cd249216059b"), Code="Student participated in an out of level test is specified as the primary reason a participant did not complete an assessment.  (may not be in accordance with accountability measures for summative assessments)", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("87b4d52a-741b-49fa-bf52-556392dc6aa5"), Code="No valid score is specified as the primary reason a participant did not complete an assessment.", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("1c50dbfc-01cb-4e0e-97a9-dcec963e4a21"), Code="Medical emergency is specified as the primary reason a participant did not complete an assessment.", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("e119b454-8934-4d00-a08e-876e962afb2b"), Code="Moved is specified as the primary reason a participant did not complete an assessment.", SortOrder=0 },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("7cca47f8-13b0-47aa-bc75-7b25cb84cf7f"), Code="Person left program - unable to locate is specified as the primary reason a participant did not complete an assessment.", SortOrder=0 },
       };
   }
}
