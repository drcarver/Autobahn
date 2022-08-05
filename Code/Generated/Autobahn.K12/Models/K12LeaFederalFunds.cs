//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaFederalFunds.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaFederalFunds
     /// </summary>
    public partial class K12LeaFederalFunds : AutobahnBase, Interfaces.IK12LeaFederalFunds
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.InnovativeProgramsFundsReceived nullable property
        /// </summary>
        public System.Decimal? InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.InnovativeDollarsSpent nullable property
        /// </summary>
        public System.Decimal? InnovativeDollarsSpent { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.InnovativeDollarsSpentOnStrategicPriorities nullable property
        /// </summary>
        public System.Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.PublicSchoolChoiceFundsSpent nullable property
        /// </summary>
        public System.Decimal? PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.SesFundsSpent nullable property
        /// </summary>
        public System.Decimal? SesFundsSpent { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.SesSchoolChoice20PercentObligation nullable property
        /// </summary>
        public System.Decimal? SesSchoolChoice20PercentObligation { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalFunds.ParentalInvolvementReservationFunds nullable property
        /// </summary>
        public System.Decimal? ParentalInvolvementReservationFunds { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
        /// </summary>
        public Guid? RefRlisProgramUseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
