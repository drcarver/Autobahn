//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IEPAuthorizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationViewModel
     /// </summary>
    public partial class IEPAuthorizationViewModel : ViewModelBase, Interfaces.IIEPAuthorization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorization";

        // member variable for the AuthorizationDocumentId property
        private Guid _AuthorizationDocumentId;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the RefIEPAuthorizationDocumentTypeId property
        private Guid? _RefIEPAuthorizationDocumentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IEPAuthorizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AuthorizationDocument"/> model
        /// </summary>
        public Guid AuthorizationDocumentId { get => _AuthorizationDocumentId; set => SetProperty(ref _AuthorizationDocumentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPAuthorizationDocumentType"/> model
        /// </summary>
        public Guid? RefIEPAuthorizationDocumentTypeId { get => _RefIEPAuthorizationDocumentTypeId; set => SetProperty(ref _RefIEPAuthorizationDocumentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPAuthorization model)
        {
            IsBusy = true;
            Id = model.Id;
            AuthorizationDocumentId = model.AuthorizationDocumentId;
            IndividualizedProgramId = model.IndividualizedProgramId;
            RefIEPAuthorizationDocumentTypeId = model.RefIEPAuthorizationDocumentTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
