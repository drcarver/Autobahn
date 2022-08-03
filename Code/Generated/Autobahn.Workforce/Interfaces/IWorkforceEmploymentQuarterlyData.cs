//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   IWorkforceEmploymentQuarterlyData.cs
//**********************************************************

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceEmploymentQuarterlyData
     /// </summary>
    public partial interface IWorkforceEmploymentQuarterlyData
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the WorkforceEmploymentQuarterlyData.EmployedInMultipleJobsCount nullable property
        /// </summary>
        System.Decimal? EmployedInMultipleJobsCount { get; set; }

        /// <summary>
        /// Defines the WorkforceEmploymentQuarterlyData.MilitaryEnlistmentAfterExit nullable property
        /// </summary>
        System.Boolean? MilitaryEnlistmentAfterExit { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// Defines the WorkforceEmploymentQuarterlyData.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the WorkforceEmploymentQuarterlyData.RecordEndDateTime nullable property
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
