//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationAttainmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ProgramParticipationAttainment Model
     /// </summary>
    public partial class ProgramParticipationAttainmentModel : AutobahnBase, Interfaces.IProgramParticipationAttainment
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? AECredentialAttainmentEmployedIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? AECredentialAttainmentPSCredentialIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? AECredentialAttainmentPSEnrollmentIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    }
}
