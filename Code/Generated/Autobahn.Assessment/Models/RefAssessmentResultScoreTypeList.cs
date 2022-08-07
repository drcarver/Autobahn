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
        /// The complete <see cref="RefAssessmentResultScoreTypeModel"> List
         /// </summary>
        public static List<RefAssessmentResultScoreTypeModel> RefAssessmentResultScoreTypeList = new List<RefAssessmentResultScoreTypeModel>
        {
            new RefAssessmentResultScoreType { Id=Guid.Parse("f9d5038e-bc41-4917-824a-b5664767d046"), Code="Initial", Description="An initial assessment score instance.", Definition="An initial assessment score instance.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("cb08d67a-ba27-4678-8fa8-7d3ab5a652d0"), Code="Reliability", Description="An assessment score instance recorded as a measure of reliability", Definition="An assessment score instance recorded as a measure of reliability", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("564782a1-acd6-46e1-92ba-7581f469bcd3"), Code="Resolution", Description=" An assessment score instance recorded after resolution of scoring or data issues.", Definition=" An assessment score instance recorded after resolution of scoring or data issues.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("df81934d-5042-4ed5-af7d-634886764522"), Code="Backread", Description="An assessment score recorded to determine whether or not each individual scorer is correctly applying the scoring guide to student responses.", Definition="An assessment score recorded to determine whether or not each individual scorer is correctly applying the scoring guide to student responses.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("8132c4a8-0b55-4d16-8187-cbb901db101e"), Code="Final", Description="The final assessment score instance.", Definition="The final assessment score instance.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentResultScoreType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentResultScoreTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentResultScoreType { Id=Guid.Parse("f9d5038e-bc41-4917-824a-b5664767d046"), Description="An initial assessment score instance.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("cb08d67a-ba27-4678-8fa8-7d3ab5a652d0"), Description="An assessment score instance recorded as a measure of reliability", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("564782a1-acd6-46e1-92ba-7581f469bcd3"), Description=" An assessment score instance recorded after resolution of scoring or data issues.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("df81934d-5042-4ed5-af7d-634886764522"), Description="An assessment score recorded to determine whether or not each individual scorer is correctly applying the scoring guide to student responses.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAssessmentResultScoreType { Id=Guid.Parse("8132c4a8-0b55-4d16-8187-cbb901db101e"), Description="The final assessment score instance.", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
