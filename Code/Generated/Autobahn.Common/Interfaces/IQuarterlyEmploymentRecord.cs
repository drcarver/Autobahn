//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IQuarterlyEmploymentRecord.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IQuarterlyEmploymentRecord
     /// </summary>
    public partial interface IQuarterlyEmploymentRecord
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.Earnings nullable property
        /// </summary>
        System.Decimal? Earnings { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.EmploymentNAICSCode non nullable property
        /// </summary>
        System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.ReferencePeriodStartDate nullable property
        /// </summary>
        System.DateTime? ReferencePeriodStartDate { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.ReferencePeriodEndDate nullable property
        /// </summary>
        System.DateTime? ReferencePeriodEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERAdministrativeDataSource"/> model
        /// </summary>
        Guid? RefERAdministrativeDataSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentLocation"/> model
        /// </summary>
        Guid? RefEmploymentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedPriorToEnrollment"/> model
        /// </summary>
        Guid? RefEmployedPriorToEnrollmentId { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the QuarterlyEmploymentRecord.RecordEndDateTime nullable property
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
