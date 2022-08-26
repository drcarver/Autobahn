//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIndicator Model
     /// </summary>
    public partial class OrganizationIndicatorModel : AutobahnBase, IOrganizationIndicator
    {
        public System.String IndicatorValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Ability Grouping Status
        /// <para>
        /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
        /// </para>
        /// </summary>
        public Guid RefOrganizationIndicatorId { get; set; }

    }
}
