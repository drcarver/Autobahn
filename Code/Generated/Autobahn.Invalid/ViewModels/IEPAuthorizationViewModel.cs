//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationViewModel
     /// </summary>
    public partial class IEPAuthorizationViewModel : ViewModelBase, Interfaces.IIEPAuthorization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorization";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIEPAuthorizationDocumentTypeId property
        private Guid? _RefIEPAuthorizationDocumentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

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
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIEPAuthorizationDocumentTypeId = model.RefIEPAuthorizationDocumentTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
