//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundAllocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SeaFederalFundAllocationViewModel
     /// </summary>
    public partial class K12SeaFederalFundAllocationViewModel : ViewModelBase, Interfaces.IK12SeaFederalFundAllocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SeaFederalFundAllocation";

        // member variable for the FederalProgramCode property
        private  _FederalProgramCode;

        // member variable for the FederalProgramsFundingAllocation property
        private  _FederalProgramsFundingAllocation;

        // member variable for the RefFederalProgramFundingAllocationTypeId property
        private  _RefFederalProgramFundingAllocationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FederalProgramCode { get => _FederalProgramCode; set => SetProperty(ref _FederalProgramCode, value); }

        /// <summary>
        /// </summary>
        public  FederalProgramsFundingAllocation { get => _FederalProgramsFundingAllocation; set => SetProperty(ref _FederalProgramsFundingAllocation, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
        /// </summary>
        public  RefFederalProgramFundingAllocationTypeId { get => _RefFederalProgramFundingAllocationTypeId; set => SetProperty(ref _RefFederalProgramFundingAllocationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SeaFederalFundAllocation model)
        {
            IsBusy = true;
            Id = model.Id;
            FederalProgramCode = model.FederalProgramCode; // 
            FederalProgramsFundingAllocation = model.FederalProgramsFundingAllocation; // 
            RefFederalProgramFundingAllocationTypeId = model.RefFederalProgramFundingAllocationTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
