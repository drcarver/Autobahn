//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaFederalFundsModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaFederalFundsModel Interface
     /// </summary>
    public partial interface IK12LeaFederalFundsModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.InnovativeProgramsFundsReceived nullable property
        /// </summary>
        System.Decimal? InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.InnovativeDollarsSpent nullable property
        /// </summary>
        System.Decimal? InnovativeDollarsSpent { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.InnovativeDollarsSpentOnStrategicPriorities nullable property
        /// </summary>
        System.Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.PublicSchoolChoiceFundsSpent nullable property
        /// </summary>
        System.Decimal? PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.SesFundsSpent nullable property
        /// </summary>
        System.Decimal? SesFundsSpent { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.SesSchoolChoice20PercentObligation nullable property
        /// </summary>
        System.Decimal? SesSchoolChoice20PercentObligation { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.ParentalInvolvementReservationFunds nullable property
        /// </summary>
        System.Decimal? ParentalInvolvementReservationFunds { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
        /// </summary>
        Guid? RefRlisProgramUseId { get; set; }

    }
}
