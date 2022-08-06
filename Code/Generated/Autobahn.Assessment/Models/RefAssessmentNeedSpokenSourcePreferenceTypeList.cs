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
        public static List<RefAssessmentNeedSpokenSourcePreferenceType> RefAssessmentNeedSpokenSourcePreferenceTypeList = new List<RefAssessmentNeedSpokenSourcePreferenceType> =
        {
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("cd839193-e05d-4ae9-910a-f716c829341f"), Code="Human is specified as the preferred spoken audio form  as part of an Assessment Personal Needs Profile.", Description="Human", Definition="", SortOrder=0 },
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("5bcb632b-3a25-4a00-a424-3a471c3731fb"), Code="Synthetic is specified as the preferred spoken audio form  as part of an Assessment Personal Needs Profile.", Description="Synthetic", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedSpokenSourcePreferenceType Pick List
         /// </summary>
        public static List<RefAssessmentNeedSpokenSourcePreferenceType> RefAssessmentNeedSpokenSourcePreferenceTypePickList = new List<RefAssessmentNeedSpokenSourcePreferenceType> =
        {
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("cd839193-e05d-4ae9-910a-f716c829341f"), Code="Human is specified as the preferred spoken audio form  as part of an Assessment Personal Needs Profile.", SortOrder=0 },
            new RefAssessmentNeedSpokenSourcePreferenceType { Id=Guid.Parse("5bcb632b-3a25-4a00-a424-3a471c3731fb"), Code="Synthetic is specified as the preferred spoken audio form  as part of an Assessment Personal Needs Profile.", SortOrder=0 },
       };
   }
}
