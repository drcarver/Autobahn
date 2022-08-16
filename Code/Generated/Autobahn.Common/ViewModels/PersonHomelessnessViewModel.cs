//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHomelessnessViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHomelessnessViewModel
     /// </summary>
    public partial class PersonHomelessnessViewModel : ViewModelBase, Interfaces.IPersonHomelessness
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHomelessness";

        // member variable for the HomelessnessStatus property
        private  _HomelessnessStatus;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefHomelessNighttimeResidenceId property
        private Guid? _RefHomelessNighttimeResidenceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  HomelessnessStatus { get => _HomelessnessStatus; set => SetProperty(ref _HomelessnessStatus, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHomelessNighttimeResidence"/> model
        /// </summary>
        public Guid? RefHomelessNighttimeResidenceId { get => _RefHomelessNighttimeResidenceId; set => SetProperty(ref _RefHomelessNighttimeResidenceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHomelessness model)
        {
            IsBusy = true;
            Id = model.Id;
            HomelessnessStatus = model.HomelessnessStatus; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefHomelessNighttimeResidenceId = model.RefHomelessNighttimeResidenceId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
