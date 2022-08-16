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
        /// 
        /// </summary>
        public Guid? DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefWfProgramParticipationId { get; set; }

    }
}
