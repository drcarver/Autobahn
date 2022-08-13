//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationWIOAModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ProgramParticipationWIOA Model
     /// </summary>
    public partial class ProgramParticipationWIOAModel : AutobahnBase, Interfaces.IProgramParticipationWIOA
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? WIOACareerServices { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? WIOATrainingServices { get; set; }

    }
}
