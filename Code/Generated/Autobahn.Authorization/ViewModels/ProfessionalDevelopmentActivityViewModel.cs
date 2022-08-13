//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentActivityViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentActivityViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentActivity";

        // member variable for the ActivityCode property
        private System.String _ActivityCode;

        // member variable for the ActivityIdentifier property
        private System.String _ActivityIdentifier;

        // member variable for the ApprovalCode property
        private System.String _ApprovalCode;

        // member variable for the Cost property
        private System.Decimal? _Cost;

        // member variable for the CourseId property
        private Guid? _CourseId;

        // member variable for the Credits property
        private System.Decimal? _Credits;

        // member variable for the Objective property
        private System.String _Objective;

        // member variable for the ProfessionalDevelopmentActivityStateApprovedStatus property
        private System.Boolean? _ProfessionalDevelopmentActivityStateApprovedStatus;

        // member variable for the ProfessionalDevelopmentRequirementId property
        private Guid _ProfessionalDevelopmentRequirementId;

        // member variable for the PublishIndicator property
        private System.Boolean? _PublishIndicator;

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        // member variable for the RefPDActivityApprovedPurposeId property
        private Guid? _RefPDActivityApprovedPurposeId;

        // member variable for the RefPDActivityCreditTypeId property
        private Guid? _RefPDActivityCreditTypeId;

        // member variable for the RefPDActivityLevelId property
        private Guid? _RefPDActivityLevelId;

        // member variable for the RefPDActivityTypeId property
        private Guid? _RefPDActivityTypeId;

        // member variable for the RefPDAudienceTypeId property
        private Guid? _RefPDAudienceTypeId;

        // member variable for the RefProfessionalDevelopmentFinancialSupportId property
        private Guid? _RefProfessionalDevelopmentFinancialSupportId;

        // member variable for the ScholarshipStatus property
        private System.Boolean? _ScholarshipStatus;

        // member variable for the Title property
        private System.String _Title;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProfessionalDevelopmentActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ActivityCode { get => _ActivityCode; set => SetProperty(ref _ActivityCode, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ActivityIdentifier { get => _ActivityIdentifier; set => SetProperty(ref _ActivityIdentifier, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String ApprovalCode { get => _ApprovalCode; set => SetProperty(ref _ApprovalCode, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Decimal? Cost { get => _Cost; set => SetProperty(ref _Cost, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Course"/> model
        /// </summary>
        public Guid? CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Decimal? Credits { get => _Credits; set => SetProperty(ref _Credits, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String Objective { get => _Objective; set => SetProperty(ref _Objective, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get => _ProfessionalDevelopmentActivityStateApprovedStatus; set => SetProperty(ref _ProfessionalDevelopmentActivityStateApprovedStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProfessionalDevelopmentRequirement"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get => _ProfessionalDevelopmentRequirementId; set => SetProperty(ref _ProfessionalDevelopmentRequirementId, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Boolean? PublishIndicator { get => _PublishIndicator; set => SetProperty(ref _PublishIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityApprovedPurpose"/> model
        /// </summary>
        public Guid? RefPDActivityApprovedPurposeId { get => _RefPDActivityApprovedPurposeId; set => SetProperty(ref _RefPDActivityApprovedPurposeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityCreditType"/> model
        /// </summary>
        public Guid? RefPDActivityCreditTypeId { get => _RefPDActivityCreditTypeId; set => SetProperty(ref _RefPDActivityCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityLevel"/> model
        /// </summary>
        public Guid? RefPDActivityLevelId { get => _RefPDActivityLevelId; set => SetProperty(ref _RefPDActivityLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityType"/> model
        /// </summary>
        public Guid? RefPDActivityTypeId { get => _RefPDActivityTypeId; set => SetProperty(ref _RefPDActivityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDAudienceType"/> model
        /// </summary>
        public Guid? RefPDAudienceTypeId { get => _RefPDAudienceTypeId; set => SetProperty(ref _RefPDAudienceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get => _RefProfessionalDevelopmentFinancialSupportId; set => SetProperty(ref _RefProfessionalDevelopmentFinancialSupportId, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.Boolean? ScholarshipStatus { get => _ScholarshipStatus; set => SetProperty(ref _ScholarshipStatus, value); }

        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityCode = model.ActivityCode;
            ActivityIdentifier = model.ActivityIdentifier;
            ApprovalCode = model.ApprovalCode;
            Cost = model.Cost;
            CourseId = model.CourseId;
            Credits = model.Credits;
            Objective = model.Objective;
            ProfessionalDevelopmentActivityStateApprovedStatus = model.ProfessionalDevelopmentActivityStateApprovedStatus;
            ProfessionalDevelopmentRequirementId = model.ProfessionalDevelopmentRequirementId;
            PublishIndicator = model.PublishIndicator;
            RefCourseCreditUnitId = model.RefCourseCreditUnitId;
            RefPDActivityApprovedPurposeId = model.RefPDActivityApprovedPurposeId;
            RefPDActivityCreditTypeId = model.RefPDActivityCreditTypeId;
            RefPDActivityLevelId = model.RefPDActivityLevelId;
            RefPDActivityTypeId = model.RefPDActivityTypeId;
            RefPDAudienceTypeId = model.RefPDAudienceTypeId;
            RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId;
            ScholarshipStatus = model.ScholarshipStatus;
            Title = model.Title;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
