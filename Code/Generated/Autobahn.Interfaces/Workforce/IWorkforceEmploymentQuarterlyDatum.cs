//***************************************************************************
//* DomainName: Workforce Interfaces (used by both models and View Models
//* FileName:   IWorkforceEmploymentQuarterlyDatum.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Workforce
{
     /// <summary>
     /// The IWorkforceEmploymentQuarterlyDatum Interface
     /// </summary>
    public partial interface IWorkforceEmploymentQuarterlyDatum : IAutobahnBase
    {
        Decimal? EmployedInMultipleJobsCount { get; set; }

        Boolean? MilitaryEnlistmentAfterExit { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IWorkforceEmploymentQuarterlyData"/> model
        /// </summary>
        Guid WorkforceEmploymentQuarterlyDataId { get; set; }

    }
}
