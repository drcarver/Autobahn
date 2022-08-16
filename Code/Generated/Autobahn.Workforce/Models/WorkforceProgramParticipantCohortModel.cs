//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceProgramParticipantCohort Model
     /// </summary>
    public partial class WorkforceProgramParticipantCohortModel : AutobahnBase, Interfaces.IWorkforceProgramParticipantCohort
    {
        /// <summary>
        /// 
        /// </summary>
        public  CohortMedianEarnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
