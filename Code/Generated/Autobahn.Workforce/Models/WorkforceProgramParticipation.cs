//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceProgramParticipation.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceProgramParticipation
     /// </summary>
    public partial class WorkforceProgramParticipation : AutobahnBase, Interfaces.IWorkforceProgramParticipation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipation.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWfProgramParticipation"/> model
        /// </summary>
        public Guid? RefWfProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
