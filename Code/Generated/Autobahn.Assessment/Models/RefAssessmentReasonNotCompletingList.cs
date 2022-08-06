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
        public static List<RefAssessmentReasonNotCompleting> RefAssessmentReasonNotCompletingList = new List<RefAssessmentReasonNotCompleting>
        {
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("89d3ac30-e110-40ff-a759-38a689ee3f2f"), Code="ParentsOptOut", Description="Parents opt out", Definition="Parents opt out is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("eacdc7fe-c65f-4754-9f6c-d595e788e48e"), Code="Absent", Description="Absent during", Definition="Absent during is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("b08c0272-8279-4505-ab7f-18700161c629"), Code="Other", Description="Did not participate for other reason", Definition="Did not participate for other reason is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("bbc3f105-c67c-4437-8f92-5ae75fa42206"), Code="OutOfLevelTest", Description="Participated in an out of level test", Definition="Student participated in an out of level test is specified as the primary reason a participant did not complete an assessment.  (may not be in accordance with accountability measures for summative assessments)", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("c11623f7-687e-4318-bfee-a560e60be73f"), Code="NoValidScore", Description="No valid score", Definition="No valid score is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("fead425c-6e8b-4220-8998-fcc06cd8cc52"), Code="Medical", Description="Medical emergency", Definition="Medical emergency is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("10cc8633-7f98-402c-a857-511c7b35bfd4"), Code="Moved", Description="Moved", Definition="Moved is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("18bccbd9-8468-449b-8901-00a73c89247b"), Code="LeftProgram", Description="Person left program - unable to locate", Definition="Person left program - unable to locate is specified as the primary reason a participant did not complete an assessment.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefAssessmentReasonNotCompleting Pick List
         /// </summary>
        public static List<RefAssessmentReasonNotCompleting> RefAssessmentReasonNotCompletingPickList = new List<RefAssessmentReasonNotCompleting>
        {
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("89d3ac30-e110-40ff-a759-38a689ee3f2f"), Code="ParentsOptOut", Description="Parents opt out", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("eacdc7fe-c65f-4754-9f6c-d595e788e48e"), Code="Absent", Description="Absent during", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("b08c0272-8279-4505-ab7f-18700161c629"), Code="Other", Description="Did not participate for other reason", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("bbc3f105-c67c-4437-8f92-5ae75fa42206"), Code="OutOfLevelTest", Description="Participated in an out of level test", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("c11623f7-687e-4318-bfee-a560e60be73f"), Code="NoValidScore", Description="No valid score", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("fead425c-6e8b-4220-8998-fcc06cd8cc52"), Code="Medical", Description="Medical emergency", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("10cc8633-7f98-402c-a857-511c7b35bfd4"), Code="Moved", Description="Moved", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentReasonNotCompleting { Id=Guid.Parse("18bccbd9-8468-449b-8901-00a73c89247b"), Code="LeftProgram", Description="Person left program - unable to locate", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
