//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12FederalFundAllocationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12FederalFundAllocationViewModel
     /// </summary>
    public partial class K12FederalFundAllocationViewModel : BindableBase, IK12FederalFundAllocation
    {
#region "Backing Fields"
        // member variable for the FederalProgramCode property
        private System.String _FederalProgramCode;

        // member variable for the FederalProgramsFundingAllocation property
        private System.Decimal? _FederalProgramsFundingAllocation;

        // member variable for the FundsTransferAmount property
        private System.Decimal? _FundsTransferAmount;

        // member variable for the SchoolImprovementAllocation property
        private System.Decimal? _SchoolImprovementAllocation;

        // member variable for the LeaTransferabilityOfFunds property
        private System.Boolean? _LeaTransferabilityOfFunds;

        // member variable for the SchoolImprovementReservedPercent property
        private System.Decimal? _SchoolImprovementReservedPercent;

        // member variable for the SesPerPupilExpenditure property
        private System.Decimal? _SesPerPupilExpenditure;

        // member variable for the NumberOfImmigrantProgramSubgrants property
        private System.Int32? _NumberOfImmigrantProgramSubgrants;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

        public System.String FederalProgramCode  { get => _FederalProgramCode; set => SetProperty(ref _FederalProgramCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationTypeId"/> model
        /// </summary>
        public Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

        public System.Decimal? FederalProgramsFundingAllocation { get => _FederalProgramsFundingAllocation; set => SetProperty(ref _FederalProgramsFundingAllocation, value); }

        public System.Decimal? FundsTransferAmount { get => _FundsTransferAmount; set => SetProperty(ref _FundsTransferAmount, value); }

        public System.Decimal? SchoolImprovementAllocation { get => _SchoolImprovementAllocation; set => SetProperty(ref _SchoolImprovementAllocation, value); }

        public System.Boolean? LeaTransferabilityOfFunds { get => _LeaTransferabilityOfFunds; set => SetProperty(ref _LeaTransferabilityOfFunds, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaFundsTransferTypeId"/> model
        /// </summary>
        public Guid? RefLeaFundsTransferTypeId { get; set; }

        public System.Decimal? SchoolImprovementReservedPercent { get => _SchoolImprovementReservedPercent; set => SetProperty(ref _SchoolImprovementReservedPercent, value); }

        public System.Decimal? SesPerPupilExpenditure { get => _SesPerPupilExpenditure; set => SetProperty(ref _SesPerPupilExpenditure, value); }

        public System.Int32? NumberOfImmigrantProgramSubgrants { get => _NumberOfImmigrantProgramSubgrants; set => SetProperty(ref _NumberOfImmigrantProgramSubgrants, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatusId"/> model
        /// </summary>
        public Guid? RefReapAlternativeFundingStatusId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IK12FederalFundAllocation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            FederalProgramCode = model.FederalProgramCode;
            RefFederalProgramFundingAllocationTypeId = model.RefFederalProgramFundingAllocationTypeId;
            FederalProgramsFundingAllocation = model.FederalProgramsFundingAllocation;
            FundsTransferAmount = model.FundsTransferAmount;
            SchoolImprovementAllocation = model.SchoolImprovementAllocation;
            LeaTransferabilityOfFunds = model.LeaTransferabilityOfFunds;
            RefLeaFundsTransferTypeId = model.RefLeaFundsTransferTypeId;
            SchoolImprovementReservedPercent = model.SchoolImprovementReservedPercent;
            SesPerPupilExpenditure = model.SesPerPupilExpenditure;
            NumberOfImmigrantProgramSubgrants = model.NumberOfImmigrantProgramSubgrants;
            RefReapAlternativeFundingStatusId = model.RefReapAlternativeFundingStatusId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
