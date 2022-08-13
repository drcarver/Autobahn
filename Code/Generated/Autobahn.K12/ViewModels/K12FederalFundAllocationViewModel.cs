//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12FederalFundAllocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12FederalFundAllocationViewModel
     /// </summary>
    public partial class K12FederalFundAllocationViewModel : ViewModelBase, Interfaces.IK12FederalFundAllocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12FederalFundAllocation";

        // member variable for the FederalProgramCode property
        private System.String _FederalProgramCode;

        // member variable for the FederalProgramsFundingAllocation property
        private System.Decimal? _FederalProgramsFundingAllocation;

        // member variable for the FundsTransferAmount property
        private System.Decimal? _FundsTransferAmount;

        // member variable for the LeaTransferabilityOfFunds property
        private System.Boolean? _LeaTransferabilityOfFunds;

        // member variable for the NumberOfImmigrantProgramSubgrants property
        private System.Int32? _NumberOfImmigrantProgramSubgrants;

        // member variable for the OrganizationCalendarSessionId property
        private Guid _OrganizationCalendarSessionId;

        // member variable for the RefFederalProgramFundingAllocationTypeId property
        private Guid? _RefFederalProgramFundingAllocationTypeId;

        // member variable for the RefLeaFundsTransferTypeId property
        private Guid? _RefLeaFundsTransferTypeId;

        // member variable for the RefReapAlternativeFundingStatusId property
        private Guid? _RefReapAlternativeFundingStatusId;

        // member variable for the SchoolImprovementAllocation property
        private System.Decimal? _SchoolImprovementAllocation;

        // member variable for the SchoolImprovementReservedPercent property
        private System.Decimal? _SchoolImprovementReservedPercent;

        // member variable for the SesPerPupilExpenditure property
        private System.Decimal? _SesPerPupilExpenditure;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12FederalFundAllocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String FederalProgramCode { get => _FederalProgramCode; set => SetProperty(ref _FederalProgramCode, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? FederalProgramsFundingAllocation { get => _FederalProgramsFundingAllocation; set => SetProperty(ref _FederalProgramsFundingAllocation, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? FundsTransferAmount { get => _FundsTransferAmount; set => SetProperty(ref _FundsTransferAmount, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? LeaTransferabilityOfFunds { get => _LeaTransferabilityOfFunds; set => SetProperty(ref _LeaTransferabilityOfFunds, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Int32? NumberOfImmigrantProgramSubgrants { get => _NumberOfImmigrantProgramSubgrants; set => SetProperty(ref _NumberOfImmigrantProgramSubgrants, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
        /// </summary>
        public Guid? RefFederalProgramFundingAllocationTypeId { get => _RefFederalProgramFundingAllocationTypeId; set => SetProperty(ref _RefFederalProgramFundingAllocationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
        /// </summary>
        public Guid? RefLeaFundsTransferTypeId { get => _RefLeaFundsTransferTypeId; set => SetProperty(ref _RefLeaFundsTransferTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
        /// </summary>
        public Guid? RefReapAlternativeFundingStatusId { get => _RefReapAlternativeFundingStatusId; set => SetProperty(ref _RefReapAlternativeFundingStatusId, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? SchoolImprovementAllocation { get => _SchoolImprovementAllocation; set => SetProperty(ref _SchoolImprovementAllocation, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? SchoolImprovementReservedPercent { get => _SchoolImprovementReservedPercent; set => SetProperty(ref _SchoolImprovementReservedPercent, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? SesPerPupilExpenditure { get => _SesPerPupilExpenditure; set => SetProperty(ref _SesPerPupilExpenditure, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12FederalFundAllocation model)
        {
            IsBusy = true;
            Id = model.Id;
            FederalProgramCode = model.FederalProgramCode;
            FederalProgramsFundingAllocation = model.FederalProgramsFundingAllocation;
            FundsTransferAmount = model.FundsTransferAmount;
            LeaTransferabilityOfFunds = model.LeaTransferabilityOfFunds;
            NumberOfImmigrantProgramSubgrants = model.NumberOfImmigrantProgramSubgrants;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            RefFederalProgramFundingAllocationTypeId = model.RefFederalProgramFundingAllocationTypeId;
            RefLeaFundsTransferTypeId = model.RefLeaFundsTransferTypeId;
            RefReapAlternativeFundingStatusId = model.RefReapAlternativeFundingStatusId;
            SchoolImprovementAllocation = model.SchoolImprovementAllocation;
            SchoolImprovementReservedPercent = model.SchoolImprovementReservedPercent;
            SesPerPupilExpenditure = model.SesPerPupilExpenditure;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
