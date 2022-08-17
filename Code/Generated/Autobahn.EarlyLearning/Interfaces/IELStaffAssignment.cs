//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELStaffAssignment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffAssignment Interface
     /// </summary>
    public partial interface IELStaffAssignment : IAutobahnBase
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
        System.Boolean ItinerantProvider { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
