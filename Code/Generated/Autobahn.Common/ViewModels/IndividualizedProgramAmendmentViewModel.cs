//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAmendmentViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAmendmentViewModel
     /// </summary>
    public partial class IndividualizedProgramAmendmentViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAmendment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAmendment";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the ReasonDescription property
        private System.String _ReasonDescription;

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
        /// The title of the IndividualizedProgramAmendmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String ReasonDescription  { get => _ReasonDescription; set => SetProperty(ref _ReasonDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAmendment model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            Description = model.Description;
            ReasonDescription = model.ReasonDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
