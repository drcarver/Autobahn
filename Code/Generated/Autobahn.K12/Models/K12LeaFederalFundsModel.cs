//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalFundsModel.cs
//***************************************************************************

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
        /// Innovative Dollars Spent
        /// <para>
        /// The total Title V, Part A funds expended by LEAs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19451">Innovative Dollars Spent</a>
        /// </para>
        /// </summary>
        public System.Decimal? InnovativeDollarsSpent { get; set; }

        /// <summary>
        /// Innovative Dollars Spent on Strategic Priorities
        /// <para>
        /// The total amount of Title V, Part A funds expended by LEAs for the four strategic priorities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19452">Innovative Dollars Spent on Strategic Priorities</a>
        /// </para>
        /// </summary>
        public System.Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        /// <summary>
        /// Innovative Programs Funds Received
        /// <para>
        /// The total Title V, Part A funds received by LEAs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19454">Innovative Programs Funds Received</a>
        /// </para>
        /// </summary>
        public System.Decimal? InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// Session Attendance Term Indicator
        /// <para>
        /// Indicates that the session is an attendance term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20240">Session Attendance Term Indicator</a>
        /// </para>
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        public System.Decimal? ParentalInvolvementReservationFunds { get; set; }

        /// <summary>
        /// Public School Choice Funds Spent
        /// <para>
        /// The dollar amount spent on transportation for public school choice during the school year under Title I of ESEA as amended, Part A, Section 1116.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19560">Public School Choice Funds Spent</a>
        /// </para>
        /// </summary>
        public System.Decimal? PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
        /// </summary>
        public Guid? RefRlisProgramUseId { get; set; }

        /// <summary>
        /// Supplemental Educational Services Funds Spent
        /// <para>
        /// The dollar amount spent on supplemental educational services during the school year under Title I, Part A, Section 1116 of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19559">Supplemental Educational Services Funds Spent</a>
        /// </para>
        /// </summary>
        public System.Decimal? SesFundsSpent { get; set; }

        /// <summary>
        /// Supplemental Education Services Public School Choice Twenty Percent Obligation
        /// <para>
        /// The dollar amount of the 20 percent reservation for supplemental educational services and choice-related transportation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19566">Supplemental Education Services Public School Choice Twenty Percent Obligation</a>
        /// </para>
        /// </summary>
        public System.Decimal? SesSchoolChoice20PercentObligation { get; set; }

    }
}
