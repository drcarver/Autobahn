//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The PersonHealth Model
     /// </summary>
    public partial class PersonHealthModel : AutobahnBase, Interfaces.IPersonHealth
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
        public System.DateTime DentalScreeningDate { get; set; }

        /// <summary>
        /// Health Screening Equipment Used
        /// <para>
        /// The screening equipment used for the hearing screening or the method used for the vision screening
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20325">Health Screening Equipment Used</a>
        /// </para>
        /// </summary>
        public System.String HealthScreeningEquipmentUsed { get; set; }

        /// <summary>
        /// Health Screening Follow-up Recommendation
        /// <para>
        /// Recommendations for follow-up after a health screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20326">Health Screening Follow-up Recommendation</a>
        /// </para>
        /// </summary>
        public System.String HealthScreeningFollowUpRecommendation { get; set; }

        /// <summary>
        /// Hearing Screening Date
        /// <para>
        /// The year, month and day of a hearing screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19681">Hearing Screening Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? HearingScreeningDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDentalInsuranceCoverageType"/> model
        /// </summary>
        public Guid? RefDentalInsuranceCoverageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDentalScreeningStatus"/> model
        /// </summary>
        public Guid? RefDentalScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefHealthInsuranceCoverage"/> model
        /// </summary>
        public Guid? RefHealthInsuranceCoverageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefHearingScreeningStatus"/> model
        /// </summary>
        public Guid? RefHearingScreeningStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMedicalAlertIndicator"/> model
        /// </summary>
        public Guid? RefMedicalAlertIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefVisionScreeningStatus"/> model
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get; set; }

        /// <summary>
        /// Vision Screening Date
        /// <para>
        /// The year, month and day of a vision screening.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19680">Vision Screening Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? VisionScreeningDate { get; set; }

    }
}
