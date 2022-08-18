//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELServicePartnerModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELServicePartner Model
     /// </summary>
    public partial class ELServicePartnerModel : AutobahnBase, Interfaces.IELServicePartner
    {
        /// <summary>
        /// Memorandum of Understanding End Date
        /// <para>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20593">Memorandum of Understanding End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingEndDate { get; set; }

        /// <summary>
        /// Memorandum of Understanding Start Date
        /// <para>
        /// The effective date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner Organization is effective.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20594">Memorandum of Understanding Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? MemorandumOfUnderstandingStartDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Service Partner Description
        /// <para>
        /// A description of the type of services that the partner organization provides.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20603">Service Partner Description</a>
        /// </para>
        /// </summary>
        public System.String ServicePartnerDescription { get; set; }

        /// <summary>
        /// Service Partner Name
        /// <para>
        /// The name of a non-person entity such as an organization, institution, agency or business, that partners with the Early Learning Organization to provide services to enrolled children/families.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20606">Service Partner Name</a>
        /// </para>
        /// </summary>
        public System.String ServicePartnerName { get; set; }

    }
}
