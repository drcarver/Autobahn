//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationSpecialEducation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationSpecialEducation
     /// </summary>
    public partial interface IProgramParticipationSpecialEducation
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

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationSpecialEducation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
