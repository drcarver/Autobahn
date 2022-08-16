//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentActivityViewModel
     /// </summary>
    public partial class K12StudentActivityViewModel : ViewModelBase, Interfaces.IK12StudentActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentActivity";

        // member variable for the ActivityTimeInvolved property
        private Guid? _ActivityTimeInvolved;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefActivityTimeMeasurementTypeId property
        private  _RefActivityTimeMeasurementTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ActivityTimeInvolved { get => _ActivityTimeInvolved; set => SetProperty(ref _ActivityTimeInvolved, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementType"/> model
        /// </summary>
        public  RefActivityTimeMeasurementTypeId { get => _RefActivityTimeMeasurementTypeId; set => SetProperty(ref _RefActivityTimeMeasurementTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityTimeInvolved = model.ActivityTimeInvolved; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefActivityTimeMeasurementTypeId = model.RefActivityTimeMeasurementTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
