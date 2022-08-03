//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationSpecialEducation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationSpecialEducation
     /// </summary>
    public partial class ProgramParticipationSpecialEducation : IProgramParticipationSpecialEducation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.AwaitingInitialIDEAEvaluationStatus nullable property
        /// </summary>
        public System.Boolean? AwaitingInitialIDEAEvaluationStatus { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.SpecialEducationFTE nullable property
        /// </summary>
        public System.Decimal? SpecialEducationFTE { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.SpecialEducationServicesExitDate nullable property
        /// </summary>
        public System.DateTime? SpecialEducationServicesExitDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.IDEAPlacementRationale non nullable property
        /// </summary>
        public System.String IDEAPlacementRationale { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentEC"/> model
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentECId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentSchoolAge"/> model
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationExitReason"/> model
        /// </summary>
        public Guid? RefSpecialEducationExitReasonId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
