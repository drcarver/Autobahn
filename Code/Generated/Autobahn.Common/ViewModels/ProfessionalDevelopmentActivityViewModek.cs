//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentActivityViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentActivityViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentActivityViewModel : BindableBase, IProfessionalDevelopmentActivity
    {
#region "Backing Fields"
        // member variable for the Title property
        private System.String _Title;

        // member variable for the ActivityIdentifier property
        private System.String _ActivityIdentifier;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Objective property
        private System.String _Objective;

        // member variable for the ActivityCode property
        private System.String _ActivityCode;

        // member variable for the ApprovalCode property
        private System.String _ApprovalCode;

        // member variable for the Cost property
        private System.Decimal? _Cost;

        // member variable for the Credits property
        private System.Decimal? _Credits;

        // member variable for the ScholarshipStatus property
        private System.Boolean? _ScholarshipStatus;

        // member variable for the PublishIndicator property
        private System.Boolean? _PublishIndicator;

        // member variable for the ProfessionalDevelopmentActivityStateApprovedStatus property
        private System.Boolean? _ProfessionalDevelopmentActivityStateApprovedStatus;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentRequirementId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CourseId"/> model
        /// </summary>
        public Guid? CourseId { get; set; }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String ActivityIdentifier  { get => _ActivityIdentifier; set => SetProperty(ref _ActivityIdentifier, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Objective  { get => _Objective; set => SetProperty(ref _Objective, value); }

        public System.String ActivityCode  { get => _ActivityCode; set => SetProperty(ref _ActivityCode, value); }

        public System.String ApprovalCode  { get => _ApprovalCode; set => SetProperty(ref _ApprovalCode, value); }

        public System.Decimal? Cost { get => _Cost; set => SetProperty(ref _Cost, value); }

        public System.Decimal? Credits { get => _Credits; set => SetProperty(ref _Credits, value); }

        public System.Boolean? ScholarshipStatus { get => _ScholarshipStatus; set => SetProperty(ref _ScholarshipStatus, value); }

        public System.Boolean? PublishIndicator { get => _PublishIndicator; set => SetProperty(ref _PublishIndicator, value); }

        public System.Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get => _ProfessionalDevelopmentActivityStateApprovedStatus; set => SetProperty(ref _ProfessionalDevelopmentActivityStateApprovedStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnitId"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupportId"/> model
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDAudienceTypeId"/> model
        /// </summary>
        public Guid? RefPDAudienceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityApprovedPurposeId"/> model
        /// </summary>
        public Guid? RefPDActivityApprovedPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityCreditTypeId"/> model
        /// </summary>
        public Guid? RefPDActivityCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityLevelId"/> model
        /// </summary>
        public Guid? RefPDActivityLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityTypeId"/> model
        /// </summary>
        public Guid? RefPDActivityTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentRequirementId = model.ProfessionalDevelopmentRequirementId;
            CourseId = model.CourseId;
            Title = model.Title;
            ActivityIdentifier = model.ActivityIdentifier;
            Description = model.Description;
            Objective = model.Objective;
            ActivityCode = model.ActivityCode;
            ApprovalCode = model.ApprovalCode;
            Cost = model.Cost;
            Credits = model.Credits;
            ScholarshipStatus = model.ScholarshipStatus;
            PublishIndicator = model.PublishIndicator;
            ProfessionalDevelopmentActivityStateApprovedStatus = model.ProfessionalDevelopmentActivityStateApprovedStatus;
            RefCourseCreditUnitId = model.RefCourseCreditUnitId;
            RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId;
            RefPDAudienceTypeId = model.RefPDAudienceTypeId;
            RefPDActivityApprovedPurposeId = model.RefPDActivityApprovedPurposeId;
            RefPDActivityCreditTypeId = model.RefPDActivityCreditTypeId;
            RefPDActivityLevelId = model.RefPDActivityLevelId;
            RefPDActivityTypeId = model.RefPDActivityTypeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
