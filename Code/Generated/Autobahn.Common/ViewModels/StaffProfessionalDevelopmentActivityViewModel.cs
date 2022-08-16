//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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
        private  _ActivityCompletionDate;

        // member variable for the ActivityIdentifier property
        private  _ActivityIdentifier;

        // member variable for the ActivityStartDate property
        private  _ActivityStartDate;

        // member variable for the ActivityTitle property
        private  _ActivityTitle;

        // member variable for the NumberOfCreditsEarned property
        private  _NumberOfCreditsEarned;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        // member variable for the RefProfessionalDevelopmentFinancialSupportId property
        private  _RefProfessionalDevelopmentFinancialSupportId;

        // member variable for the ScholarshipStatus property
        private  _ScholarshipStatus;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ActivityCompletionDate { get => _ActivityCompletionDate; set => SetProperty(ref _ActivityCompletionDate, value); }

        /// <summary>
        /// </summary>
        public  ActivityIdentifier { get => _ActivityIdentifier; set => SetProperty(ref _ActivityIdentifier, value); }

        /// <summary>
        /// </summary>
        public  ActivityStartDate { get => _ActivityStartDate; set => SetProperty(ref _ActivityStartDate, value); }

        /// <summary>
        /// </summary>
        public  ActivityTitle { get => _ActivityTitle; set => SetProperty(ref _ActivityTitle, value); }

        /// <summary>
        /// </summary>
        public  NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

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
        /// Reference to an optional instance of the <see cref="RefProfessionalDevelopmentFinancialSupport"/> model
        /// </summary>
        public  RefProfessionalDevelopmentFinancialSupportId { get => _RefProfessionalDevelopmentFinancialSupportId; set => SetProperty(ref _RefProfessionalDevelopmentFinancialSupportId, value); }

        /// <summary>
        /// </summary>
        public  ScholarshipStatus { get => _ScholarshipStatus; set => SetProperty(ref _ScholarshipStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityCompletionDate = model.ActivityCompletionDate; // 
            ActivityIdentifier = model.ActivityIdentifier; // 
            ActivityStartDate = model.ActivityStartDate; // 
            ActivityTitle = model.ActivityTitle; // 
            NumberOfCreditsEarned = model.NumberOfCreditsEarned; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCourseCreditUnitId = model.RefCourseCreditUnitId; // 
            RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId; // 
            ScholarshipStatus = model.ScholarshipStatus; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
