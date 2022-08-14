//**********************************************************
//* DomainName: Common Models
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

        // member variable for the MultipleBirthIndicator property
        private System.Boolean? _MultipleBirthIndicator;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefTrimesterWhenPrenatalCareBeganId property
        private Guid? _RefTrimesterWhenPrenatalCareBeganId;

        // member variable for the WeeksOfGestation property
        private System.Int32? _WeeksOfGestation;

        // member variable for the WeightAtBirth property
        private System.String _WeightAtBirth;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonHealthBirthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        public System.Boolean? MultipleBirthIndicator { get => _MultipleBirthIndicator; set => SetProperty(ref _MultipleBirthIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTrimesterWhenPrenatalCareBegan"/> model
        /// </summary>
        public Guid? RefTrimesterWhenPrenatalCareBeganId { get => _RefTrimesterWhenPrenatalCareBeganId; set => SetProperty(ref _RefTrimesterWhenPrenatalCareBeganId, value); }

        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        public System.Int32? WeeksOfGestation { get => _WeeksOfGestation; set => SetProperty(ref _WeeksOfGestation, value); }

        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        public System.String WeightAtBirth { get => _WeightAtBirth; set => SetProperty(ref _WeightAtBirth, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealthBirth model)
        {
            IsBusy = true;
            Id = model.Id;
            MultipleBirthIndicator = model.MultipleBirthIndicator;
            PersonId = model.PersonId;
            RefTrimesterWhenPrenatalCareBeganId = model.RefTrimesterWhenPrenatalCareBeganId;
            WeeksOfGestation = model.WeeksOfGestation;
            WeightAtBirth = model.WeightAtBirth;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
