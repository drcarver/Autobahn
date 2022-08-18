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
        /// Dental Screening Date
        /// <para>
        /// The year, month and day of a dental screening
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19682">Dental Screening Date</a>
        /// </para>
        /// </summary>
        System.DateTime DentalScreeningDate { get; set; }

        /// <summary>
        /// Health Screening Equipment Used
        /// <para>
        /// The screening equipment used for the hearing screening or the method used for the vision screening
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20325">Health Screening Equipment Used</a>
        /// </para>
        /// </summary>
        System.String HealthScreeningEquipmentUsed { get; set; }

        /// <summary>
        /// Health Screening Follow-up Recommendation
        /// <para>
        /// Recommendations for follow-up after a health screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20326">Health Screening Follow-up Recommendation</a>
        /// </para>
        /// </summary>
        System.String HealthScreeningFollowUpRecommendation { get; set; }

        /// <summary>
        /// Hearing Screening Date
        /// <para>
        /// The year, month and day of a hearing screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19681">Hearing Screening Date</a>
        /// </para>
        /// </summary>
        System.DateTime? HearingScreeningDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalInsuranceCoverageType"/> model
        /// </summary>
        Guid? RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDentalScreeningStatus"/> model
        /// </summary>
        Guid? RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHealthInsuranceCoverage"/> model
        /// </summary>
        Guid? RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHearingScreeningStatus"/> model
        /// </summary>
        Guid? RefHearingScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMedicalAlertIndicator"/> model
        /// </summary>
        Guid? RefMedicalAlertIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisionScreeningStatus"/> model
        /// </summary>
        Guid? RefVisionScreeningStatusId { get; set; }

        /// <summary>
        /// Vision Screening Date
        /// <para>
        /// The year, month and day of a vision screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19680">Vision Screening Date</a>
        /// </para>
        /// </summary>
        System.DateTime? VisionScreeningDate { get; set; }

    }
}
