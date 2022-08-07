//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyData Model
     /// </summary>
    public partial class WorkforceEmploymentQuarterlyDataModel : AutobahnBase, Interfaces.IWorkforceEmploymentQuarterlyDataModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
