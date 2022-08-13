//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceProgramParticipation Model
     /// </summary>
    public partial class WorkforceProgramParticipationModel : AutobahnBase, Interfaces.IWorkforceProgramParticipation
    {
        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public Guid? RefWfProgramParticipationId { get; set; }

    }
}
