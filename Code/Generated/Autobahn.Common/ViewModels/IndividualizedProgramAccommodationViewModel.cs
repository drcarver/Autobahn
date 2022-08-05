//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAccommodationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAccommodationViewModel
     /// </summary>
    public partial class IndividualizedProgramAccommodationViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAccommodation
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAccommodation";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Applicability property
        private System.String _Applicability;

        // member variable for the RefAccommodationTypeId property
        private Guid? _RefAccommodationTypeId;

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
        /// The title of the IndividualizedProgramAccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Applicability  { get => _Applicability; set => SetProperty(ref _Applicability, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationTypeId"/> model
        /// </summary>
        public Guid? RefAccommodationTypeId { get => _RefAccommodationTypeId; set => SetProperty(ref _RefAccommodationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            Description = model.Description;
            Applicability = model.Applicability;
            RefAccommodationTypeId = model.RefAccommodationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
