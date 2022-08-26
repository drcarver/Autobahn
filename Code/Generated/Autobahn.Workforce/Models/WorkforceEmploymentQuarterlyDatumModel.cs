//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDatumModel.cs
//***************************************************************************

using Autobahn.Interfaces.Workforce;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyDatum Model
     /// </summary>
    public partial class WorkforceEmploymentQuarterlyDatumModel : AutobahnBase, IWorkforceEmploymentQuarterlyDatum
    {
        public Decimal? EmployedInMultipleJobsCount { get; set; }

        public Boolean? MilitaryEnlistmentAfterExit { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IWorkforceEmploymentQuarterlyData"/> model
        /// </summary>
        public Guid WorkforceEmploymentQuarterlyDataId { get; set; }

    }
}
