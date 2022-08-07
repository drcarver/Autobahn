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
        /// The complete <see cref="RefAssessmentReasonNotCompletingModel"> List
         /// </summary>
        public static List<RefAssessmentReasonNotCompletingModel> RefAssessmentReasonNotCompletingList = new List<RefAssessmentReasonNotCompletingModel>
        {
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("87645235-5a9c-40b7-8e5b-3572bbe6ac5a"), Code="ParentsOptOut", Description="Parents opt out", Definition="Parents opt out is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("b1fdc083-ff0a-4f34-8e76-7b2721e60fa0"), Code="Absent", Description="Absent during", Definition="Absent during is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("3352eadc-e237-485b-930a-a1eca0802f00"), Code="Other", Description="Did not participate for other reason", Definition="Did not participate for other reason is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("98b8e542-7126-4cd3-8b7f-5d564bf431b9"), Code="OutOfLevelTest", Description="Participated in an out of level test", Definition="Student participated in an out of level test is specified as the primary reason a participant did not complete an assessment.  (may not be in accordance with accountability measures for summative assessments)", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("d00d66df-819b-4712-a030-1fdec6433356"), Code="NoValidScore", Description="No valid score", Definition="No valid score is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("253707ba-f4ac-43cb-971f-3456766bd6bf"), Code="Medical", Description="Medical emergency", Definition="Medical emergency is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("b939d476-254d-4a33-b7d9-274fae341d27"), Code="Moved", Description="Moved", Definition="Moved is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("865e3df0-a335-4931-b54c-57856473dafb"), Code="LeftProgram", Description="Person left program - unable to locate", Definition="Person left program - unable to locate is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentReasonNotCompleting Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentReasonNotCompletingViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("87645235-5a9c-40b7-8e5b-3572bbe6ac5a"), Description="Parents opt out", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("b1fdc083-ff0a-4f34-8e76-7b2721e60fa0"), Description="Absent during", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("3352eadc-e237-485b-930a-a1eca0802f00"), Description="Did not participate for other reason", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("98b8e542-7126-4cd3-8b7f-5d564bf431b9"), Description="Participated in an out of level test", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("d00d66df-819b-4712-a030-1fdec6433356"), Description="No valid score", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("253707ba-f4ac-43cb-971f-3456766bd6bf"), Description="Medical emergency", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("b939d476-254d-4a33-b7d9-274fae341d27"), Description="Moved", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("865e3df0-a335-4931-b54c-57856473dafb"), Description="Person left program - unable to locate", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
