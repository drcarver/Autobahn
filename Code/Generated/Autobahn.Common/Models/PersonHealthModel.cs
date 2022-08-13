//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHealth Model
     /// </summary>
    public partial class PersonHealthModel : AutobahnBase, Interfaces.IPersonHealth
    {
        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.DateTime DentalScreeningDate { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.String HealthScreeningEquipmentUsed { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.String HealthScreeningFollowUpRecommendation { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.DateTime? HearingScreeningDate { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public Guid? RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public Guid? RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public Guid? RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public Guid? RefHearingScreeningStatusId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public Guid? RefMedicalAlertIndicatorId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public System.DateTime? VisionScreeningDate { get; set; }

    }
}
