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
        /// The complete <see cref="RefAssessmentParticipationIndicatorModel"> List
         /// </summary>
        public static List<RefAssessmentParticipationIndicatorModel> RefAssessmentParticipationIndicatorList = new List<RefAssessmentParticipationIndicatorModel>
        {
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("3d6dba23-76d0-4696-af05-60b148be3023"), Code="Participated", Description="Participated", Definition="The student participated in the assessment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("65699762-e234-4847-aabe-4084b8d4cc83"), Code="DidNotParticipate", Description="Did Not Participate", Definition="The student did not participate in the assessment.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentParticipationIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentParticipationIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("3d6dba23-76d0-4696-af05-60b148be3023"), Description="Participated", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentParticipationIndicator { Id=Guid.Parse("65699762-e234-4847-aabe-4084b8d4cc83"), Description="Did Not Participate", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
