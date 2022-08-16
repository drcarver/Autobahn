//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalFundsViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalFundsViewModel
     /// </summary>
    public partial class K12LeaFederalFundsViewModel : ViewModelBase, Interfaces.IK12LeaFederalFunds
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaFederalFunds";

        // member variable for the FederalProgramsFundingAllocation property
        private  _FederalProgramsFundingAllocation;

        // member variable for the FundsTransferAmount property
        private  _FundsTransferAmount;

        // member variable for the InnovativeDollarsSpent property
        private  _InnovativeDollarsSpent;

        // member variable for the InnovativeDollarsSpentOnStrategicPriorities property
        private  _InnovativeDollarsSpentOnStrategicPriorities;

        // member variable for the InnovativeProgramsFundsReceived property
        private  _InnovativeProgramsFundsReceived;

        // member variable for the LeaTransferabilityOfFunds property
        private Guid? _LeaTransferabilityOfFunds;

        // member variable for the NumberOfImmigrantProgramSubgrants property
        private  _NumberOfImmigrantProgramSubgrants;

        // member variable for the PublicSchoolChoiceFundsSpent property
        private  _PublicSchoolChoiceFundsSpent;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFederalProgramFundingAllocationTypeId property
        private  _RefFederalProgramFundingAllocationTypeId;

        // member variable for the RefLeaFundsTransferTypeId property
        private  _RefLeaFundsTransferTypeId;

        // member variable for the RefReapAlternativeFundingStatusId property
        private  _RefReapAlternativeFundingStatusId;

        // member variable for the RefRlisProgramUseId property
        private  _RefRlisProgramUseId;

        // member variable for the SchoolImprovementAllocation property
        private  _SchoolImprovementAllocation;

        // member variable for the SchoolImprovementReservedPercent property
        private  _SchoolImprovementReservedPercent;

        // member variable for the SesFundsSpent property
        private  _SesFundsSpent;

        // member variable for the SesPerPupilExpenditure property
        private  _SesPerPupilExpenditure;

        // member variable for the SesSchoolChoice20PercentObligation property
        private  _SesSchoolChoice20PercentObligation;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FederalProgramsFundingAllocation { get => _FederalProgramsFundingAllocation; set => SetProperty(ref _FederalProgramsFundingAllocation, value); }

        /// <summary>
        /// </summary>
        public  FundsTransferAmount { get => _FundsTransferAmount; set => SetProperty(ref _FundsTransferAmount, value); }

        /// <summary>
        /// </summary>
        public  InnovativeDollarsSpent { get => _InnovativeDollarsSpent; set => SetProperty(ref _InnovativeDollarsSpent, value); }

        /// <summary>
        /// </summary>
        public  InnovativeDollarsSpentOnStrategicPriorities { get => _InnovativeDollarsSpentOnStrategicPriorities; set => SetProperty(ref _InnovativeDollarsSpentOnStrategicPriorities, value); }

        /// <summary>
        /// </summary>
        public  InnovativeProgramsFundsReceived { get => _InnovativeProgramsFundsReceived; set => SetProperty(ref _InnovativeProgramsFundsReceived, value); }

        /// <summary>
        /// </summary>
        public Guid? LeaTransferabilityOfFunds { get => _LeaTransferabilityOfFunds; set => SetProperty(ref _LeaTransferabilityOfFunds, value); }

        /// <summary>
        /// </summary>
        public  NumberOfImmigrantProgramSubgrants { get => _NumberOfImmigrantProgramSubgrants; set => SetProperty(ref _NumberOfImmigrantProgramSubgrants, value); }

        /// <summary>
        /// </summary>
        public  PublicSchoolChoiceFundsSpent { get => _PublicSchoolChoiceFundsSpent; set => SetProperty(ref _PublicSchoolChoiceFundsSpent, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
        /// </summary>
        public  RefFederalProgramFundingAllocationTypeId { get => _RefFederalProgramFundingAllocationTypeId; set => SetProperty(ref _RefFederalProgramFundingAllocationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
        /// </summary>
        public  RefLeaFundsTransferTypeId { get => _RefLeaFundsTransferTypeId; set => SetProperty(ref _RefLeaFundsTransferTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
        /// </summary>
        public  RefReapAlternativeFundingStatusId { get => _RefReapAlternativeFundingStatusId; set => SetProperty(ref _RefReapAlternativeFundingStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
        /// </summary>
        public  RefRlisProgramUseId { get => _RefRlisProgramUseId; set => SetProperty(ref _RefRlisProgramUseId, value); }

        /// <summary>
        /// </summary>
        public  SchoolImprovementAllocation { get => _SchoolImprovementAllocation; set => SetProperty(ref _SchoolImprovementAllocation, value); }

        /// <summary>
        /// </summary>
        public  SchoolImprovementReservedPercent { get => _SchoolImprovementReservedPercent; set => SetProperty(ref _SchoolImprovementReservedPercent, value); }

        /// <summary>
        /// </summary>
        public  SesFundsSpent { get => _SesFundsSpent; set => SetProperty(ref _SesFundsSpent, value); }

        /// <summary>
        /// </summary>
        public  SesPerPupilExpenditure { get => _SesPerPupilExpenditure; set => SetProperty(ref _SesPerPupilExpenditure, value); }

        /// <summary>
        /// </summary>
        public  SesSchoolChoice20PercentObligation { get => _SesSchoolChoice20PercentObligation; set => SetProperty(ref _SesSchoolChoice20PercentObligation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            FederalProgramsFundingAllocation = model.FederalProgramsFundingAllocation; // 
            FundsTransferAmount = model.FundsTransferAmount; // 
            InnovativeDollarsSpent = model.InnovativeDollarsSpent; // 
            InnovativeDollarsSpentOnStrategicPriorities = model.InnovativeDollarsSpentOnStrategicPriorities; // 
            InnovativeProgramsFundsReceived = model.InnovativeProgramsFundsReceived; // 
            LeaTransferabilityOfFunds = model.LeaTransferabilityOfFunds; // 
            NumberOfImmigrantProgramSubgrants = model.NumberOfImmigrantProgramSubgrants; // 
            PublicSchoolChoiceFundsSpent = model.PublicSchoolChoiceFundsSpent; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFederalProgramFundingAllocationTypeId = model.RefFederalProgramFundingAllocationTypeId; // 
            RefLeaFundsTransferTypeId = model.RefLeaFundsTransferTypeId; // 
            RefReapAlternativeFundingStatusId = model.RefReapAlternativeFundingStatusId; // 
            RefRlisProgramUseId = model.RefRlisProgramUseId; // 
            SchoolImprovementAllocation = model.SchoolImprovementAllocation; // 
            SchoolImprovementReservedPercent = model.SchoolImprovementReservedPercent; // 
            SesFundsSpent = model.SesFundsSpent; // 
            SesPerPupilExpenditure = model.SesPerPupilExpenditure; // 
            SesSchoolChoice20PercentObligation = model.SesSchoolChoice20PercentObligation; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
