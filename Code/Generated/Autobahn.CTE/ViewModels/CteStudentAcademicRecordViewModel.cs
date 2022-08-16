//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteStudentAcademicRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.CTE.ViewModels
{
     /// <summary>
     /// The CteStudentAcademicRecordViewModel
     /// </summary>
    public partial class CteStudentAcademicRecordViewModel : ViewModelBase, Interfaces.ICteStudentAcademicRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CteStudentAcademicRecord";

        // member variable for the CreditsAttemptedCumulative property
        private Guid? _CreditsAttemptedCumulative;

        // member variable for the CreditsEarnedCumulative property
        private  _CreditsEarnedCumulative;

        // member variable for the DiplomaOrCredentialAwardDate property
        private  _DiplomaOrCredentialAwardDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefProfessionalTechnicalCredentialTypeId property
        private  _RefProfessionalTechnicalCredentialTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? CreditsAttemptedCumulative { get => _CreditsAttemptedCumulative; set => SetProperty(ref _CreditsAttemptedCumulative, value); }

        /// <summary>
        /// </summary>
        public  CreditsEarnedCumulative { get => _CreditsEarnedCumulative; set => SetProperty(ref _CreditsEarnedCumulative, value); }

        /// <summary>
        /// </summary>
        public  DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        public  RefProfessionalTechnicalCredentialTypeId { get => _RefProfessionalTechnicalCredentialTypeId; set => SetProperty(ref _RefProfessionalTechnicalCredentialTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICteStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // 
            CreditsEarnedCumulative = model.CreditsEarnedCumulative; // 
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
