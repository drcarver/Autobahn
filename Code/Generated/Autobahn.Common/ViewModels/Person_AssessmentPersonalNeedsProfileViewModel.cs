//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Person_AssessmentPersonalNeedsProfileViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The Person_AssessmentPersonalNeedsProfileViewModel
     /// </summary>
    public partial class Person_AssessmentPersonalNeedsProfileViewModel : ViewModelBase, Interfaces.IPerson_AssessmentPersonalNeedsProfileViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Person_AssessmentPersonalNeedsProfile";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the AssessmentPersonalNeedsProfileId property
        private Guid _AssessmentPersonalNeedsProfileId;

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
        /// The title of the Person_AssessmentPersonalNeedsProfileViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfileId"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get => _AssessmentPersonalNeedsProfileId; set => SetProperty(ref _AssessmentPersonalNeedsProfileId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPerson_AssessmentPersonalNeedsProfile model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            AssessmentPersonalNeedsProfileId = model.AssessmentPersonalNeedsProfileId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
