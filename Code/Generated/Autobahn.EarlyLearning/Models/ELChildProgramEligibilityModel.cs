//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildProgramEligibilityModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildProgramEligibility Model
     /// </summary>
    public partial class ELChildProgramEligibilityModel : AutobahnBase, Interfaces.IELChildProgramEligibility
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
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibilityStatus"/> model
        /// </summary>
        public Guid? RefELProgramEligibilityStatusId { get; set; }

        /// <summary>
        /// Early Learning Program Eligibility Status Date
        /// <para>
        /// The date of status of eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20307">Early Learning Program Eligibility Status Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? StatusDate { get; set; }

    }
}
