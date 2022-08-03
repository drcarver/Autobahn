//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffProfessionalDevelopmentActivityViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivityViewModel
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityViewModel : BindableBase, IStaffProfessionalDevelopmentActivity
    {
#region "Backing Fields"
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

        // member variable for the NumberOfCreditsEarned property
        private System.Decimal? _NumberOfCreditsEarned;

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

        public System.String ActivityTitle  { get => _ActivityTitle; set => SetProperty(ref _ActivityTitle, value); }

        public System.String ActivityIdentifier  { get => _ActivityIdentifier; set => SetProperty(ref _ActivityIdentifier, value); }

        public System.DateTime? ActivityStartDate { get => _ActivityStartDate; set => SetProperty(ref _ActivityStartDate, value); }

        public System.DateTime? ActivityCompletionDate { get => _ActivityCompletionDate; set => SetProperty(ref _ActivityCompletionDate, value); }

        public System.Boolean? ScholarshipStatus { get => _ScholarshipStatus; set => SetProperty(ref _ScholarshipStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupportId"/> model
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnitId"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivityId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentSessionId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get; set; }

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
        public void Load(IStaffProfessionalDevelopmentActivity model)
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
