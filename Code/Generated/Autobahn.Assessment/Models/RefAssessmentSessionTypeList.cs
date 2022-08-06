//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentSessionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentSessionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentSessionType"> List
         /// </summary>
        public static List<RefAssessmentSessionType> RefAssessmentSessionTypeList = new List<RefAssessmentSessionType> =
        {
            new RefAssessmentSessionType { Id=Guid.Parse("299e242f-1589-48bd-bf11-0c84937886e6"), Code="Standard is specified as the type of assessment session that is scheduled.", Description="Standard", Definition="", SortOrder=0 },
            new RefAssessmentSessionType { Id=Guid.Parse("f645af65-506f-47db-8ef7-80a93b36aa95"), Code="Accommodation is specified as the type of assessment session that is scheduled.", Description="Accommodation", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentSessionType Pick List
         /// </summary>
        public static List<RefAssessmentSessionType> RefAssessmentSessionTypePickList = new List<RefAssessmentSessionType> =
        {
            new RefAssessmentSessionType { Id=Guid.Parse("299e242f-1589-48bd-bf11-0c84937886e6"), Code="Standard is specified as the type of assessment session that is scheduled.", SortOrder=0 },
            new RefAssessmentSessionType { Id=Guid.Parse("f645af65-506f-47db-8ef7-80a93b36aa95"), Code="Accommodation is specified as the type of assessment session that is scheduled.", SortOrder=0 },
       };
   }
}
