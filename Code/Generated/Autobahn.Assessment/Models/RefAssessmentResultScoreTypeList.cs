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
        public static List<RefAssessmentResultScoreType> RefAssessmentResultScoreTypeList = new List<RefAssessmentResultScoreType>
        {
            new RefAssessmentResultScoreType { Id=Guid.Parse("8fa2d45c-c81d-4212-a36a-1500bf18de71"), Code="Initial", Description="An initial assessment score instance.", Definition="An initial assessment score instance.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("1ec5a4fd-50cd-4f75-a31d-38265c985bd0"), Code="Reliability", Description="An assessment score instance recorded as a measure of reliability", Definition="An assessment score instance recorded as a measure of reliability", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("d4fab374-0ad7-4bb5-8ff1-e164bd7016e3"), Code="Resolution", Description=" An assessment score instance recorded after resolution of scoring or data issues.", Definition=" An assessment score instance recorded after resolution of scoring or data issues.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("f4f87a2c-99fd-4109-ae96-0c4a0bd5079a"), Code="Backread", Description="An assessment score recorded to determine whether or not each individual scorer is correctly applying the scoring guide to student responses.", Definition="An assessment score recorded to determine whether or not each individual scorer is correctly applying the scoring guide to student responses.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("2c91b7bf-2a52-4c86-8d57-9d561815e3cb"), Code="Final", Description="The final assessment score instance.", Definition="The final assessment score instance.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefAssessmentResultScoreType Pick List
         /// </summary>
        public static List<RefAssessmentResultScoreType> RefAssessmentResultScoreTypePickList = new List<RefAssessmentResultScoreType>
        {
            new RefAssessmentResultScoreType { Id=Guid.Parse("8fa2d45c-c81d-4212-a36a-1500bf18de71"), Code="Initial", Description="An initial assessment score instance.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("1ec5a4fd-50cd-4f75-a31d-38265c985bd0"), Code="Reliability", Description="An assessment score instance recorded as a measure of reliability", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("d4fab374-0ad7-4bb5-8ff1-e164bd7016e3"), Code="Resolution", Description=" An assessment score instance recorded after resolution of scoring or data issues.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("f4f87a2c-99fd-4109-ae96-0c4a0bd5079a"), Code="Backread", Description="An assessment score recorded to determine whether or not each individual scorer is correctly applying the scoring guide to student responses.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("2c91b7bf-2a52-4c86-8d57-9d561815e3cb"), Code="Final", Description="The final assessment score instance.", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
