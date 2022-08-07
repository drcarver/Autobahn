//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationSpecialEducationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationSpecialEducation Model
     /// </summary>
    public partial class ProgramParticipationSpecialEducationModel : AutobahnBase, Interfaces.IProgramParticipationSpecialEducationModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
