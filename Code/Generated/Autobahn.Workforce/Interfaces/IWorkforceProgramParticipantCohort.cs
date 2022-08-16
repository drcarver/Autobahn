//***************************************************************************
//* DomainName: Workforce Interfaces (used by both models and View Models
//* FileName:   IWorkforceProgramParticipantCohort.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceProgramParticipantCohort Interface
     /// </summary>
    public partial interface IWorkforceProgramParticipantCohort : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CohortMedianEarnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
