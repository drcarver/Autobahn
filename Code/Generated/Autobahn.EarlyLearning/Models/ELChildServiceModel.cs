//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServiceModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildService Model
     /// </summary>
    public partial class ELChildServiceModel : AutobahnBase, Interfaces.IELChildService
    {
        /// <summary>
        /// Early Childhood Education and Assistance Program Eligibility
        /// <para>
        /// Denotes whether the family member can receive Early Childhood Education and Assistance Program (ECEAP) information for the child in question.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20570">Early Childhood Education and Assistance Program Eligibility</a>
        /// </para>
        /// </summary>
        public System.Boolean? ECEAPEligibility { get; set; }

        /// <summary>
        /// Eligibility Priority Points
        /// <para>
        /// Priority points used to determine eligibility and placement order
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20597">Eligibility Priority Points</a>
        /// </para>
        /// </summary>
        public System.String EligibilityPriorityPoints { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesOffered"/> model
        /// </summary>
        public Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceived"/> model
        /// </summary>
        public Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELServiceType"/> model
        /// </summary>
        public Guid? RefELServiceTypeId { get; set; }

        /// <summary>
        /// Service Date
        /// <para>
        /// The year, month, and day on which a service was provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20616">Service Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ServiceDate { get; set; }

    }
}
