//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationSpecialEducationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationSpecialEducation Model
     /// </summary>
    public partial class ProgramParticipationSpecialEducationModel : AutobahnBase, Interfaces.IProgramParticipationSpecialEducation
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AwaitingInitialIDEAEvaluationStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IDEAPlacementRationale { get; set; }

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
        public  RefIDEAEducationalEnvironmentECId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSpecialEducationExitReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SpecialEducationFTE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SpecialEducationServicesExitDate { get; set; }

    }
}
