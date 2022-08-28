//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalFundModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12leaFederalFund Model
     /// </summary>
    public partial class K12leaFederalFundModel : IK12leaFederalFund
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

        #region IK12leaFederalFund
        public Decimal? InnovativeDollarsSpent { get; set; }

        public Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        public Decimal? InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12leaFederalFunds"/> model
        /// </summary>
        public Guid K12leaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        public Decimal? ParentalInvolvementReservationFunds { get; set; }

        public Decimal? PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
        /// </summary>
        public Guid? RefRlisProgramUseId { get; set; }

        public Decimal? SesFundsSpent { get; set; }

        public Decimal? SesSchoolChoice20PercentObligation { get; set; }

        #endregion
    }
}
