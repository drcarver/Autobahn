//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentOtherFundingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELEnrollmentOtherFundingViewModel
     /// </summary>
    public partial class ELEnrollmentOtherFundingViewModel : ViewModelBase, Interfaces.IELEnrollmentOtherFunding
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELEnrollmentOtherFunding";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefELOtherFederalFundingSourcesId property
        private Guid _RefELOtherFederalFundingSourcesId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELEnrollmentOtherFundingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        public Guid RefELOtherFederalFundingSourcesId { get => _RefELOtherFederalFundingSourcesId; set => SetProperty(ref _RefELOtherFederalFundingSourcesId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELEnrollmentOtherFunding model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefELOtherFederalFundingSourcesId = model.RefELOtherFederalFundingSourcesId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
