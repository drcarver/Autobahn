//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramViewModel
     /// </summary>
    public partial class ProgramViewModel : ViewModelBase, Interfaces.IProgramViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Program";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the CreditsRequired property
        private System.Decimal? _CreditsRequired;

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
        /// The title of the ProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.Decimal? CreditsRequired { get => _CreditsRequired; set => SetProperty(ref _CreditsRequired, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            CreditsRequired = model.CreditsRequired;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
