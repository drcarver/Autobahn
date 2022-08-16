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
        /// 
        /// </summary>
        public  FederalProgramsFundingAllocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FundsTransferAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InnovativeDollarsSpent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InnovativeDollarsSpentOnStrategicPriorities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InnovativeProgramsFundsReceived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? LeaTransferabilityOfFunds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfImmigrantProgramSubgrants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PublicSchoolChoiceFundsSpent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFederalProgramFundingAllocationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLeaFundsTransferTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefReapAlternativeFundingStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefRlisProgramUseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SchoolImprovementAllocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SchoolImprovementReservedPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SesFundsSpent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SesPerPupilExpenditure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SesSchoolChoice20PercentObligation { get; set; }

    }
}
