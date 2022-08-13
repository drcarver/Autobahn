//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonHealth.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHealth Interface
     /// </summary>
    public partial interface IPersonHealth : IAutobahnBase
    {
        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        System.DateTime DentalScreeningDate { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        System.String HealthScreeningEquipmentUsed { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        System.String HealthScreeningFollowUpRecommendation { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        System.DateTime? HearingScreeningDate { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        Guid? RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        Guid? RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        Guid? RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        Guid? RefHearingScreeningStatusId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        Guid? RefMedicalAlertIndicatorId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        Guid? RefVisionScreeningStatusId { get; set; }

        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        System.DateTime? VisionScreeningDate { get; set; }

    }
}
