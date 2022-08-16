//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The TeacherEducationCredentialExamViewModel
     /// </summary>
    public partial class TeacherEducationCredentialExamViewModel : ViewModelBase, Interfaces.ITeacherEducationCredentialExam
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from TeacherEducationCredentialExam";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefTeacherEducationCredentialExamId property
        private  _RefTeacherEducationCredentialExamId;

        // member variable for the RefTeacherEducationExamScoreTypeId property
        private  _RefTeacherEducationExamScoreTypeId;

        // member variable for the RefTeacherEducationTestCompanyId property
        private Guid? _RefTeacherEducationTestCompanyId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationCredentialExam"/> model
        /// </summary>
        public  RefTeacherEducationCredentialExamId { get => _RefTeacherEducationCredentialExamId; set => SetProperty(ref _RefTeacherEducationCredentialExamId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationExamScoreType"/> model
        /// </summary>
        public  RefTeacherEducationExamScoreTypeId { get => _RefTeacherEducationExamScoreTypeId; set => SetProperty(ref _RefTeacherEducationExamScoreTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationTestCompany"/> model
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get => _RefTeacherEducationTestCompanyId; set => SetProperty(ref _RefTeacherEducationTestCompanyId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ITeacherEducationCredentialExam model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefTeacherEducationCredentialExamId = model.RefTeacherEducationCredentialExamId; // 
            RefTeacherEducationExamScoreTypeId = model.RefTeacherEducationExamScoreTypeId; // 
            RefTeacherEducationTestCompanyId = model.RefTeacherEducationTestCompanyId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
