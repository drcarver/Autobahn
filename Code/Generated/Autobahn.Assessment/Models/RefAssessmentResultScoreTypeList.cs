//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentResultScoreTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentResultScoreType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentResultScoreType"> List
         /// </summary>
        public static List<RefAssessmentResultScoreType> RefAssessmentResultScoreTypeList = new List<RefAssessmentResultScoreType> =
        {
            new RefAssessmentResultScoreType { Id=Guid.Parse("c1bb3fb2-a211-4625-9c6a-8d1fb6daf9e8"), Code="An initial assessment score instance.", Description="Initial", Definition="", SortOrder=0 },
            new RefAssessmentResultScoreType { Id=Guid.Parse("86646df5-87de-4c03-8c45-179e7721cb7f"), Code="An assessment score instance recorded as a measure of reliability", Description="Reliability", Definition="", SortOrder=0 },
            new RefAssessmentResultScoreType { Id=Guid.Parse("56f70d49-1e80-450c-922f-2820a5f96dd1"), Code=" An assessment score instance recorded after resolution of scoring or data issues.", Description="Resolution", Definition="", SortOrder=0 },
            new RefAssessmentResultScoreType { Id=Guid.Parse("839d46fe-d4c8-495e-85af-f1b712544e9f"), Code="An assessment score recorded to determine whether or not each individual scorer is correctly applying the scoring guide to student responses.", Description="Backread", Definition="", SortOrder=0 },
            new RefAssessmentResultScoreType { Id=Guid.Parse("db6aee21-eb9c-4d64-ac83-0480e9e5b0be"), Code="The final assessment score instance.", Description="Final", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentResultScoreType Pick List
         /// </summary>
        public static List<RefAssessmentResultScoreType> RefAssessmentResultScoreTypePickList = new List<RefAssessmentResultScoreType> =
        {
            new RefAssessmentResultScoreType { Id=Guid.Parse("c1bb3fb2-a211-4625-9c6a-8d1fb6daf9e8"), Code="An initial assessment score instance.", SortOrder=0 },
            new RefAssessmentResultScoreType { Id=Guid.Parse("86646df5-87de-4c03-8c45-179e7721cb7f"), Code="An assessment score instance recorded as a measure of reliability", SortOrder=0 },
            new RefAssessmentResultScoreType { Id=Guid.Parse("56f70d49-1e80-450c-922f-2820a5f96dd1"), Code=" An assessment score instance recorded after resolution of scoring or data issues.", SortOrder=0 },
            new RefAssessmentResultScoreType { Id=Guid.Parse("839d46fe-d4c8-495e-85af-f1b712544e9f"), Code="An assessment score recorded to determine whether or not each individual scorer is correctly applying the scoring guide to student responses.", SortOrder=0 },
            new RefAssessmentResultScoreType { Id=Guid.Parse("db6aee21-eb9c-4d64-ac83-0480e9e5b0be"), Code="The final assessment score instance.", SortOrder=0 },
       };
   }
}
