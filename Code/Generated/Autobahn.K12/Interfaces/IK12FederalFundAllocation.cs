//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12FederalFundAllocation.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12FederalFundAllocation
     /// </summary>
    public partial interface IK12FederalFundAllocation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        Guid OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.FederalProgramCode non nullable property
        /// </summary>
        System.String FederalProgramCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
        /// </summary>
        Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.FederalProgramsFundingAllocation nullable property
        /// </summary>
        System.Decimal? FederalProgramsFundingAllocation { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.FundsTransferAmount nullable property
        /// </summary>
        System.Decimal? FundsTransferAmount { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.SchoolImprovementAllocation nullable property
        /// </summary>
        System.Decimal? SchoolImprovementAllocation { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.LeaTransferabilityOfFunds nullable property
        /// </summary>
        System.Boolean? LeaTransferabilityOfFunds { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
        /// </summary>
        Guid? RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.SchoolImprovementReservedPercent nullable property
        /// </summary>
        System.Decimal? SchoolImprovementReservedPercent { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.SesPerPupilExpenditure nullable property
        /// </summary>
        System.Decimal? SesPerPupilExpenditure { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.NumberOfImmigrantProgramSubgrants nullable property
        /// </summary>
        System.Int32? NumberOfImmigrantProgramSubgrants { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
        /// </summary>
        Guid? RefReapAlternativeFundingStatusId { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12FederalFundAllocation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
