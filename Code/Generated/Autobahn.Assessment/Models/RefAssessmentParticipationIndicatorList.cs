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
        public static List<RefAssessmentParticipationIndicator> RefAssessmentParticipationIndicatorList = new List<RefAssessmentParticipationIndicator>
        {
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("d7c0ae2f-d547-4d36-9e13-93ffaf10a781"), Code="Participated", Description="Participated", Definition="The student participated in the assessment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("b4051e23-9c1a-49b8-b270-831521526284"), Code="DidNotParticipate", Description="Did Not Participate", Definition="The student did not participate in the assessment.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefAssessmentParticipationIndicator Pick List
         /// </summary>
        public static List<RefAssessmentParticipationIndicator> RefAssessmentParticipationIndicatorPickList = new List<RefAssessmentParticipationIndicator>
        {
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("d7c0ae2f-d547-4d36-9e13-93ffaf10a781"), Code="Participated", Description="Participated", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("b4051e23-9c1a-49b8-b270-831521526284"), Code="DidNotParticipate", Description="Did Not Participate", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
