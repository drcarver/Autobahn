//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffProfessionalDevelopmentActivityViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivityViewModel
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityViewModel : ViewModelBase, Interfaces.IStaffProfessionalDevelopmentActivityViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffProfessionalDevelopmentActivity";

        // member variable for the ProfessionalDevelopmentRequirementId property
        private Guid _ProfessionalDevelopmentRequirementId;

        // member variable for the ActivityTitle property
        private System.String _ActivityTitle;

        // member variable for the ActivityIdentifier property
        private System.String _ActivityIdentifier;

        // member variable for the ActivityStartDate property
        private System.DateTime? _ActivityStartDate;

        // member variable for the ActivityCompletionDate property
        private System.DateTime? _ActivityCompletionDate;

        // member variable for the ScholarshipStatus property
        private System.Boolean? _ScholarshipStatus;

        // member variable for the RefProfessionalDevelopmentFinancialSupportId property
        private Guid? _RefProfessionalDevelopmentFinancialSupportId;

        // member variable for the NumberOfCreditsEarned property
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ProfessionalDevelopmentSessionId property
        private Guid _ProfessionalDevelopmentSessionId;

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
        /// The title of the StaffProfessionalDevelopmentActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentRequirementId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get => _ProfessionalDevelopmentRequirementId; set => SetProperty(ref _ProfessionalDevelopmentRequirementId, value); }

        public System.String ActivityTitle  { get => _ActivityTitle; set => SetProperty(ref _ActivityTitle, value); }

        public System.String ActivityIdentifier  { get => _ActivityIdentifier; set => SetProperty(ref _ActivityIdentifier, value); }

        public System.DateTime? ActivityStartDate { get => _ActivityStartDate; set => SetProperty(ref _ActivityStartDate, value); }

        public System.DateTime? ActivityCompletionDate { get => _ActivityCompletionDate; set => SetProperty(ref _ActivityCompletionDate, value); }

        public System.Boolean? ScholarshipStatus { get => _ScholarshipStatus; set => SetProperty(ref _ScholarshipStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupportId"/> model
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get => _RefProfessionalDevelopmentFinancialSupportId; set => SetProperty(ref _RefProfessionalDevelopmentFinancialSupportId, value); }

        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnitId"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivityId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentSessionId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get => _ProfessionalDevelopmentSessionId; set => SetProperty(ref _ProfessionalDevelopmentSessionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentRequirementId = model.ProfessionalDevelopmentRequirementId;
            ActivityTitle = model.ActivityTitle;
            ActivityIdentifier = model.ActivityIdentifier;
            ActivityStartDate = model.ActivityStartDate;
            ActivityCompletionDate = model.ActivityCompletionDate;
            ScholarshipStatus = model.ScholarshipStatus;
            RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId;
            NumberOfCreditsEarned = model.NumberOfCreditsEarned;
            RefCourseCreditUnitId = model.RefCourseCreditUnitId;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ProfessionalDevelopmentSessionId = model.ProfessionalDevelopmentSessionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
