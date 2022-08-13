//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The EarlyChildhoodCredentialViewModel
     /// </summary>
    public partial class EarlyChildhoodCredentialViewModel : ViewModelBase, Interfaces.IEarlyChildhoodCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EarlyChildhoodCredential";

        // member variable for the PersonCredentialId property
        private Guid _PersonCredentialId;

        // member variable for the RefEarlyChildhoodCredentialId property
        private Guid _RefEarlyChildhoodCredentialId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the EarlyChildhoodCredentialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonCredential"/> model
        /// </summary>
        public Guid PersonCredentialId { get => _PersonCredentialId; set => SetProperty(ref _PersonCredentialId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodCredential"/> model
        /// </summary>
        public Guid RefEarlyChildhoodCredentialId { get => _RefEarlyChildhoodCredentialId; set => SetProperty(ref _RefEarlyChildhoodCredentialId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEarlyChildhoodCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonCredentialId = model.PersonCredentialId;
            RefEarlyChildhoodCredentialId = model.RefEarlyChildhoodCredentialId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
