//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundsModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SeaFederalFunds Model
     /// </summary>
    public partial class K12SeaFederalFundsModel : AutobahnBase, Interfaces.IK12SeaFederalFunds
    {
        /// <summary>
        /// Date State Received Title III Allocation
        /// <para>
        /// Annual date the State receives the Title III allocation from U.S. Department of Education (ED).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19445">Date State Received Title III Allocation</a>
        /// </para>
        /// </summary>
        public System.DateTime? DateStateReceivedTitleIIIAllocation { get; set; }

        /// <summary>
        /// Date Title III Funds Available to Subgrantees
        /// <para>
        /// Annual date that Title III funds are available to approved subgrantees.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19446">Date Title III Funds Available to Subgrantees</a>
        /// </para>
        /// </summary>
        public System.DateTime? DateTitleIIIFundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12Sea"/> model
        /// </summary>
        public Guid K12SeaId { get; set; }

        /// <summary>
        /// Number of Days for Title III Subgrants
        /// <para>
        /// Average number of days for States receiving Title III funds to make subgrants to subgrantees beginning from July 1 of each year, except under conditions where funds are being withheld.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19447">Number of Days for Title III Subgrants</a>
        /// </para>
        /// </summary>
        public System.Decimal? NumberOfDaysForTitleIIISubgrants { get; set; }

        /// <summary>
        /// State Transferability of Funds
        /// <para>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19435">State Transferability of Funds</a>
        /// </para>
        /// </summary>
        public System.Boolean? StateTransferabilityOfFunds { get; set; }

    }
}
