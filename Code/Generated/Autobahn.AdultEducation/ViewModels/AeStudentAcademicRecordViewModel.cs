//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentAcademicRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeStudentAcademicRecordViewModel
     /// </summary>
    public partial class AeStudentAcademicRecordViewModel : ViewModelBase, Interfaces.IAeStudentAcademicRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeStudentAcademicRecord";

        // member variable for the DiplomaOrCredentialAwardDate property
        private Guid? _DiplomaOrCredentialAwardDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefHighSchoolDiplomaTypeId property
        private  _RefHighSchoolDiplomaTypeId;

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
        public Guid? DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
        /// </summary>
        public  RefHighSchoolDiplomaTypeId { get => _RefHighSchoolDiplomaTypeId; set => SetProperty(ref _RefHighSchoolDiplomaTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        public  RefProfessionalTechnicalCredentialTypeId { get => _RefProfessionalTechnicalCredentialTypeId; set => SetProperty(ref _RefProfessionalTechnicalCredentialTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefHighSchoolDiplomaTypeId = model.RefHighSchoolDiplomaTypeId; // 
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
