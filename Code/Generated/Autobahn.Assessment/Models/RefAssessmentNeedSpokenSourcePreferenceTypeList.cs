//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedSpokenSourcePreferenceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedSpokenSourcePreferenceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedSpokenSourcePreferenceType"> List
         /// </summary>
        public static List<RefAssessmentNeedSpokenSourcePreferenceType> RefAssessmentNeedSpokenSourcePreferenceTypeList = new List<RefAssessmentNeedSpokenSourcePreferenceType>
        {
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("ea1834ae-738e-4b04-b2fd-82e416b8765f"), Code="Human", Description="Human", Definition="Human is specified as the preferred spoken audio form  as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("9f96647e-b8c5-4734-8e16-559ac5f80acc"), Code="Synthetic", Description="Synthetic", Definition="Synthetic is specified as the preferred spoken audio form  as part of an Assessment Personal Needs Profile.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedSpokenSourcePreferenceType Pick List
         /// </summary>
        public static List<RefAssessmentNeedSpokenSourcePreferenceType> RefAssessmentNeedSpokenSourcePreferenceTypePickList = new List<RefAssessmentNeedSpokenSourcePreferenceType>
        {
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("ea1834ae-738e-4b04-b2fd-82e416b8765f"), Code="Human", Description="Human", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("9f96647e-b8c5-4734-8e16-559ac5f80acc"), Code="Synthetic", Description="Synthetic", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
