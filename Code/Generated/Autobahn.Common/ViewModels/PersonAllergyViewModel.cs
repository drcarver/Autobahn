//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAllergyViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAllergyViewModel
     /// </summary>
    public partial class PersonAllergyViewModel : ViewModelBase, Interfaces.IPersonAllergyViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAllergy";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefAllergyTypeId property
        private Guid _RefAllergyTypeId;

        // member variable for the RefAllergySeverityId property
        private Guid? _RefAllergySeverityId;

        // member variable for the ReactionDescription property
        private System.String _ReactionDescription;

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
        /// The title of the PersonAllergyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAllergyTypeId"/> model
        /// </summary>
        public Guid RefAllergyTypeId { get => _RefAllergyTypeId; set => SetProperty(ref _RefAllergyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergySeverityId"/> model
        /// </summary>
        public Guid? RefAllergySeverityId { get => _RefAllergySeverityId; set => SetProperty(ref _RefAllergySeverityId, value); }

        public System.String ReactionDescription  { get => _ReactionDescription; set => SetProperty(ref _ReactionDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAllergy model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefAllergyTypeId = model.RefAllergyTypeId;
            RefAllergySeverityId = model.RefAllergySeverityId;
            ReactionDescription = model.ReactionDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
