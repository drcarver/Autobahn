//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12leaFederalFund.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12leaFederalFund Interface
     /// </summary>
    public partial interface IK12leaFederalFund : IAutobahnBase
    {
        Decimal? InnovativeDollarsSpent { get; set; }

        Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        Decimal? InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12leaFederalFunds"/> model
        /// </summary>
        Guid K12leaFederalFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        Guid OrganizationCalendarSessionId { get; set; }

        Decimal? ParentalInvolvementReservationFunds { get; set; }

        Decimal? PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
        /// </summary>
        Guid? RefRlisProgramUseId { get; set; }

        Decimal? SesFundsSpent { get; set; }

        Decimal? SesSchoolChoice20PercentObligation { get; set; }

    }
}
