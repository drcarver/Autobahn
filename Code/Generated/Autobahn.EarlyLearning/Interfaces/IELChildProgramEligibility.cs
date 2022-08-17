//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildProgramEligibility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildProgramEligibility Interface
     /// </summary>
    public partial interface IELChildProgramEligibility : IAutobahnBase
    {
        /// <summary>
        /// Early Learning Program Eligibility Expiration Date
        /// <para>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20305">Early Learning Program Eligibility Expiration Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELProgramEligibilityStatus"/> model
        /// </summary>
        Guid? RefELProgramEligibilityStatusId { get; set; }

        /// <summary>
        /// Early Learning Program Eligibility Status Date
        /// <para>
        /// The date of status of eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20307">Early Learning Program Eligibility Status Date</a>
        /// </para>
        /// </summary>
        System.DateTime? StatusDate { get; set; }

    }
}
