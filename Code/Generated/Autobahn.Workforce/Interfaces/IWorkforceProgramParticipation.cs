//***************************************************************************
//* DomainName: Workforce Interfaces (used by both models and View Models
//* FileName:   IWorkforceProgramParticipation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceProgramParticipation Interface
     /// </summary>
    public partial interface IWorkforceProgramParticipation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefWfProgramParticipationId { get; set; }

    }
}
