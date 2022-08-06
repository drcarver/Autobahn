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
        public static List<RefAssessmentSessionType> RefAssessmentSessionTypeList = new List<RefAssessmentSessionType>
        {
            new RefAssessmentSessionType { Id=Guid.Parse("08374c8f-d221-48e8-9d1e-34f569fbe3e7"), Code="Standard", Description="Standard", Definition="Standard is specified as the type of assessment session that is scheduled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentSessionType { Id=Guid.Parse("060f32cd-f794-4e14-9df2-ff2c34c4a765"), Code="Accommodation", Description="Accommodation", Definition="Accommodation is specified as the type of assessment session that is scheduled.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefAssessmentSessionType Pick List
         /// </summary>
        public static List<RefAssessmentSessionType> RefAssessmentSessionTypePickList = new List<RefAssessmentSessionType>
        {
            new RefAssessmentSessionType { Id=Guid.Parse("08374c8f-d221-48e8-9d1e-34f569fbe3e7"), Code="Standard", Description="Standard", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentSessionType { Id=Guid.Parse("060f32cd-f794-4e14-9df2-ff2c34c4a765"), Code="Accommodation", Description="Accommodation", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
