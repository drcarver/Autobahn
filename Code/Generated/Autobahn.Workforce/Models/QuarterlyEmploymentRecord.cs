//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   QuarterlyEmploymentRecord.cs
//**********************************************************

using Autobahn.Workforce.Interfaces;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The QuarterlyEmploymentRecord
     /// </summary>
    public partial class QuarterlyEmploymentRecord : IQuarterlyEmploymentRecord
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="QuarterlyEmploymentRecord"/> model
        /// </summary>
        public Guid QuarterlyEmploymentRecordId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.Earnings nullable property
        /// </summary>
        public System.Decimal? Earnings { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code associated with an individual's employment.
        /// </summary>
    public System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.ReferencePeriodStartDate nullable property
        /// </summary>
        public System.DateTime? ReferencePeriodStartDate { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.ReferencePeriodEndDate nullable property
        /// </summary>
        public System.DateTime? ReferencePeriodEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERAdministrativeDataSource"/> model
        /// </summary>
        public Guid? RefERAdministrativeDataSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentLocation"/> model
        /// </summary>
        public Guid? RefEmploymentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedPriorToEnrollment"/> model
        /// </summary>
        public Guid? RefEmployedPriorToEnrollmentId { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.RecordEndDateTime nullable property
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
