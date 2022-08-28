//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12federalFundAllocation.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12federalFundAllocation Interface
     /// </summary>
    public partial interface IK12federalFundAllocation : IAutobahnBase
    {
        #region IK12federalFundAllocation
        System.String FederalProgramCode { get; set; }

        Decimal? FederalProgramsFundingAllocation { get; set; }

        Decimal? FundsTransferAmount { get; set; }

        Boolean? LeaTransferabilityOfFunds { get; set; }

        Int32? NumberOfImmigrantProgramSubgrants { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
        /// </summary>
        Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
        /// </summary>
        Guid? RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
        /// </summary>
        Guid? RefReapAlternativeFundingStatusId { get; set; }

        Decimal? SchoolImprovementAllocation { get; set; }

        Decimal? SchoolImprovementReservedPercent { get; set; }

        Decimal? SesPerPupilExpenditure { get; set; }

        #endregion
    }
}
