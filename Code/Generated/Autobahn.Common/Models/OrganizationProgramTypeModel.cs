//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationProgramType Model
     /// </summary>
    public partial class OrganizationProgramTypeModel : AutobahnBase, IOrganizationProgramType
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Program Type
        /// <para>
        /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19225">Program Type</a>
        /// </para>
        /// </summary>
        public Guid RefProgramTypeId { get; set; }

    }
}
