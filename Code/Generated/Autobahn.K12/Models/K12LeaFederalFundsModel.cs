//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalFundsModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaFederalFunds Model
     /// </summary>
    public partial class K12LeaFederalFundsModel : AutobahnBase, Interfaces.IK12LeaFederalFunds
    {
        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? InnovativeDollarsSpent { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? ParentalInvolvementReservationFunds { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public Guid? RefRlisProgramUseId { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? SesFundsSpent { get; set; }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? SesSchoolChoice20PercentObligation { get; set; }

    }
}
