//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationAttainmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationAttainment Model
     /// </summary>
    public partial class ProgramParticipationAttainmentModel : AutobahnBase, Interfaces.IProgramParticipationAttainment
    {
        /// <summary>
        /// 
        /// </summary>
        public  AECredentialAttainmentEmployedIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AECredentialAttainmentPSCredentialIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AECredentialAttainmentPSEnrollmentIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    }
}
