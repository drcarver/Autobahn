//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationIndicatorViewModel
     /// </summary>
    public partial class OrganizationIndicatorViewModel : ViewModelBase, Interfaces.IOrganizationIndicator
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationIndicator";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefOrganizationIndicatorId property
        private Guid? _RefOrganizationIndicatorId;

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
        /// Reference to an optional instance of the <see cref="RefOrganizationIndicator"/> model
        /// </summary>
        public Guid? RefOrganizationIndicatorId { get => _RefOrganizationIndicatorId; set => SetProperty(ref _RefOrganizationIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationIndicator model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefOrganizationIndicatorId = model.RefOrganizationIndicatorId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
