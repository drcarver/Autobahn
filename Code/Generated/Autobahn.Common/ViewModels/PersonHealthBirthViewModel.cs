//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthBirthViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHealthBirthViewModel
     /// </summary>
    public partial class PersonHealthBirthViewModel : ViewModelBase, Interfaces.IPersonHealthBirth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHealthBirth";

        // member variable for the MultipleBirthIndicator property
        private  _MultipleBirthIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefTrimesterWhenPrenatalCareBeganId property
        private  _RefTrimesterWhenPrenatalCareBeganId;

        // member variable for the WeeksOfGestation property
        private  _WeeksOfGestation;

        // member variable for the WeightAtBirth property
        private Guid? _WeightAtBirth;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  MultipleBirthIndicator { get => _MultipleBirthIndicator; set => SetProperty(ref _MultipleBirthIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTrimesterWhenPrenatalCareBegan"/> model
        /// </summary>
        public  RefTrimesterWhenPrenatalCareBeganId { get => _RefTrimesterWhenPrenatalCareBeganId; set => SetProperty(ref _RefTrimesterWhenPrenatalCareBeganId, value); }

        /// <summary>
        /// </summary>
        public  WeeksOfGestation { get => _WeeksOfGestation; set => SetProperty(ref _WeeksOfGestation, value); }

        /// <summary>
        /// </summary>
        public Guid? WeightAtBirth { get => _WeightAtBirth; set => SetProperty(ref _WeightAtBirth, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealthBirth model)
        {
            IsBusy = true;
            Id = model.Id;
            MultipleBirthIndicator = model.MultipleBirthIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefTrimesterWhenPrenatalCareBeganId = model.RefTrimesterWhenPrenatalCareBeganId; // 
            WeeksOfGestation = model.WeeksOfGestation; // 
            WeightAtBirth = model.WeightAtBirth; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
