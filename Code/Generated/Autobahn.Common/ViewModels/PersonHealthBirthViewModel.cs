//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealthBirthViewModel.cs
//**********************************************************


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

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the WeeksOfGestation property
        private System.Int32? _WeeksOfGestation;

        // member variable for the MultipleBirthIndicator property
        private System.Boolean? _MultipleBirthIndicator;

        // member variable for the WeightAtBirth property
        private System.String _WeightAtBirth;

        // member variable for the RefTrimesterWhenPrenatalCareBeganId property
        private Guid? _RefTrimesterWhenPrenatalCareBeganId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonHealthBirthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.Int32? WeeksOfGestation { get => _WeeksOfGestation; set => SetProperty(ref _WeeksOfGestation, value); }

        public System.Boolean? MultipleBirthIndicator { get => _MultipleBirthIndicator; set => SetProperty(ref _MultipleBirthIndicator, value); }

        public System.String WeightAtBirth  { get => _WeightAtBirth; set => SetProperty(ref _WeightAtBirth, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTrimesterWhenPrenatalCareBeganId"/> model
        /// </summary>
        public Guid? RefTrimesterWhenPrenatalCareBeganId { get => _RefTrimesterWhenPrenatalCareBeganId; set => SetProperty(ref _RefTrimesterWhenPrenatalCareBeganId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealthBirth model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            WeeksOfGestation = model.WeeksOfGestation;
            MultipleBirthIndicator = model.MultipleBirthIndicator;
            WeightAtBirth = model.WeightAtBirth;
            RefTrimesterWhenPrenatalCareBeganId = model.RefTrimesterWhenPrenatalCareBeganId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
