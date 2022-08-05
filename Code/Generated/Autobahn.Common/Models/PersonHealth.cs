//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealth.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHealth
     /// </summary>
    public partial class PersonHealth : AutobahnBase, Interfaces.IPersonHealth
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonHealth.VisionScreeningDate nullable property
        /// </summary>
        public System.DateTime? VisionScreeningDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisionScreeningStatus"/> model
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get; set; }

        /// <summary>
        /// Defines the PersonHealth.HearingScreeningDate nullable property
        /// </summary>
        public System.DateTime? HearingScreeningDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHearingScreeningStatus"/> model
        /// </summary>
        public Guid? RefHearingScreeningStatusId { get; set; }

        /// <summary>
        /// Defines the PersonHealth.DentalScreeningDate non nullable property
        /// </summary>
        public System.DateTime DentalScreeningDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalScreeningStatus"/> model
        /// </summary>
        public Guid? RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHealthInsuranceCoverage"/> model
        /// </summary>
        public Guid? RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalInsuranceCoverageType"/> model
        /// </summary>
        public Guid? RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMedicalAlertIndicator"/> model
        /// </summary>
        public Guid? RefMedicalAlertIndicatorId { get; set; }

        /// <summary>
        /// Defines the PersonHealth.HealthScreeningEquipmentUsed non nullable property
        /// </summary>
        public System.String HealthScreeningEquipmentUsed { get; set; }

        /// <summary>
        /// Defines the PersonHealth.HealthScreeningFollowUpRecommendation non nullable property
        /// </summary>
        public System.String HealthScreeningFollowUpRecommendation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
