//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaFederalFundModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12seaFederalFund Model
     /// </summary>
    public partial class K12seaFederalFundModel : IK12seaFederalFund
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IK12seaFederalFund
        public DateTime? DateStateReceivedTitleIiiallocation { get; set; }

        public DateTime? DateTitleIiifundsAvailableToSubgrantees { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
        /// </summary>
        public Guid K12seaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12sea"/> model
        /// </summary>
        public Guid K12seaId { get; set; }

        public Decimal? NumberOfDaysForTitleIiisubgrants { get; set; }

        public Boolean? StateTransferabilityOfFunds { get; set; }

        #endregion
    }
}
