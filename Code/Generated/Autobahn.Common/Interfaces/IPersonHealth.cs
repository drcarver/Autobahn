//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonHealth.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHealth
     /// </summary>
    public partial interface IPersonHealth
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonHealth.VisionScreeningDate nullable property
        /// </summary>
        System.DateTime? VisionScreeningDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisionScreeningStatus"/> model
        /// </summary>
        Guid? RefVisionScreeningStatusId { get; set; }

        /// <summary>
        /// Defines the PersonHealth.HearingScreeningDate nullable property
        /// </summary>
        System.DateTime? HearingScreeningDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHearingScreeningStatus"/> model
        /// </summary>
        Guid? RefHearingScreeningStatusId { get; set; }

        /// <summary>
        /// Defines the PersonHealth.DentalScreeningDate non nullable property
        /// </summary>
        System.DateTime DentalScreeningDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalScreeningStatus"/> model
        /// </summary>
        Guid? RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHealthInsuranceCoverage"/> model
        /// </summary>
        Guid? RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalInsuranceCoverageType"/> model
        /// </summary>
        Guid? RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMedicalAlertIndicator"/> model
        /// </summary>
        Guid? RefMedicalAlertIndicatorId { get; set; }

        /// <summary>
        /// Defines the PersonHealth.HealthScreeningEquipmentUsed non nullable property
        /// </summary>
        System.String HealthScreeningEquipmentUsed { get; set; }

        /// <summary>
        /// Defines the PersonHealth.HealthScreeningFollowUpRecommendation non nullable property
        /// </summary>
        System.String HealthScreeningFollowUpRecommendation { get; set; }

        /// <summary>
        /// Defines the PersonHealth.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonHealth.RecordEndDateTime nullable property
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
