//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationSpecialEducationModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationSpecialEducationModel Interface
     /// </summary>
    public partial interface IProgramParticipationSpecialEducationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.AwaitingInitialIDEAEvaluationStatus nullable property
        /// </summary>
        System.Boolean? AwaitingInitialIDEAEvaluationStatus { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.SpecialEducationFTE nullable property
        /// </summary>
        System.Decimal? SpecialEducationFTE { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.SpecialEducationServicesExitDate nullable property
        /// </summary>
        System.DateTime? SpecialEducationServicesExitDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.IDEAPlacementRationale non nullable property
        /// </summary>
        System.String IDEAPlacementRationale { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentEC"/> model
        /// </summary>
        Guid? RefIDEAEducationalEnvironmentECId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentSchoolAge"/> model
        /// </summary>
        Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationExitReason"/> model
        /// </summary>
        Guid? RefSpecialEducationExitReasonId { get; set; }

    }
}
