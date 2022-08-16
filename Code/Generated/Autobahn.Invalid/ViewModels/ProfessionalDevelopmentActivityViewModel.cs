//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
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
        private  _ActivityCode;

        // member variable for the ActivityIdentifier property
        private  _ActivityIdentifier;

        // member variable for the ApprovalCode property
        private  _ApprovalCode;

        // member variable for the Cost property
        private  _Cost;

        // member variable for the Credits property
        private  _Credits;

        // member variable for the Description property
        private  _Description;

        // member variable for the Objective property
        private  _Objective;

        // member variable for the ProfessionalDevelopmentActivityStateApprovedStatus property
        private  _ProfessionalDevelopmentActivityStateApprovedStatus;

        // member variable for the PublishIndicator property
        private  _PublishIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        // member variable for the RefPDActivityApprovedPurposeId property
        private  _RefPDActivityApprovedPurposeId;

        // member variable for the RefPDActivityCreditTypeId property
        private  _RefPDActivityCreditTypeId;

        // member variable for the RefPDActivityLevelId property
        private  _RefPDActivityLevelId;

        // member variable for the RefPDActivityTypeId property
        private  _RefPDActivityTypeId;

        // member variable for the RefPDAudienceTypeId property
        private  _RefPDAudienceTypeId;

        // member variable for the RefProfessionalDevelopmentFinancialSupportId property
        private  _RefProfessionalDevelopmentFinancialSupportId;

        // member variable for the ScholarshipStatus property
        private  _ScholarshipStatus;

        // member variable for the Title property
        private  _Title;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ActivityCode { get => _ActivityCode; set => SetProperty(ref _ActivityCode, value); }

        /// <summary>
        /// </summary>
        public  ActivityIdentifier { get => _ActivityIdentifier; set => SetProperty(ref _ActivityIdentifier, value); }

        /// <summary>
        /// </summary>
        public  ApprovalCode { get => _ApprovalCode; set => SetProperty(ref _ApprovalCode, value); }

        /// <summary>
        /// </summary>
        public  Cost { get => _Cost; set => SetProperty(ref _Cost, value); }

        /// <summary>
        /// </summary>
        public  Credits { get => _Credits; set => SetProperty(ref _Credits, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  Objective { get => _Objective; set => SetProperty(ref _Objective, value); }

        /// <summary>
        /// </summary>
        public  ProfessionalDevelopmentActivityStateApprovedStatus { get => _ProfessionalDevelopmentActivityStateApprovedStatus; set => SetProperty(ref _ProfessionalDevelopmentActivityStateApprovedStatus, value); }

        /// <summary>
        /// </summary>
        public  PublishIndicator { get => _PublishIndicator; set => SetProperty(ref _PublishIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityApprovedPurpose"/> model
        /// </summary>
        public  RefPDActivityApprovedPurposeId { get => _RefPDActivityApprovedPurposeId; set => SetProperty(ref _RefPDActivityApprovedPurposeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityCreditType"/> model
        /// </summary>
        public  RefPDActivityCreditTypeId { get => _RefPDActivityCreditTypeId; set => SetProperty(ref _RefPDActivityCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityLevel"/> model
        /// </summary>
        public  RefPDActivityLevelId { get => _RefPDActivityLevelId; set => SetProperty(ref _RefPDActivityLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityType"/> model
        /// </summary>
        public  RefPDActivityTypeId { get => _RefPDActivityTypeId; set => SetProperty(ref _RefPDActivityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDAudienceType"/> model
        /// </summary>
        public  RefPDAudienceTypeId { get => _RefPDAudienceTypeId; set => SetProperty(ref _RefPDAudienceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        public  RefProfessionalDevelopmentFinancialSupportId { get => _RefProfessionalDevelopmentFinancialSupportId; set => SetProperty(ref _RefProfessionalDevelopmentFinancialSupportId, value); }

        /// <summary>
        /// </summary>
        public  ScholarshipStatus { get => _ScholarshipStatus; set => SetProperty(ref _ScholarshipStatus, value); }

        /// <summary>
        /// </summary>
        public  Title { get => _Title; set => SetProperty(ref _Title, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityCode = model.ActivityCode; // 
            ActivityIdentifier = model.ActivityIdentifier; // 
            ApprovalCode = model.ApprovalCode; // 
            Cost = model.Cost; // 
            Credits = model.Credits; // 
            Description = model.Description; // 
            Objective = model.Objective; // 
            ProfessionalDevelopmentActivityStateApprovedStatus = model.ProfessionalDevelopmentActivityStateApprovedStatus; // 
            PublishIndicator = model.PublishIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCourseCreditUnitId = model.RefCourseCreditUnitId; // 
            RefPDActivityApprovedPurposeId = model.RefPDActivityApprovedPurposeId; // 
            RefPDActivityCreditTypeId = model.RefPDActivityCreditTypeId; // 
            RefPDActivityLevelId = model.RefPDActivityLevelId; // 
            RefPDActivityTypeId = model.RefPDActivityTypeId; // 
            RefPDAudienceTypeId = model.RefPDAudienceTypeId; // 
            RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId; // 
            ScholarshipStatus = model.ScholarshipStatus; // 
            Title = model.Title; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
