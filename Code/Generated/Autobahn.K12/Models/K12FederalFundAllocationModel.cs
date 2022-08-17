//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12FederalFundAllocationModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The K12FederalFundAllocation Model
     /// </summary>
    public partial class K12FederalFundAllocationModel : AutobahnBase, Interfaces.IK12FederalFundAllocation
    {
        public System.String FederalProgramCode { get; set; }

        public System.Decimal? FederalProgramsFundingAllocation { get; set; }

        public System.Decimal? FundsTransferAmount { get; set; }

        public System.Boolean? LeaTransferabilityOfFunds { get; set; }

        public System.Int32? NumberOfImmigrantProgramSubgrants { get; set; }

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

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFederalProgramFundingAllocationType"/> model
        /// </summary>
        public Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLeaFundsTransferType"/> model
        /// </summary>
        public Guid? RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefReapAlternativeFundingStatus"/> model
        /// </summary>
        public Guid? RefReapAlternativeFundingStatusId { get; set; }

        public System.Decimal? SchoolImprovementAllocation { get; set; }

        public System.Decimal? SchoolImprovementReservedPercent { get; set; }

        public System.Decimal? SesPerPupilExpenditure { get; set; }

    }
}
