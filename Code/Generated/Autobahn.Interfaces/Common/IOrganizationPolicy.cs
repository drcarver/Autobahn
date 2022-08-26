//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPolicy.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationPolicy Interface
     /// </summary>
    public partial interface IOrganizationPolicy : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Personnel Policy Type
        /// <para>
        /// Policies related to personnel in the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19842">Personnel Policy Type</a>
        /// </para>
        /// </summary>
        System.String PolicyType { get; set; }

        System.String Value { get; set; }

    }
}
