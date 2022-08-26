//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationOperationalStatus Model
     /// </summary>
    public partial class OrganizationOperationalStatusModel : AutobahnBase, IOrganizationOperationalStatus
    {
        /// <summary>
        /// Operation Date
        /// <para>
        /// The year, month and day on which a program or center began operation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19350">Operation Date</a>
        /// </para>
        /// </summary>
        public DateTime? OperationalStatusEffectiveDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Local Education Agency Operational Status
        /// <para>
        /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19174">Local Education Agency Operational Status</a>
        /// </para>
        /// </summary>
        public Guid RefOperationalStatusId { get; set; }

    }
}
