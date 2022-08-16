//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmailViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmailViewModel
     /// </summary>
    public partial class OrganizationEmailViewModel : ViewModelBase, Interfaces.IOrganizationEmail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmail";

        // member variable for the DoNotPublishIndicator property
        private  _DoNotPublishIndicator;

        // member variable for the ElectronicMailAddress property
        private Guid? _ElectronicMailAddress;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEmailTypeId property
        private  _RefEmailTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? ElectronicMailAddress { get => _ElectronicMailAddress; set => SetProperty(ref _ElectronicMailAddress, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        public  RefEmailTypeId { get => _RefEmailTypeId; set => SetProperty(ref _RefEmailTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmail model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator; // 
            ElectronicMailAddress = model.ElectronicMailAddress; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEmailTypeId = model.RefEmailTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
