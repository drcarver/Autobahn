//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundAllocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12SeaFederalFundAllocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SeaFederalFundAllocation model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
