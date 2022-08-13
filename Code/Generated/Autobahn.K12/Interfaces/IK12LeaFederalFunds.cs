//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaFederalFunds.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaFederalFunds Interface
     /// </summary>
    public partial interface IK12LeaFederalFunds : IAutobahnBase
    {
        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        System.Decimal? InnovativeDollarsSpent { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        System.Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        System.Decimal? InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        System.Decimal? ParentalInvolvementReservationFunds { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        System.Decimal? PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        Guid? RefRlisProgramUseId { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        System.Decimal? SesFundsSpent { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        System.Decimal? SesSchoolChoice20PercentObligation { get; set; }

    }
}
