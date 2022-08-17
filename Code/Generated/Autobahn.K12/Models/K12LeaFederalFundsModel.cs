//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalFundsModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The K12LeaFederalFunds Model
     /// </summary>
    public partial class K12LeaFederalFundsModel : AutobahnBase, Interfaces.IK12LeaFederalFunds
    {
        /// <summary>
        /// Federal Programs Funding Allocation
        /// <para>
        /// The amount of federal dollars distributed to local education agencies (LEAs), retained by the state education agency (SEA) for program administration or other approved state-level activities (including unallocated, transferred to another state agency, or distributed to entities other than LEAs).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19540">Federal Programs Funding Allocation</a>
        /// </para>
        /// </summary>
        public  FederalProgramsFundingAllocation { get; set; }

        /// <summary>
        /// Funds Transfer Amount
        /// <para>
        /// The total amount of FY appropriated funds transferred from and to each eligible program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19442">Funds Transfer Amount</a>
        /// </para>
        /// </summary>
        public  FundsTransferAmount { get; set; }

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
        /// Local Education Agency Transferability of Funds
        /// <para>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19436">Local Education Agency Transferability of Funds</a>
        /// </para>
        /// </summary>
        public  LeaTransferabilityOfFunds { get; set; }

        /// <summary>
        /// Number of Immigrant Program Subgrants
        /// <para>
        /// The number of immigrant program [3114(d)(1)] subgrants.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19460">Number of Immigrant Program Subgrants</a>
        /// </para>
        /// </summary>
        public  NumberOfImmigrantProgramSubgrants { get; set; }

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
        /// Reference to an optional instance of the <see cref="IRefFederalProgramFundingAllocationType"/> model
        /// </summary>
        public  RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLeaFundsTransferType"/> model
        /// </summary>
        public  RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefReapAlternativeFundingStatus"/> model
        /// </summary>
        public  RefReapAlternativeFundingStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefRlisProgramUse"/> model
        /// </summary>
        public Guid? RefRlisProgramUseId { get; set; }

        /// <summary>
        /// School Improvement Allocation
        /// <para>
        /// The amount of Section 1003(a) and 1003(g) allocations to LEAs and Schools.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19471">School Improvement Allocation</a>
        /// </para>
        /// </summary>
        public  SchoolImprovementAllocation { get; set; }

        /// <summary>
        /// School Improvement Reserved Funds Percentage
        /// <para>
        /// An indication of the percentage of the Title I, Part A allocation that the SEA reserved in accordance with Section 1003(a) of ESEA and 200.100(a) of ED's regulations governing the reservation of funds for school improvement under Section 1003(a) of ESEA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19470">School Improvement Reserved Funds Percentage</a>
        /// </para>
        /// </summary>
        public  SchoolImprovementReservedPercent { get; set; }

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
        /// Supplemental Educational Services Per Pupil Expenditure
        /// <para>
        /// The maximum dollar amount that may be spent per child for expenditures related to supplemental educational services under Title I of the ESEA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19567">Supplemental Educational Services Per Pupil Expenditure</a>
        /// </para>
        /// </summary>
        public  SesPerPupilExpenditure { get; set; }

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
