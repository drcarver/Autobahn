//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   IWorkforceEmploymentQuarterlyDataModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceEmploymentQuarterlyDataModel Interface
     /// </summary>
    public partial interface IWorkforceEmploymentQuarterlyDataModel : IAutobahnBase
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

    }
}
