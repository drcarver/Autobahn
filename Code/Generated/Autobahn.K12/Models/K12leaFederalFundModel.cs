//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalFundModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaFederalFund Model
     /// </summary>
    public partial class K12leaFederalFundModel : AutobahnBase, IK12leaFederalFund
    {
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

    }
}
