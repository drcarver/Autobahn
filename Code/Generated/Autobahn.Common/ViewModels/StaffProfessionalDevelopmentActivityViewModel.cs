//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivityViewModel
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityViewModel : ViewModelBase, Interfaces.IStaffProfessionalDevelopmentActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffProfessionalDevelopmentActivity";

        // member variable for the ActivityCompletionDate property
        private System.DateTime? _ActivityCompletionDate;

        // member variable for the ActivityIdentifier property
        private System.String _ActivityIdentifier;

        // member variable for the ActivityStartDate property
        private System.DateTime? _ActivityStartDate;

        // member variable for the ActivityTitle property
        private System.String _ActivityTitle;

        // member variable for the NumberOfCreditsEarned property
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // member variable for the ProfessionalDevelopmentRequirementId property
        private Guid _ProfessionalDevelopmentRequirementId;

        // member variable for the ProfessionalDevelopmentSessionId property
        private Guid _ProfessionalDevelopmentSessionId;

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        // member variable for the RefProfessionalDevelopmentFinancialSupportId property
        private Guid? _RefProfessionalDevelopmentFinancialSupportId;

        // member variable for the ScholarshipStatus property
        private System.Boolean? _ScholarshipStatus;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffProfessionalDevelopmentActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.DateTime? ActivityCompletionDate { get => _ActivityCompletionDate; set => SetProperty(ref _ActivityCompletionDate, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ActivityIdentifier { get => _ActivityIdentifier; set => SetProperty(ref _ActivityIdentifier, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.DateTime? ActivityStartDate { get => _ActivityStartDate; set => SetProperty(ref _ActivityStartDate, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ActivityTitle { get => _ActivityTitle; set => SetProperty(ref _ActivityTitle, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProfessionalDevelopmentRequirement"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get => _ProfessionalDevelopmentRequirementId; set => SetProperty(ref _ProfessionalDevelopmentRequirementId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProfessionalDevelopmentSession"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get => _ProfessionalDevelopmentSessionId; set => SetProperty(ref _ProfessionalDevelopmentSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get => _RefProfessionalDevelopmentFinancialSupportId; set => SetProperty(ref _RefProfessionalDevelopmentFinancialSupportId, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Boolean? ScholarshipStatus { get => _ScholarshipStatus; set => SetProperty(ref _ScholarshipStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityCompletionDate = model.ActivityCompletionDate;
            ActivityIdentifier = model.ActivityIdentifier;
            ActivityStartDate = model.ActivityStartDate;
            ActivityTitle = model.ActivityTitle;
            NumberOfCreditsEarned = model.NumberOfCreditsEarned;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId;
            ProfessionalDevelopmentRequirementId = model.ProfessionalDevelopmentRequirementId;
            ProfessionalDevelopmentSessionId = model.ProfessionalDevelopmentSessionId;
            RefCourseCreditUnitId = model.RefCourseCreditUnitId;
            RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId;
            ScholarshipStatus = model.ScholarshipStatus;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
