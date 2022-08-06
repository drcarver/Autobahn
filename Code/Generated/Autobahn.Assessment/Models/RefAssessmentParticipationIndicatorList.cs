//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentParticipationIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentParticipationIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentParticipationIndicator"> List
         /// </summary>
        public static List<RefAssessmentParticipationIndicator> RefAssessmentParticipationIndicatorList = new List<RefAssessmentParticipationIndicator> =
        {
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("73b75570-1bff-403c-b3e2-9b2578ab294a"), Code="The student participated in the assessment.", Description="Participated", Definition="", SortOrder=0 },
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("64abf777-0fcc-4a5f-a064-fe2da0efb25f"), Code="The student did not participate in the assessment.", Description="DidNotParticipate", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentParticipationIndicator Pick List
         /// </summary>
        public static List<RefAssessmentParticipationIndicator> RefAssessmentParticipationIndicatorPickList = new List<RefAssessmentParticipationIndicator> =
        {
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("73b75570-1bff-403c-b3e2-9b2578ab294a"), Code="The student participated in the assessment.", SortOrder=0 },
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("64abf777-0fcc-4a5f-a064-fe2da0efb25f"), Code="The student did not participate in the assessment.", SortOrder=0 },
       };
   }
}
