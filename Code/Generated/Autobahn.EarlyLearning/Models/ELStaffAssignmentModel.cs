//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffAssignmentModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The ELStaffAssignment Model
     /// </summary>
    public partial class ELStaffAssignmentModel : AutobahnBase, Interfaces.IELStaffAssignment
    {
        /// <summary>
        /// Itinerant Provider
        /// <para>
        /// An indication of whether a person provides services at more than one site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20353">Itinerant Provider</a>
        /// </para>
        /// </summary>
        public System.Boolean ItinerantProvider { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
