//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12federalFundAllocationModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12federalFundAllocation Model
     /// </summary>
    public partial class K12federalFundAllocationModel : IK12federalFundAllocation
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IK12federalFundAllocation
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

        #endregion
    }
}
