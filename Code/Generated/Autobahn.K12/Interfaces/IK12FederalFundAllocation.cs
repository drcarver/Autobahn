//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12FederalFundAllocation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12FederalFundAllocation Interface
     /// </summary>
    public partial interface IK12FederalFundAllocation : IAutobahnBase
    {
        System.String FederalProgramCode { get; set; }

        System.Decimal? FederalProgramsFundingAllocation { get; set; }

        System.Decimal? FundsTransferAmount { get; set; }

        System.Boolean? LeaTransferabilityOfFunds { get; set; }

        System.Int32? NumberOfImmigrantProgramSubgrants { get; set; }

        /// <summary>
        /// Session Attendance Term Indicator
        /// <para>
        /// Indicates that the session is an attendance term.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20240">Session Attendance Term Indicator</a>
        /// </para>
        /// </summary>
        Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFederalProgramFundingAllocationType"/> model
        /// </summary>
        Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLeaFundsTransferType"/> model
        /// </summary>
        Guid? RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefReapAlternativeFundingStatus"/> model
        /// </summary>
        Guid? RefReapAlternativeFundingStatusId { get; set; }

        System.Decimal? SchoolImprovementAllocation { get; set; }

        System.Decimal? SchoolImprovementReservedPercent { get; set; }

        System.Decimal? SesPerPupilExpenditure { get; set; }

    }
}
