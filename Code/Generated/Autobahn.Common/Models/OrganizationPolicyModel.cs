//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPolicyModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPolicy Model
     /// </summary>
    public partial class OrganizationPolicyModel : AutobahnBase, Interfaces.IOrganizationPolicy
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Personnel Policy Type
        /// <para>
        /// Policies related to personnel in the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19842">Personnel Policy Type</a>
        /// </para>
        /// </summary>
        public System.String PolicyType { get; set; }

        public System.String Value { get; set; }

    }
}
