//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12FederalFundAllocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12FederalFundAllocation Model
     /// </summary>
    public partial class K12FederalFundAllocationModel : AutobahnBase, Interfaces.IK12FederalFundAllocationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.FederalProgramCode non nullable property
        /// </summary>
        public System.String FederalProgramCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
        /// </summary>
        public Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.FederalProgramsFundingAllocation nullable property
        /// </summary>
        public System.Decimal? FederalProgramsFundingAllocation { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.FundsTransferAmount nullable property
        /// </summary>
        public System.Decimal? FundsTransferAmount { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.SchoolImprovementAllocation nullable property
        /// </summary>
        public System.Decimal? SchoolImprovementAllocation { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.LeaTransferabilityOfFunds nullable property
        /// </summary>
        public System.Boolean? LeaTransferabilityOfFunds { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
        /// </summary>
        public Guid? RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.SchoolImprovementReservedPercent nullable property
        /// </summary>
        public System.Decimal? SchoolImprovementReservedPercent { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.SesPerPupilExpenditure nullable property
        /// </summary>
        public System.Decimal? SesPerPupilExpenditure { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.NumberOfImmigrantProgramSubgrants nullable property
        /// </summary>
        public System.Int32? NumberOfImmigrantProgramSubgrants { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
        /// </summary>
        public Guid? RefReapAlternativeFundingStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
