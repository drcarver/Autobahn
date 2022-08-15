//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationDocumentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AuthorizationDocumentViewModel
     /// </summary>
    public partial class AuthorizationDocumentViewModel : ViewModelBase, Interfaces.IAuthorizationDocument
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AuthorizationDocument";

        // member variable for the RefAuthorizerTypeId property
        private Guid? _RefAuthorizerTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AuthorizationDocumentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAuthorizerType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20701">Authorizer Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Authorizer Type")]
        public Guid? RefAuthorizerTypeId { get => _RefAuthorizerTypeId; set => SetProperty(ref _RefAuthorizerTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthorizationDocument model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAuthorizerTypeId = model.RefAuthorizerTypeId; // Authorizer Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
