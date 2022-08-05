//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   IWorkforceProgramParticipation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceProgramParticipation
     /// </summary>
    public partial interface IWorkforceProgramParticipation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipation.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWfProgramParticipation"/> model
        /// </summary>
        Guid? RefWfProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    }
}
