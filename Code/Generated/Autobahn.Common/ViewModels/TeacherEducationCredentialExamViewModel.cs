//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherEducationCredentialExamViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The TeacherEducationCredentialExamViewModel
     /// </summary>
    public partial class TeacherEducationCredentialExamViewModel : ViewModelBase, Interfaces.ITeacherEducationCredentialExamViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from TeacherEducationCredentialExam";

        // member variable for the RefTeacherEducationCredentialExamId property
        private Guid? _RefTeacherEducationCredentialExamId;

        // member variable for the RefTeacherEducationExamScoreTypeId property
        private Guid? _RefTeacherEducationExamScoreTypeId;

        // member variable for the RefTeacherEducationTestCompanyId property
        private Guid? _RefTeacherEducationTestCompanyId;

        // member variable for the ProgramParticipationTeacherPrepId property
        private Guid _ProgramParticipationTeacherPrepId;

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
        /// The title of the TeacherEducationCredentialExamViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationCredentialExamId"/> model
        /// </summary>
        public Guid? RefTeacherEducationCredentialExamId { get => _RefTeacherEducationCredentialExamId; set => SetProperty(ref _RefTeacherEducationCredentialExamId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationExamScoreTypeId"/> model
        /// </summary>
        public Guid? RefTeacherEducationExamScoreTypeId { get => _RefTeacherEducationExamScoreTypeId; set => SetProperty(ref _RefTeacherEducationExamScoreTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationTestCompanyId"/> model
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get => _RefTeacherEducationTestCompanyId; set => SetProperty(ref _RefTeacherEducationTestCompanyId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationTeacherPrepId"/> model
        /// </summary>
        public Guid ProgramParticipationTeacherPrepId { get => _ProgramParticipationTeacherPrepId; set => SetProperty(ref _ProgramParticipationTeacherPrepId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ITeacherEducationCredentialExam model)
        {
            IsBusy = true;
            Id = model.Id;
            RefTeacherEducationCredentialExamId = model.RefTeacherEducationCredentialExamId;
            RefTeacherEducationExamScoreTypeId = model.RefTeacherEducationExamScoreTypeId;
            RefTeacherEducationTestCompanyId = model.RefTeacherEducationTestCompanyId;
            ProgramParticipationTeacherPrepId = model.ProgramParticipationTeacherPrepId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
