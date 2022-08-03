//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceEmploymentQuarterlyData.cs
//**********************************************************

using Autobahn.Workforce.Interfaces;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyData
     /// </summary>
    public partial class WorkforceEmploymentQuarterlyData : IWorkforceEmploymentQuarterlyData
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the WorkforceEmploymentQuarterlyData.EmployedInMultipleJobsCount nullable property
        /// </summary>
        public System.Decimal? EmployedInMultipleJobsCount { get; set; }

        /// <summary>
        /// Defines the WorkforceEmploymentQuarterlyData.MilitaryEnlistmentAfterExit nullable property
        /// </summary>
        public System.Boolean? MilitaryEnlistmentAfterExit { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// Defines the WorkforceEmploymentQuarterlyData.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the WorkforceEmploymentQuarterlyData.RecordEndDateTime nullable property
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
