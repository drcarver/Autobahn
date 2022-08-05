//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   QuarterlyEmploymentRecord.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The QuarterlyEmploymentRecord
     /// </summary>
    public partial class QuarterlyEmploymentRecord : AutobahnBase, Interfaces.IQuarterlyEmploymentRecord
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.Earnings nullable property
        /// </summary>
        public System.Decimal? Earnings { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.EmploymentNAICSCode non nullable property
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
