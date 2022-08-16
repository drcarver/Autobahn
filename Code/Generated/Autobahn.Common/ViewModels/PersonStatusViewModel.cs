//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonStatusViewModel
     /// </summary>
    public partial class PersonStatusViewModel : ViewModelBase, Interfaces.IPersonStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonStatus";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefPersonStatusTypeId property
        private Guid? _RefPersonStatusTypeId;

        // member variable for the StatusEndDate property
        private  _StatusEndDate;

        // member variable for the StatusStartDate property
        private  _StatusStartDate;

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
        /// Reference to an optional instance of the <see cref="RefPersonStatusType"/> model
        /// </summary>
        public Guid? RefPersonStatusTypeId { get => _RefPersonStatusTypeId; set => SetProperty(ref _RefPersonStatusTypeId, value); }

        /// <summary>
        /// </summary>
        public  StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

        /// <summary>
        /// </summary>
        public  StatusStartDate { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefPersonStatusTypeId = model.RefPersonStatusTypeId; // 
            StatusEndDate = model.StatusEndDate; // 
            StatusStartDate = model.StatusStartDate; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
