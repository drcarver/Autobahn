//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherEducationCredentialExamViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The TeacherEducationCredentialExamViewModel
     /// </summary>
    public partial class TeacherEducationCredentialExamViewModel : BindableBase, ITeacherEducationCredentialExam
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationCredentialExamId"/> model
        /// </summary>
        public Guid? RefTeacherEducationCredentialExamId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationExamScoreTypeId"/> model
        /// </summary>
        public Guid? RefTeacherEducationExamScoreTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeacherEducationTestCompanyId"/> model
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationTeacherPrepId"/> model
        /// </summary>
        public Guid ProgramParticipationTeacherPrepId { get; set; }

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
        public void Load(ITeacherEducationCredentialExam model)
        {
            IsBusy = true;
            Id = model.Id;
            RefTeacherEducationCredentialExamId = model.RefTeacherEducationCredentialExamId;
            RefTeacherEducationExamScoreTypeId = model.RefTeacherEducationExamScoreTypeId;
            RefTeacherEducationTestCompanyId = model.RefTeacherEducationTestCompanyId;
            ProgramParticipationTeacherPrepId = model.ProgramParticipationTeacherPrepId;
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
