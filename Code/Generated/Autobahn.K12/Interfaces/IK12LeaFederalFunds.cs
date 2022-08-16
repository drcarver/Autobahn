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
        /// 
        /// </summary>
         FederalProgramsFundingAllocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FundsTransferAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InnovativeDollarsSpent { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? LeaTransferabilityOfFunds { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfImmigrantProgramSubgrants { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefReapAlternativeFundingStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefRlisProgramUseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SchoolImprovementAllocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SchoolImprovementReservedPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SesFundsSpent { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SesPerPupilExpenditure { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SesSchoolChoice20PercentObligation { get; set; }

    }
}
