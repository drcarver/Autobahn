//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SeaFederalFunds.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SeaFederalFunds Interface
     /// </summary>
    public partial interface IK12SeaFederalFunds : IAutobahnBase
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
        System.DateTime? DateStateReceivedTitleIIIAllocation { get; set; }

        /// <summary>
        /// Date Title III Funds Available to Subgrantees
        /// <para>
        /// Annual date that Title III funds are available to approved subgrantees.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19446">Date Title III Funds Available to Subgrantees</a>
        /// </para>
        /// </summary>
        System.DateTime? DateTitleIIIFundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12Sea"/> model
        /// </summary>
        Guid K12SeaId { get; set; }

        /// <summary>
        /// Number of Days for Title III Subgrants
        /// <para>
        /// Average number of days for States receiving Title III funds to make subgrants to subgrantees beginning from July 1 of each year, except under conditions where funds are being withheld.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19447">Number of Days for Title III Subgrants</a>
        /// </para>
        /// </summary>
        System.Decimal? NumberOfDaysForTitleIIISubgrants { get; set; }

        /// <summary>
        /// State Transferability of Funds
        /// <para>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19435">State Transferability of Funds</a>
        /// </para>
        /// </summary>
        System.Boolean? StateTransferabilityOfFunds { get; set; }

    }
}
