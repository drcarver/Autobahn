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

        // member variable for the AcceptanceIndicator property
        private  _AcceptanceIndicator;

        // member variable for the AuthorizationDate property
        private  _AuthorizationDate;

        // member variable for the DecisionExplanation property
        private  _DecisionExplanation;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAuthorizerTypeId property
        private Guid? _RefAuthorizerTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AcceptanceIndicator { get => _AcceptanceIndicator; set => SetProperty(ref _AcceptanceIndicator, value); }

        /// <summary>
        /// </summary>
        public  AuthorizationDate { get => _AuthorizationDate; set => SetProperty(ref _AuthorizationDate, value); }

        /// <summary>
        /// </summary>
        public  DecisionExplanation { get => _DecisionExplanation; set => SetProperty(ref _DecisionExplanation, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAuthorizerType"/> model
        /// </summary>
        public Guid? RefAuthorizerTypeId { get => _RefAuthorizerTypeId; set => SetProperty(ref _RefAuthorizerTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthorizationDocument model)
        {
            IsBusy = true;
            Id = model.Id;
            AcceptanceIndicator = model.AcceptanceIndicator; // 
            AuthorizationDate = model.AuthorizationDate; // 
            DecisionExplanation = model.DecisionExplanation; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAuthorizerTypeId = model.RefAuthorizerTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
