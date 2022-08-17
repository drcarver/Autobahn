//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildService Interface
     /// </summary>
    public partial interface IELChildService : IAutobahnBase
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
        System.Boolean? ECEAPEligibility { get; set; }

        /// <summary>
        /// Eligibility Priority Points
        /// <para>
        /// Priority points used to determine eligibility and placement order
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20597">Eligibility Priority Points</a>
        /// </para>
        /// </summary>
        System.String EligibilityPriorityPoints { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEarlyChildhoodServicesOffered"/> model
        /// </summary>
        Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEarlyChildhoodServicesReceived"/> model
        /// </summary>
        Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELServiceType"/> model
        /// </summary>
        Guid? RefELServiceTypeId { get; set; }

        /// <summary>
        /// Service Date
        /// <para>
        /// The year, month, and day on which a service was provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20616">Service Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ServiceDate { get; set; }

    }
}
