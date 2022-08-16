//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationOperationalStatusViewModel
     /// </summary>
    public partial class OrganizationOperationalStatusViewModel : ViewModelBase, Interfaces.IOrganizationOperationalStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationOperationalStatus";

        // member variable for the OperationalStatusEffectiveDate property
        private  _OperationalStatusEffectiveDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefOperationalStatusId property
        private Guid? _RefOperationalStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  OperationalStatusEffectiveDate { get => _OperationalStatusEffectiveDate; set => SetProperty(ref _OperationalStatusEffectiveDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOperationalStatus"/> model
        /// </summary>
        public Guid? RefOperationalStatusId { get => _RefOperationalStatusId; set => SetProperty(ref _RefOperationalStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationOperationalStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            OperationalStatusEffectiveDate = model.OperationalStatusEffectiveDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefOperationalStatusId = model.RefOperationalStatusId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
