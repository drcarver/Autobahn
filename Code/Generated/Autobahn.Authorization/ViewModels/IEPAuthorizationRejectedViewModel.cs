//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IEPAuthorizationRejectedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationRejectedViewModel
     /// </summary>
    public partial class IEPAuthorizationRejectedViewModel : ViewModelBase, Interfaces.IIEPAuthorizationRejected
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorizationRejected";

        // member variable for the IEPAuthorizationId property
        private Guid _IEPAuthorizationId;

        // member variable for the PortionDescription property
        private System.String _PortionDescription;

        // member variable for the PortionExplanation property
        private System.String _PortionExplanation;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IEPAuthorizationRejectedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IEPAuthorization"/> model
        /// </summary>
        public Guid IEPAuthorizationId { get => _IEPAuthorizationId; set => SetProperty(ref _IEPAuthorizationId, value); }

        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        public System.String PortionDescription { get => _PortionDescription; set => SetProperty(ref _PortionDescription, value); }

        /// <summary>
        /// Portion the authorizer does not want executed.
        /// </summary>
        public System.String PortionExplanation { get => _PortionExplanation; set => SetProperty(ref _PortionExplanation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPAuthorizationRejected model)
        {
            IsBusy = true;
            Id = model.Id;
            IEPAuthorizationId = model.IEPAuthorizationId;
            PortionDescription = model.PortionDescription;
            PortionExplanation = model.PortionExplanation;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
