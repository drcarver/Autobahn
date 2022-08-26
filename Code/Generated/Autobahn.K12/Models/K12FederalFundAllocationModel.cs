//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12federalFundAllocationModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12federalFundAllocation Model
     /// </summary>
    public partial class K12federalFundAllocationModel : AutobahnBase, IK12federalFundAllocation
    {
        public System.String FederalProgramCode { get; set; }

        public Decimal? FederalProgramsFundingAllocation { get; set; }

        public Decimal? FundsTransferAmount { get; set; }

        public Boolean? LeaTransferabilityOfFunds { get; set; }

        public Int32? NumberOfImmigrantProgramSubgrants { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
        /// </summary>
        public Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
        /// </summary>
        public Guid? RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
        /// </summary>
        public Guid? RefReapAlternativeFundingStatusId { get; set; }

        public Decimal? SchoolImprovementAllocation { get; set; }

        public Decimal? SchoolImprovementReservedPercent { get; set; }

        public Decimal? SesPerPupilExpenditure { get; set; }

    }
}
