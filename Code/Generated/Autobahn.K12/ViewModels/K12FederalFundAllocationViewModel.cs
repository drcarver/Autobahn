//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12FederalFundAllocationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12FederalFundAllocation View Model
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
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String FederalProgramCode { get => _FederalProgramCode; set => SetProperty(ref _FederalProgramCode, value); }

        public System.Decimal? FederalProgramsFundingAllocation { get => _FederalProgramsFundingAllocation; set => SetProperty(ref _FederalProgramsFundingAllocation, value); }

        public System.Decimal? FundsTransferAmount { get => _FundsTransferAmount; set => SetProperty(ref _FundsTransferAmount, value); }

        public System.Boolean? LeaTransferabilityOfFunds { get => _LeaTransferabilityOfFunds; set => SetProperty(ref _LeaTransferabilityOfFunds, value); }

        public System.Int32? NumberOfImmigrantProgramSubgrants { get => _NumberOfImmigrantProgramSubgrants; set => SetProperty(ref _NumberOfImmigrantProgramSubgrants, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
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

        public System.Decimal? SchoolImprovementAllocation { get => _SchoolImprovementAllocation; set => SetProperty(ref _SchoolImprovementAllocation, value); }

        public System.Decimal? SchoolImprovementReservedPercent { get => _SchoolImprovementReservedPercent; set => SetProperty(ref _SchoolImprovementReservedPercent, value); }

        public System.Decimal? SesPerPupilExpenditure { get => _SesPerPupilExpenditure; set => SetProperty(ref _SesPerPupilExpenditure, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12FederalFundAllocation model)
        {
            IsBusy = true;
            Id = model.Id;
            FederalProgramCode = model.FederalProgramCode; // 
            FederalProgramsFundingAllocation = model.FederalProgramsFundingAllocation; // 
            FundsTransferAmount = model.FundsTransferAmount; // 
            LeaTransferabilityOfFunds = model.LeaTransferabilityOfFunds; // 
            NumberOfImmigrantProgramSubgrants = model.NumberOfImmigrantProgramSubgrants; // 
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
            RefFederalProgramFundingAllocationTypeId = model.RefFederalProgramFundingAllocationTypeId; // 
            RefLeaFundsTransferTypeId = model.RefLeaFundsTransferTypeId; // 
            RefReapAlternativeFundingStatusId = model.RefReapAlternativeFundingStatusId; // 
            SchoolImprovementAllocation = model.SchoolImprovementAllocation; // 
            SchoolImprovementReservedPercent = model.SchoolImprovementReservedPercent; // 
            SesPerPupilExpenditure = model.SesPerPupilExpenditure; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLeaFundsTransferType List
        /// <summary>
        /// The complete <see cref="RefLeaFundsTransferType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLeaFundsTransferTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("c8d0cced-91c6-4d6e-9733-210a863eec9a"), Code="FromEligibleProgram", Description="From Eligible Program", Definition="The LEA  transferred funds from an eligible program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("4f085a65-8cd0-4fa6-a62e-9917be0585a4"), Code="ToEligibleProgram", Description="To Eligible Program", Definition="The LEA  transferred funds to an eligible program.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefReapAlternativeFundingStatus List
        /// <summary>
        /// The complete <see cref="RefReapAlternativeFundingStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefReapAlternativeFundingStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("95637eff-5ad9-46ed-8d42-92c11641b77a"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("e9a36ebe-e0a1-4e50-a76f-e37fd8ec4ebe"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("6ea55c88-ccf1-4e5e-ae52-537341c400d8"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
